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
    public partial class Form1 : Form
    {
        private SqlConnection cnn;
        private string connectionAdress = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=practice_music_shop;Integrated Security=True";
        private BindingSource bs = new BindingSource();

        private string user;
        private string password;

        public Form1()
        {
            InitializeComponent();
            Clean();
        }

        public void Clean()
        {
            Login_box.Text = "";
            password_box.Text = "";
            Login_box.Focus();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            user = Login_box.Text;
            password = password_box.Text;
            if (user != password && password != user.Substring(0,user.IndexOf('_')) || user.Length == 0)
            {
                MessageBox.Show("Incorrect username or password!");
                this.Clean();
                return;
            }

            if (user == "admin")
                OpenConnect(true);
            else
                OpenConnect(false);
            CloseConnect();
        }

        private void CloseConnect()
        {
            cnn.Close();
        }

        private void OpenConnect(bool is_admin)
        {
            cnn = new SqlConnection(connectionAdress);
            bool client = false, agent = false, seller = false;

            try
            {
                cnn.Open();
                Base baseform;
                if (is_admin) {
                    //if (cnn.State == System.Data.ConnectionState.Open)
                    //{
                    //    MessageBox.Show("YYYYYYYY");
                    //}
                    baseform = new Base(this, is_admin, seller, client, 0);
                }
                else
                {
                    //проверка на клиента или staff
                    Tuple<int,int,int> up = Find_User();
                    //MessageBox.Show(up.Item1.ToString() + up.Item2.ToString());
                    switch (up.Item1)
                    {
                        case -1: client = true; break;
                        case 0: seller = true; break;
                        case 1: agent = true; break;
                    }

                    baseform = new Base(this, is_admin, seller, client, up.Item2,up.Item3);
                }

                MessageBox.Show("Connected!", "LOGIN");
                this.Hide();
                this.Clean();
                baseform.Show();
            }
            catch(NullReferenceException ee)
            {
                MessageBox.Show("Такого пользователя нет в базе!", "FAILED!");
                this.Clean();
            }
            catch (Exception ex)
            {
                string mes = "Ошибка!";
                string error = "Не удалось подключиться к серверу";
                MessageBox.Show(error, mes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Clean();
            }
        }
       
        private void Exit_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }


        private Tuple<int,int,int> Find_User()
        {
            int t1 = 0, t2 = 0, t3 = 0;
            user = user.Substring(0, 1).ToUpper() + user.Substring(1, user.Length - 1);
           // MessageBox.Show(user);

            int temp = 0;
            SqlCommand sqlCommand;
            if ((temp = user.IndexOf("_staff")) != -1)
            {
                sqlCommand = new SqlCommand("Select Surname FROM Staff Where Surname = '" + user.Substring(0,temp) + "'", cnn);
                if (sqlCommand.ExecuteScalar().ToString() == user.Substring(0, temp))
                {
                    //bool function
                    Int32.TryParse(new SqlCommand("Select Position FROM Staff Where Surname = '" + user.Substring(0, temp) + "'", cnn).ExecuteScalar().ToString(), out t3);
                    t1 = t3 - 1;
                    Int32.TryParse(new SqlCommand("Select StaffID FROM Staff Where Surname = '" + user.Substring(0, temp) + "'", cnn).ExecuteScalar().ToString(), out t2);
                }
            }
            else
            {
             //   MessageBox.Show("NOT STAFF");
                sqlCommand = new SqlCommand("Select Surname FROM Clients Where Surname = '" + user + "'", cnn);
                if (sqlCommand.ExecuteScalar().ToString() == user)
                {
               //     MessageBox.Show("FOUND");
                    Int32.TryParse(new SqlCommand("Select ClientID FROM Clients Where Surname = '" + user + "'", cnn).ExecuteScalar().ToString(), out t2);
                    t1 = - 1;
                }
                //else
                  //  MessageBox.Show("NOT FOUND " + sqlCommand.ExecuteScalar().ToString() + " " + sqlCommand.ExecuteScalar().ToString().Length);
            }

            return new Tuple<int,int,int>(t1,t2,t3);
        }

    }
}
