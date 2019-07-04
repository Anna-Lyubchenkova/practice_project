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
    public partial class NEW_Item : Form
    {
        private SqlConnection cnn_conn;
        private Base baseform;

        public NEW_Item(SqlConnection cnn, Base form_parent)
        {
            InitializeComponent();

            baseform = form_parent;
            cnn_conn = cnn;
        }

        private void new_item_submit_button_Click(object sender, EventArgs e)
        {
            string name = "", cost_s = "", amount_s = "";
            int cost = 0, amount = 0;

            try
            {
                name = new_item_name_textbox.Text.ToString();
                cost_s = new_item_cost_textbox.Text.ToString();
                amount_s = new_item_amount_textbox.Text.ToString();

                if (name.Length == 0 || cost_s.Length == 0 || amount_s.Length == 0)
                    throw new WarningException("Введены не все поля!!");

                cost = Int16.Parse(cost_s);

                if (cost < 1)
                {
                    MessageBox.Show("Неправильно установлена цена!", "Ошибка!");
                    new_item_cost_textbox.Text = "";
                    return;
                }

                amount = Int16.Parse(amount_s);

                if (amount < 1)
                {
                    MessageBox.Show("Неправильно установлено количество товара!", "Ошибка!");
                    new_item_amount_textbox.Text = "";
                    return;
                }

                string command = "INSERT INTO Items (Item_Name, Cost, Num_inShop) VALUES('"
                                        + name + "', " + cost_s + ", " + amount_s + ")";

                SqlCommand cmd = new SqlCommand(command, cnn_conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлен товар!", "SUCCESS");

                this.Hide();
                this.Clear_boxes();
                baseform.Show();
                baseform.Init_product_list();
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
            new_item_amount_textbox.Text = "";
            new_item_cost_textbox.Text = "";
            new_item_name_textbox.Text = "";
        }

        private Label new_item_name_label;
        private Label new_item_amount_label;
        private Label new_item_cost_label;
        private TextBox new_item_name_textbox;
        private TextBox new_item_cost_textbox;
        private TextBox new_item_amount_textbox;
        private Button new_item_submit_button;
        private Button new_item_cancel_button;

        private void InitializeComponent()
        {
            this.new_item_name_label = new System.Windows.Forms.Label();
            this.new_item_amount_label = new System.Windows.Forms.Label();
            this.new_item_cost_label = new System.Windows.Forms.Label();
            this.new_item_name_textbox = new System.Windows.Forms.TextBox();
            this.new_item_cost_textbox = new System.Windows.Forms.TextBox();
            this.new_item_amount_textbox = new System.Windows.Forms.TextBox();
            this.new_item_submit_button = new System.Windows.Forms.Button();
            this.new_item_cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_item_name_label
            // 
            this.new_item_name_label.AutoSize = true;
            this.new_item_name_label.Location = new System.Drawing.Point(30, 43);
            this.new_item_name_label.Name = "new_item_name_label";
            this.new_item_name_label.Size = new System.Drawing.Size(83, 13);
            this.new_item_name_label.TabIndex = 0;
            this.new_item_name_label.Text = "Наименование";
            // 
            // new_item_amount_label
            // 
            this.new_item_amount_label.AutoSize = true;
            this.new_item_amount_label.Location = new System.Drawing.Point(30, 131);
            this.new_item_amount_label.Name = "new_item_amount_label";
            this.new_item_amount_label.Size = new System.Drawing.Size(66, 13);
            this.new_item_amount_label.TabIndex = 2;
            this.new_item_amount_label.Text = "Количество";
            // 
            // new_item_cost_label
            // 
            this.new_item_cost_label.AutoSize = true;
            this.new_item_cost_label.Location = new System.Drawing.Point(30, 84);
            this.new_item_cost_label.Name = "new_item_cost_label";
            this.new_item_cost_label.Size = new System.Drawing.Size(33, 13);
            this.new_item_cost_label.TabIndex = 3;
            this.new_item_cost_label.Text = "Цена";
            // 
            // new_item_name_textbox
            // 
            this.new_item_name_textbox.Location = new System.Drawing.Point(142, 40);
            this.new_item_name_textbox.Name = "new_item_name_textbox";
            this.new_item_name_textbox.Size = new System.Drawing.Size(142, 20);
            this.new_item_name_textbox.TabIndex = 4;
            // 
            // new_item_cost_textbox
            // 
            this.new_item_cost_textbox.Location = new System.Drawing.Point(142, 81);
            this.new_item_cost_textbox.Name = "new_item_cost_textbox";
            this.new_item_cost_textbox.Size = new System.Drawing.Size(74, 20);
            this.new_item_cost_textbox.TabIndex = 5;
            // 
            // new_item_amount_textbox
            // 
            this.new_item_amount_textbox.Location = new System.Drawing.Point(142, 124);
            this.new_item_amount_textbox.Name = "new_item_amount_textbox";
            this.new_item_amount_textbox.Size = new System.Drawing.Size(43, 20);
            this.new_item_amount_textbox.TabIndex = 6;
            // 
            // new_item_submit_button
            // 
            this.new_item_submit_button.Location = new System.Drawing.Point(33, 171);
            this.new_item_submit_button.Name = "new_item_submit_button";
            this.new_item_submit_button.Size = new System.Drawing.Size(120, 39);
            this.new_item_submit_button.TabIndex = 7;
            this.new_item_submit_button.Text = "Добавить товар";
            this.new_item_submit_button.UseVisualStyleBackColor = true;
            this.new_item_submit_button.Click += new System.EventHandler(this.new_item_submit_button_Click);
            // 
            // new_item_cancel_button
            // 
            this.new_item_cancel_button.Location = new System.Drawing.Point(218, 187);
            this.new_item_cancel_button.Name = "new_item_cancel_button";
            this.new_item_cancel_button.Size = new System.Drawing.Size(75, 23);
            this.new_item_cancel_button.TabIndex = 8;
            this.new_item_cancel_button.Text = "Отмена";
            this.new_item_cancel_button.UseVisualStyleBackColor = true;
            this.new_item_cancel_button.Click += new System.EventHandler(this.new_item_cancel_button_Click);
            // 
            // NEW_Item
            // 
            this.ClientSize = new System.Drawing.Size(305, 222);
            this.Controls.Add(this.new_item_cancel_button);
            this.Controls.Add(this.new_item_submit_button);
            this.Controls.Add(this.new_item_amount_textbox);
            this.Controls.Add(this.new_item_cost_textbox);
            this.Controls.Add(this.new_item_name_textbox);
            this.Controls.Add(this.new_item_cost_label);
            this.Controls.Add(this.new_item_amount_label);
            this.Controls.Add(this.new_item_name_label);
            this.Name = "NEW_Item";
            this.Text = "New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void new_item_cancel_button_Click(object sender, EventArgs e)
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
