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

                orders_box.SelectedItem = "all";
                Init_orders();
                sort_orders_box.Hide();
                sort_orders_label.Hide();

                options.Parent = null;

                order_sort_box.SelectedItem = "Item_Name";

                Init_new_order_view();

                order_cancelled_button.Enabled = false;
                close_order_button.Enabled = false;
                upd_order_button.Enabled = false;
                
                close_item_info_button.Enabled = false;
            }


            //только для клиента
            if (is_client)
            {
                orders_box.SelectedItem = "all";
                general_orders.Text = "Мои заказы";

                item_info.Parent = null;

                Init_orders();
                upd_order_button.Hide();
                create_order.Parent = null;        //создает новый заказ ТОЛЬКО продавец!!
                sort_orders_box.SelectedItem = "OrderID";

                order_sort_box.SelectedItem = "Item_Name";

                order_cancelled_button.Enabled = false;
                close_order_button.Enabled = false;

                fix_reserve_button.Hide();
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
                Orders.Parent = null;
            }
        }


        public void Init_product_list()
        {
            BindingSource bs = new BindingSource();
            string command = "Select * FROM Product_List";
            SqlCommand cmd = SqlExec(command);
            ViewQuery(cmd, products_view, bs);
        }

        private void Init_orders()
        {
            string command = "";
            if (is_seller)
                command = "Select OrderID, ClientID, Surname, [Order Date], Status FROM Clients_Orders_all";
            else
            {
                command = "Select OrderID, [Order Date], Status FROM Clients_Orders_all Where ClientID = " + user_id.ToString();
                orders_list.AutoSize = true;
            }

            BindingSource bs = new BindingSource();
            SqlCommand cmd = SqlExec(command);
            ViewQuery(cmd, orders_list, bs);
        }

        private void Init_basket_list()
        {
            BindingSource bs = new BindingSource();
            string command = "SELECT Item_Name, Amount FROM Basket JOIN Items ON Basket.ItemID = Items.Article";
            SqlCommand cmd = SqlExec(command);
            ViewQuery(cmd, basket_list, bs);
        }

        private void Clean_basket_list()
        {
            BindingSource bs = new BindingSource();
            basket_list.DataSource = bs;
        }

        private void Init_new_order_view()
        {
            itemid_textbox.Enabled = false;
            itemnum_textbox.Enabled = false;
            make_order_button.Enabled = false;
            clean_basket_button.Enabled = false;
            exit_neworder_button.Enabled = false;
            item_add_button.Enabled = false;

            put_clientid_textbox.Enabled = true;
            put_clientid_textbox.Text = "";
            put_clientid_button.Enabled = true;
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

                // если товар попал в Reserved, т.е. нужно докупить для выдачи заказа - сделать кнопку для фикса доступной
                SqlCommand sqlF = new SqlCommand("Select Reserved FROM Items Where Article = " + ids, cnn);
                if (Int16.Parse(sqlF.ExecuteScalar().ToString()) > 0)
                {
                    fix_reserve_button.Enabled = true;
                }

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

        private void orders_button_Click(object sender, EventArgs e)
        {
            string orderby = "";
            string wtf = "";
            string command = "";

            if (is_client)
                orderby = "Order by " + sort_orders_box.SelectedItem.ToString();

            wtf = orders_box.SelectedItem.ToString();

            if (is_client)
                command = "Select OrderID, [Order Date], Status FROM Clients_Orders_" + wtf + " Where ClientID = " + user_id.ToString() + " " + orderby;
            else
                command = "Select OrderID, ClientID, Surname, [Order Date], Status FROM Clients_Orders_" + wtf;

            BindingSource bs = new BindingSource();
            SqlCommand cmd = SqlExec(command);
            ViewQuery(cmd, orders_list, bs);
        }

        private void order_id_button_Click(object sender, EventArgs e)
        {
            string ids = "";
            checked_order_id = 0;
            string sortby = order_sort_box.SelectedItem.ToString();

            try
            {
                ids = order_id_textbox.Text.ToString();

                if (ids.Length == 0)
                    throw new WarningException("Не введен ID!");

                checked_order_id = Int16.Parse(ids);

                //поищем данный order_id в базе данных
                SqlCommand sqlC = new SqlCommand("Select * FROM ClientOrder Where OrderID = " + ids, cnn);
                if (sqlC.ExecuteScalar().ToString() != ids)
                {
                    MessageBox.Show("Такого ID не существует!");
                    order_info_list.Rows.Clear();
                    order_info_list.Columns.Clear();
                    checked_order_id = 0;
                    return;
                }

                //проверим, что данный номер заказа соответствует клиенту
                if (is_client)
                {
                    SqlCommand sq = new SqlCommand("Select ClientID FROM Clients_Orders_all Where OrderID = " + ids, cnn);
                    if (sq.ExecuteScalar().ToString() != user_id.ToString())
                    {
                        MessageBox.Show("Данный номер заказа не принадлежит Вам!", "Ошибка!");
                        order_info_list.Rows.Clear();
                        order_info_list.Columns.Clear();
                        checked_order_id = 0;
                        return;
                    }
                }

                string search = new SqlCommand("Select Status FROM ClientOrder Where OrderID = " + ids, cnn).ExecuteScalar().ToString();
                if (search == "Ready" || search == "Sold") 
                {
                    order_cancelled_button.Enabled = false;
                    if (search == "Sold")
                        upd_order_button.Enabled = false;
                    else
                        upd_order_button.Enabled = true;
                }
                else
                {
                    upd_order_button.Enabled = true;
                    order_cancelled_button.Enabled = true;
                }

                //если найден - показать инфо
                BindingSource bs = new BindingSource();
                string command = "Execute Check_Order " + ids + ", " + sortby;
                SqlCommand cmd = SqlExec(command);
                ViewQuery(cmd, order_info_list, bs);

                close_order_button.Enabled = true;
               // order_id_button.Enabled = false;
                order_id_textbox.Enabled = false;
            }
            catch (WarningException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка");
                checked_order_id = 0;
            }
            catch (FormatException ee)
            {
                MessageBox.Show("Некорректный ID!", "Ошибка");
                checked_order_id = 0;
            }
            catch (NullReferenceException ee)
            {
                MessageBox.Show("Такого ID не существует!", "Ошибка");
                checked_order_id = 0;
            }
        }

        private void order_cancelled_button_Click(object sender, EventArgs e)
        {
            if (checked_order_id == 0)
            {
                MessageBox.Show("Не выбран заказ для проверки или удаления!");
                return;
            }
            else
            {
                if (MessageBox.Show("Действительно удалить данный заказ?", "Удаление заказа", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string command = "DELETE FROM ClientOrder Where OrderID = " + order_id_textbox.Text.ToString() + ";";
                    SqlCommand cmd = SqlExec(command);
                    MessageBox.Show("Успешное удаление заказа! :)", "SUCCESS!");
                    Init_orders();
                    order_id_textbox.Text = "";
                    checked_order_id = 0;

                    order_info_list.DataSource = new BindingSource();
                    order_cancelled_button.Enabled = false;
                    close_order_button.Enabled = false;
                    upd_order_button.Enabled = false;
                    order_id_button.Enabled = true;
                    order_id_textbox.Enabled = true;
                }
            }
        }

        private void put_clientid_button_Click(object sender, EventArgs e)
        {
            string ids = "";
            int id = 0;

            try
            {
                ids = put_clientid_textbox.Text.ToString();

                if (ids.Length == 0)
                    throw new WarningException("Не введен ID!");

                id = Int16.Parse(ids);

                //поищем данный client_id в базе данных
                SqlCommand sqlC = new SqlCommand("Select * FROM Clients_view Where ClientID = " + ids, cnn);
                if (sqlC.ExecuteScalar().ToString() != ids)
                {
                    MessageBox.Show("Такого ID не существует!");
                    return;
                }

                //если найден - создать запись в ClientOrders
                string command = "INSERT INTO ClientOrder (Client, [Order Date], SellerID) VALUES(" + ids + ", GETDATE(), " + user_id + ");";
                SqlCommand cmd = SqlExec(command);
                MessageBox.Show("Теперь можете добавлять товары в корзину :)", "SUCCESS!");

                item_add_button.Enabled = true;
                itemid_textbox.Enabled = true;
                itemnum_textbox.Enabled = true;
                exit_neworder_button.Enabled = true;

                put_clientid_button.Enabled = false;
                put_clientid_textbox.Enabled = false;

                Init_orders();
            }
            catch (WarningException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка");
            }
            catch (FormatException ee)
            {
                MessageBox.Show("Некорректный ID!", "Ошибка");
            }
            catch (NullReferenceException ee)
            {
                MessageBox.Show("Такого ID не существует!", "Ошибка");
            }
        }

        private void item_add_button_Click(object sender, EventArgs e)
        {
            string item_ids = "", num_ids = "";
            int id = 0, num = 0;

            try
            {
                item_ids = itemid_textbox.Text.ToString();
                num_ids = itemnum_textbox.Text.ToString();

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

                //если найден - добавить в корзину
                SqlCommand cc = new SqlCommand("Select MAX(OrderID) FROM ClientOrder", cnn);
                string ccs = cc.ExecuteScalar().ToString();

                string command = "INSERT INTO Basket VALUES(" + item_ids + ", " + num_ids + ", " + ccs + ")";
                SqlCommand cmd = SqlExec(command);
                MessageBox.Show("Успешно добавлено в корзину! :)", "SUCCESS!");

                Init_basket_list();
                make_order_button.Enabled = true;
                clean_basket_button.Enabled = true;
                itemid_textbox.Text = "";
                itemnum_textbox.Text = "";
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

        private void clean_basket_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены?","Очистка корзины",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string command = "DELETE FROM Basket";
                SqlCommand cmd = SqlExec(command);
                MessageBox.Show("Успешно очищено :)", "SUCCESS!");

                Clean_basket_list();
                make_order_button.Enabled = false;
                clean_basket_button.Enabled = false;
            }
        }

        private void exit_neworder_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Cancel order",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string command0 = "DELETE FROM Basket";
                SqlCommand cmd0 = SqlExec(command0);
                //MessageBox.Show("Успешно очищено :)", "SUCCESS!");

                Clean_basket_list();

                string command = "DELETE FROM ClientOrder Where OrderID = (Select MAX(ClientOrder.OrderID) FROM ClientOrder)";
                SqlCommand cmd = SqlExec(command);
                MessageBox.Show("Заказ успешно отменен! :)", "SUCCESS!");

                Init_orders();
                Init_new_order_view();
            }
        }

        private void close_order_button_Click(object sender, EventArgs e)
        {
            order_cancelled_button.Enabled = false;
            close_order_button.Enabled = false;
            upd_order_button.Enabled = false;
            order_id_button.Enabled = true;
            order_id_textbox.Enabled = true;
            order_id_textbox.Text = "";
            checked_order_id = 0;
            order_info_list.DataSource = new BindingSource();
        }


        private void upd_order_button_Click(object sender, EventArgs e)
        {
            string order_num = order_id_textbox.Text.ToString();
            bool isnew = false;
            bool isready = false;

            string search = new SqlCommand("Select Status FROM ClientOrder Where OrderID = " + order_num, cnn).ExecuteScalar().ToString();
            if (search == "New")
                isnew = true;
            if (search == "Ready")
                isready = true;

            if (isready)
            {
                string command = "Execute Seller_sold_order " + order_num;
                SqlCommand cmd = SqlExec(command);
                MessageBox.Show("Заказ продан!", "SUCCESS");
            }
            else
            {
                string command = "Execute Seller_upd_order " + order_num;
                SqlCommand cmd = SqlExec(command);

                string num_ofwait = new SqlCommand("Select Count(*) FROM Ordered_Items Where Status = 'Wait' AND OrderID = " + order_num, cnn).ExecuteScalar().ToString();
                string num_ready = new SqlCommand("Select Count(*) FROM Ordered_Items Where Status = 'Ready' AND OrderID = " + order_num, cnn).ExecuteScalar().ToString();

                if (num_ofwait == "0")
                {
                    new SqlCommand("UPDATE ClientOrder SET Status = 'Ready' Where OrderID = " + order_num, cnn).ExecuteNonQuery();
                }

                MessageBox.Show("Итоги: " + num_ofwait + " наименований в исполнении. " + num_ready + " - готово к продаже","SUCCESS");
            }

            Init_orders();
            Init_product_list();
            order_id_button.PerformClick();
        }

        private void close_item_info_button_Click(object sender, EventArgs e)
        {
            item_id_textbox.Enabled = true;
            check_item_button.Enabled = true;
            item_id_textbox.Text = "";

            item_id_info.DataSource = new BindingSource();
            close_item_info_button.Enabled = false;

            fix_reserve_button.Enabled = false;
        }

        private void make_order_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Завершить создание заказа", "Create order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string command2 = "INSERT INTO ItemListToOrder (ItemID, Amount, OrderID) Select * From Basket";
                SqlCommand cmd2 = SqlExec(command2);

                string command0 = "DELETE FROM Basket";
                SqlCommand cmd0 = SqlExec(command0);
                //MessageBox.Show("Успешно очищено :)", "SUCCESS!");

                Clean_basket_list();

                MessageBox.Show("Заказ успешно создан! :)", "SUCCESS!");

                Init_orders();
                Init_new_order_view();
            }
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

        private void fix_reserve_button_Click(object sender, EventArgs e)
        {
            string ids = "";
            int id = 0;

            try
            {
                ids = item_id_textbox.Text.ToString();

                if (ids.Length == 0)
                    throw new WarningException("Не введен ID!");

                id = Int16.Parse(ids);

                //если артикул найден - сделать фикс по апдейту количества товара и обновить табличку
                string update_command = "UPDATE Items SET Num_inShop = Num_inShop + Reserved WHERE Article = " + ids;
                SqlExec(update_command);
                update_command = "UPDATE Items SET Reserved = 0 WHERE Article = " + ids;
                SqlExec(update_command);

                BindingSource bs = new BindingSource();
                string command = "Execute Product_Info " + ids;
                SqlCommand cmd = SqlExec(command);
                ViewQuery(cmd, item_id_info, bs);

                Init_product_list();

                fix_reserve_button.Enabled = false;
            }
            catch (WarningException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка");
            }
            catch (FormatException ee)
            {
                MessageBox.Show("Некорректный ID!", "Ошибка");
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
