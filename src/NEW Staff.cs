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
    public partial class NEW_Staff : Form
    {
        private SqlConnection cnn_conn;
        private Base baseform;

        public NEW_Staff(SqlConnection cnn, Base form_parent)
        {
            InitializeComponent();

            baseform = form_parent;
            cnn_conn = cnn;
        }

        private void add_staff_button_Click(object sender, EventArgs e)
        {
            string name = "", surname = "", age_s = "", position_s = "1";
            int age = 0, position = 1;

            try
            {
                name = name_textbox.Text.ToString();
                surname = surname_textbox.Text.ToString();
                age_s = age_textbox.Text.ToString();

                if (name.Length == 0 || surname.Length == 0 || age_s.Length == 0)
                    throw new WarningException("Введены не все поля!!");

                age = Int16.Parse(age_s);

                if (age < 18 || age > 35)
                {
                    MessageBox.Show("Введенный возраст не годен! Используйте параметр Age от 18 до 35.", "Ошибка!");
                    age_textbox.Text = "";
                    return;
                }

                name = name.Substring(0, 1).ToUpper().ToString() + name.Substring(1, name.Length - 1);
                surname = surname.Substring(0, 1).ToUpper().ToString() + surname.Substring(1, surname.Length - 1);

                string command = "INSERT INTO Staff (Name, Surname, Age, Position) VALUES ('" 
                                        + name + "', '" + surname + "', " + age_s + ", " + position_s + ")"; 
                SqlCommand cmd = new SqlCommand(command, cnn_conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлен сотрудник!", "SUCCESS");

                this.Hide();
                this.Clear_boxes();
                baseform.Show();
                baseform.Init_staff_list();
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


        private void Clear_boxes()
        {
            name_textbox.Text = "";
            surname_textbox.Text = "";
            age_textbox.Text = "";
            position_textbox.Text = "";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены, что хотите отменить?", "Отмена", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                this.Clear_boxes();
                baseform.Show();
            }
        }
    }
}
