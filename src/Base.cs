using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace shop
{
    public partial class Base : Form
    {
        private SqlConnection cnn;
        private string connectionAdress = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=practice_music_shop;Integrated Security=True";
        //нижеследующие булевы переменные передаются в конструкторе от формы FORM1
        private bool is_admin = false;  //для админа
        private bool is_seller = false;
        private bool is_client = false;

        private int user_id = 0;        //id вошедшего пользователя в базе данных по его профилю
        private int post_id = 0;    //номер позиции работника магазина или склада

        private int checked_order_id = 0;       //номер заказа для отмены в случае желания (только после CHECK!)

        private BindingSource bs_pob = new BindingSource();     // для кнопки обновления информации об акциях

        Form form1;
        NEW_Item form_item;

        public Base(Form form_parent,bool admin, bool seller, bool client, int id, int post = 0)
        {
            InitializeComponent();

            form1 = form_parent;

            is_admin = admin;
            is_seller = seller;
            is_client = client;
            user_id = id;
            post_id = post;
            //queries follow here -->

            // открытие соединения
            OpenConnect();

            //инициализация всех таблиц в зависимости от учетной записи
            InitFields();

            form_item = new NEW_Item(cnn, this);

            //and make the options for each datagridview
            do_options();
        }

        private void Products_Click(object sender, EventArgs e)
        {

        }

        private void do_options()
        {
            //products_view.AutoSize = true;
            //others
        }

        private void CloseConnect()
        {
            cnn.Close();
        }

        private void OpenConnect()
        {
            cnn = new SqlConnection(connectionAdress);
            try
            {
                cnn.Open();
                //MessageBox.Show("Connected!");
                //проверка на клиента или staff

            }
            catch (Exception ex)
            {
                string mes = "Ошибка!";
                string error = "Не удалось подключиться к серверу";
                MessageBox.Show(error, mes, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private SqlCommand SqlExec(string sqlcommand)
        {
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            return cmd;
        }

        private void ViewQuery(SqlCommand cmd, DataGridView dtv, BindingSource _bs)
        {
            DataTable tab = new DataTable();
            tab.Load(cmd.ExecuteReader());
            _bs.DataSource = tab.DefaultView;
            dtv.DataSource = _bs;
        }

        private void InitFields()
        {
            Init_product_list();

            //только для продавца
            if (is_seller)
            {
                from_range_textbox.Hide();
                to_range_textbox.Hide();
                from_range_label.Hide();
                to_range_label.Hide();

                options.Parent = null;

                close_item_info_button.Enabled = false;
            }


            //только для клиента
            if (is_client)
            {
                item_info.Parent = null;
                
                new_item_button.Hide();

                update_item_amount_label.Hide();
                upd_item_amount_button.Hide();
                upd_item_amount_item_ID_label.Hide();
                upd_item_amount_item_ID_textbox.Hide();
                upd_item_amount_plus_amount_label.Hide();
                upd_item_amount_textbox.Hide();
            }

            //только админ
            if (is_admin)
            {
                Products.Parent = null;
            }
        }


        public void Init_product_list()
        {
            BindingSource bs = new BindingSource();
            string command = "Select * FROM Product_List";
            SqlCommand cmd = SqlExec(command);
            ViewQuery(cmd, products_view, bs);
        }
        
        private void Disconnect_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти из учетной записи?", "Смена пользователя", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CloseConnect();
                this.Close();
                form1.Show();
            }
        }

        private void product_option_button_Click(object sender, EventArgs e)
        {
            string range_a = "", range_b = "";
            bool is_apply = true;
            int a,b;
            try
            {
                if (is_client)
                {
                    //все оставшиеся вычисления - только для клиента!
                    range_a = from_range_textbox.Text.ToString();
                    range_b = to_range_textbox.Text.ToString();

                    if (range_a.Length != 0)
                        a = Int32.Parse(range_a);
                    else
                    {
                        a = 0;
                        range_a = a.ToString();
                        MessageBox.Show(range_a);
                    }

                    if (range_b.Length != 0)
                        b = Int32.Parse(range_b);
                    else
                    {
                        b = Int32.MaxValue;
                        range_b = b.ToString();
                        MessageBox.Show(range_b);
                    }

                    if (a < 0 || b < a || b < 0)
                        throw new WarningException("Некорректно указан диапазон!");
                }
            }
            catch (NullReferenceException eee)
            {
                MessageBox.Show("Пожалуйста, выберите акцию!", "Ошибка");
                is_apply = false;
            }
            catch (FormatException ee)
            {
                MessageBox.Show("Некорректный ввод диапазона. Используйте цифры!", "Ошибка");
                is_apply = false;
            }
            catch(WarningException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка");
                is_apply = false;
            }   

            if (is_apply)
            {
                string command = "";
                if (is_client)
                {
                    command = "Execute Product_in_Range " + range_a + ", " + range_b + "";
                }
                SqlCommand cmd = SqlExec(command);
                ViewQuery(cmd, product_option_list, bs_pob);
            }
            else
            {
                is_apply = true;
            }
        }

        private void check_item_button_Click(object sender, EventArgs e)
        {
            string ids = "";
            int id = 0;

            try
            {
                ids = item_id_textbox.Text.ToString();

                if (ids.Length == 0)
                    throw new WarningException("Не введен ID!");

                id = Int16.Parse(ids);
                    
                //поищем данный артикул в базе данных
                SqlCommand sqlC = new SqlCommand("Select * FROM Product_List Where Article = " + ids, cnn);
                if (sqlC.ExecuteScalar().ToString() != ids)
                {
                    MessageBox.Show("Такого ID не существует!");
                    item_id_info.Rows.Clear();
                    item_id_info.Columns.Clear();
                    return;
                }

                //если артикул найден - показать инфо
                BindingSource bs = new BindingSource();
                string command = "Execute Product_Info " + ids;
                SqlCommand cmd = SqlExec(command);
                ViewQuery(cmd, item_id_info, bs);

                item_id_textbox.Enabled = false;
                check_item_button.Enabled = false;
                close_item_info_button.Enabled = true;
            }
            catch(WarningException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка");
            }
            catch(FormatException ee)
            {
                MessageBox.Show("Некорректный ID!", "Ошибка");
            }
            catch (NullReferenceException ee)
            {
                MessageBox.Show("Такого ID не существует!", "Ошибка");
            }
        }

        private void close_item_info_button_Click(object sender, EventArgs e)
        {
            item_id_textbox.Enabled = true;
            check_item_button.Enabled = true;
            item_id_textbox.Text = "";

            item_id_info.DataSource = new BindingSource();
            close_item_info_button.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void upd_item_amount_button_Click(object sender, EventArgs e)
        {
            string item_ids = "", num_ids = "";
            int id = 0, num = 0;

            try
            {
                item_ids = upd_item_amount_item_ID_textbox.Text.ToString();
                num_ids = upd_item_amount_textbox.Text.ToString();

                if (item_ids.Length == 0)
                    throw new WarningException("Не введен ID!");
                if (num_ids.Length == 0)
                    throw new WarningException("Не введено количество!");

                id = Int16.Parse(item_ids);
                num = Int16.Parse(num_ids);

                if (num <= 0)
                    throw new WarningException("Значение поля 'Количество' не может быть меньше 1!");


                //поищем данный item_id в базе данных
                SqlCommand sqlC = new SqlCommand("Select * FROM Items Where Article = " + item_ids, cnn);
                if (sqlC.ExecuteScalar().ToString() != item_ids)
                {
                    MessageBox.Show("Такого ID не существует!");
                    return;
                }

                //если найден - обновить количество

                string command = "UPDATE Items SET Num_inShop = Num_inShop + " + num_ids + "WHERE Article = " + item_ids;
                SqlCommand cmd = SqlExec(command);
                MessageBox.Show("Количество товара обновлено!", "SUCCESS!");

                Init_product_list();
                upd_item_amount_textbox.Text = "";
                upd_item_amount_item_ID_textbox.Text = "";
            }
            catch (WarningException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка");
            }
            catch (FormatException ee)
            {
                MessageBox.Show("Некорректно введен ID и(или) количество!", "Ошибка");
            }
            catch (NullReferenceException ee)
            {
                MessageBox.Show("Такого ID не существует!", "Ошибка");
            }
        }

        private void new_item_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перейти к добавлению товара?", "Новый товар", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                form_item.Show();
            }
        }
    }
}
