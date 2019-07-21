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
    public partial class NEW_Client : Form
    {
        private SqlConnection cnn_conn;
        private Base baseform;
        private Form1 loginform;

        public NEW_Client(SqlConnection cnn, Base form_parent)
        {
            InitializeComponent();

            baseform = form_parent;
            cnn_conn = cnn;
        }

        public NEW_Client(SqlConnection cnn, Form1 form_parent)
        {
            InitializeComponent();

            loginform = form_parent;
            cnn_conn = cnn;
        }
        
        private void Clear_boxes()
        {
            name_textbox.Text = "";
            surname_textbox.Text = "";
            phone_textbox.Text = "";
            email_textbox.Text = "";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены, что хотите отменить?","Отмена",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                this.Clear_boxes();
                baseform.Show();
            }
        }

        private void add_client_button_Click_1(object sender, EventArgs e)
        {
            string name = "", surname = "", phone = "", email = "";

            try
            {
                name = name_textbox.Text.ToString();
                surname = surname_textbox.Text.ToString();
                phone = phone_textbox.Text.ToString();
                email = email_textbox.Text.ToString();

                if (name.Length == 0 || surname.Length == 0)
                    throw new WarningException("Не введено имя и(или) фамилия клиента!");

                if (phone.Length == 0 && email.Length == 0)
                    throw new WarningException("Не указан ни один контакт! Укажите по крайней мере один.");
                else
                {
                    if (phone.Length == 0)
                        phone = "";
                    if (email.Length == 0)
                        email = "";
                }

                if (phone.Length > 10)
                    throw new WarningException("Слишком длинный номер.");

                name = name.Substring(0, 1).ToUpper().ToString() + name.Substring(1, name.Length - 1);
                surname = surname.Substring(0, 1).ToUpper().ToString() + surname.Substring(1, surname.Length - 1);
                email = email.ToLower();

                string command = "INSERT INTO Clients (Name, Surname, Phone, [E-mail]) VALUES ('"
                                        + name + "', '" + surname + "', '" + phone + "', '" + email + "')";
                SqlCommand cmd = new SqlCommand(command, cnn_conn);
                cmd.ExecuteNonQuery();

                if (baseform != null)
                    MessageBox.Show("Успешно добавлен клиент!", "SUCCESS");
                else
                    MessageBox.Show("Клиент зарегистрирован!", "SUCCESS");

                this.Hide();
                this.Clear_boxes();

                if (baseform != null)
                {
                    baseform.Show();
                    baseform.Init_clients_lists();
                } else
                {
                    cnn_conn.Close();
                    loginform.Show();
                }
                
            }
            catch (WarningException ee)
            {
                MessageBox.Show(ee.Message, "Ошибка");
            }
            catch (FormatException ee)
            {
                MessageBox.Show("Некорректный ввод данных!", "Ошибка");
            }
        }
    }
}
