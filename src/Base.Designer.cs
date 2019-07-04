namespace shop
{
    partial class Base
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabs_head = new System.Windows.Forms.TabControl();
            this.Products = new System.Windows.Forms.TabPage();
            this.Tabs_products = new System.Windows.Forms.TabControl();
            this.all_products = new System.Windows.Forms.TabPage();
            this.new_item_button = new System.Windows.Forms.Button();
            this.upd_item_amount_button = new System.Windows.Forms.Button();
            this.upd_item_amount_textbox = new System.Windows.Forms.TextBox();
            this.upd_item_amount_item_ID_textbox = new System.Windows.Forms.TextBox();
            this.upd_item_amount_plus_amount_label = new System.Windows.Forms.Label();
            this.upd_item_amount_item_ID_label = new System.Windows.Forms.Label();
            this.update_item_amount_label = new System.Windows.Forms.Label();
            this.products_view = new System.Windows.Forms.DataGridView();
            this.options = new System.Windows.Forms.TabPage();
            this.to_range_label = new System.Windows.Forms.Label();
            this.from_range_label = new System.Windows.Forms.Label();
            this.to_range_textbox = new System.Windows.Forms.TextBox();
            this.from_range_textbox = new System.Windows.Forms.TextBox();
            this.product_option_button = new System.Windows.Forms.Button();
            this.product_option_list = new System.Windows.Forms.DataGridView();
            this.item_info = new System.Windows.Forms.TabPage();
            this.close_item_info_button = new System.Windows.Forms.Button();
            this.item_id_info = new System.Windows.Forms.DataGridView();
            this.check_item_button = new System.Windows.Forms.Button();
            this.item_id_textbox = new System.Windows.Forms.TextBox();
            this.item_id_label = new System.Windows.Forms.Label();
            this.Disconnect_button = new System.Windows.Forms.Button();
            this.Tabs_head.SuspendLayout();
            this.Products.SuspendLayout();
            this.Tabs_products.SuspendLayout();
            this.all_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_view)).BeginInit();
            this.options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_option_list)).BeginInit();
            this.item_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_id_info)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs_head
            // 
            this.Tabs_head.Controls.Add(this.Products);
            this.Tabs_head.Location = new System.Drawing.Point(13, 13);
            this.Tabs_head.Name = "Tabs_head";
            this.Tabs_head.SelectedIndex = 0;
            this.Tabs_head.Size = new System.Drawing.Size(774, 336);
            this.Tabs_head.TabIndex = 0;
            // 
            // Products
            // 
            this.Products.Controls.Add(this.Tabs_products);
            this.Products.Location = new System.Drawing.Point(4, 22);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(766, 310);
            this.Products.TabIndex = 0;
            this.Products.Text = "Товары";
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Tabs_products
            // 
            this.Tabs_products.Controls.Add(this.all_products);
            this.Tabs_products.Controls.Add(this.options);
            this.Tabs_products.Controls.Add(this.item_info);
            this.Tabs_products.Location = new System.Drawing.Point(0, 0);
            this.Tabs_products.Name = "Tabs_products";
            this.Tabs_products.SelectedIndex = 0;
            this.Tabs_products.Size = new System.Drawing.Size(763, 310);
            this.Tabs_products.TabIndex = 0;
            // 
            // all_products
            // 
            this.all_products.BackColor = System.Drawing.Color.White;
            this.all_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.all_products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.all_products.Controls.Add(this.new_item_button);
            this.all_products.Controls.Add(this.upd_item_amount_button);
            this.all_products.Controls.Add(this.upd_item_amount_textbox);
            this.all_products.Controls.Add(this.upd_item_amount_item_ID_textbox);
            this.all_products.Controls.Add(this.upd_item_amount_plus_amount_label);
            this.all_products.Controls.Add(this.upd_item_amount_item_ID_label);
            this.all_products.Controls.Add(this.update_item_amount_label);
            this.all_products.Controls.Add(this.products_view);
            this.all_products.Location = new System.Drawing.Point(4, 22);
            this.all_products.Name = "all_products";
            this.all_products.Padding = new System.Windows.Forms.Padding(3);
            this.all_products.Size = new System.Drawing.Size(755, 284);
            this.all_products.TabIndex = 0;
            this.all_products.Text = "Список товаров";
            // 
            // new_item_button
            // 
            this.new_item_button.Location = new System.Drawing.Point(481, 229);
            this.new_item_button.Name = "new_item_button";
            this.new_item_button.Size = new System.Drawing.Size(229, 31);
            this.new_item_button.TabIndex = 5;
            this.new_item_button.Text = "Добавить новый товар";
            this.new_item_button.UseVisualStyleBackColor = true;
            this.new_item_button.Click += new System.EventHandler(this.new_item_button_Click);
            // 
            // upd_item_amount_button
            // 
            this.upd_item_amount_button.Location = new System.Drawing.Point(529, 135);
            this.upd_item_amount_button.Name = "upd_item_amount_button";
            this.upd_item_amount_button.Size = new System.Drawing.Size(117, 20);
            this.upd_item_amount_button.TabIndex = 4;
            this.upd_item_amount_button.Text = "Добавить";
            this.upd_item_amount_button.UseVisualStyleBackColor = true;
            this.upd_item_amount_button.Click += new System.EventHandler(this.upd_item_amount_button_Click);
            // 
            // upd_item_amount_textbox
            // 
            this.upd_item_amount_textbox.Location = new System.Drawing.Point(584, 97);
            this.upd_item_amount_textbox.Name = "upd_item_amount_textbox";
            this.upd_item_amount_textbox.Size = new System.Drawing.Size(100, 20);
            this.upd_item_amount_textbox.TabIndex = 3;
            // 
            // upd_item_amount_item_ID_textbox
            // 
            this.upd_item_amount_item_ID_textbox.Location = new System.Drawing.Point(584, 56);
            this.upd_item_amount_item_ID_textbox.Name = "upd_item_amount_item_ID_textbox";
            this.upd_item_amount_item_ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.upd_item_amount_item_ID_textbox.TabIndex = 3;
            // 
            // upd_item_amount_plus_amount_label
            // 
            this.upd_item_amount_plus_amount_label.AutoSize = true;
            this.upd_item_amount_plus_amount_label.Location = new System.Drawing.Point(478, 100);
            this.upd_item_amount_plus_amount_label.Name = "upd_item_amount_plus_amount_label";
            this.upd_item_amount_plus_amount_label.Size = new System.Drawing.Size(66, 13);
            this.upd_item_amount_plus_amount_label.TabIndex = 2;
            this.upd_item_amount_plus_amount_label.Text = "Количество";
            // 
            // upd_item_amount_item_ID_label
            // 
            this.upd_item_amount_item_ID_label.AutoSize = true;
            this.upd_item_amount_item_ID_label.Location = new System.Drawing.Point(488, 59);
            this.upd_item_amount_item_ID_label.Name = "upd_item_amount_item_ID_label";
            this.upd_item_amount_item_ID_label.Size = new System.Drawing.Size(56, 13);
            this.upd_item_amount_item_ID_label.TabIndex = 2;
            this.upd_item_amount_item_ID_label.Text = "ID товара";
            // 
            // update_item_amount_label
            // 
            this.update_item_amount_label.AutoSize = true;
            this.update_item_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_item_amount_label.Location = new System.Drawing.Point(450, 20);
            this.update_item_amount_label.Name = "update_item_amount_label";
            this.update_item_amount_label.Size = new System.Drawing.Size(300, 20);
            this.update_item_amount_label.TabIndex = 1;
            this.update_item_amount_label.Text = "Добавление единиц продукции";
            this.update_item_amount_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // products_view
            // 
            this.products_view.AllowUserToDeleteRows = false;
            this.products_view.AllowUserToOrderColumns = true;
            this.products_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.products_view.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.products_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.products_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.products_view.Location = new System.Drawing.Point(19, 20);
            this.products_view.Margin = new System.Windows.Forms.Padding(0);
            this.products_view.Name = "products_view";
            this.products_view.ReadOnly = true;
            this.products_view.Size = new System.Drawing.Size(417, 251);
            this.products_view.TabIndex = 0;
            // 
            // options
            // 
            this.options.Controls.Add(this.to_range_label);
            this.options.Controls.Add(this.from_range_label);
            this.options.Controls.Add(this.to_range_textbox);
            this.options.Controls.Add(this.from_range_textbox);
            this.options.Controls.Add(this.product_option_button);
            this.options.Controls.Add(this.product_option_list);
            this.options.Location = new System.Drawing.Point(4, 22);
            this.options.Name = "options";
            this.options.Padding = new System.Windows.Forms.Padding(3);
            this.options.Size = new System.Drawing.Size(755, 284);
            this.options.TabIndex = 1;
            this.options.Text = "Поиск в диапазоне";
            this.options.UseVisualStyleBackColor = true;
            // 
            // to_range_label
            // 
            this.to_range_label.AutoSize = true;
            this.to_range_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_range_label.Location = new System.Drawing.Point(58, 103);
            this.to_range_label.Name = "to_range_label";
            this.to_range_label.Size = new System.Drawing.Size(24, 13);
            this.to_range_label.TabIndex = 7;
            this.to_range_label.Text = "TO";
            // 
            // from_range_label
            // 
            this.from_range_label.AutoSize = true;
            this.from_range_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.from_range_label.Location = new System.Drawing.Point(42, 65);
            this.from_range_label.Name = "from_range_label";
            this.from_range_label.Size = new System.Drawing.Size(42, 13);
            this.from_range_label.TabIndex = 6;
            this.from_range_label.Text = "FROM";
            // 
            // to_range_textbox
            // 
            this.to_range_textbox.Location = new System.Drawing.Point(106, 100);
            this.to_range_textbox.Name = "to_range_textbox";
            this.to_range_textbox.Size = new System.Drawing.Size(117, 20);
            this.to_range_textbox.TabIndex = 5;
            // 
            // from_range_textbox
            // 
            this.from_range_textbox.Location = new System.Drawing.Point(106, 62);
            this.from_range_textbox.Name = "from_range_textbox";
            this.from_range_textbox.Size = new System.Drawing.Size(118, 20);
            this.from_range_textbox.TabIndex = 4;
            // 
            // product_option_button
            // 
            this.product_option_button.Location = new System.Drawing.Point(126, 138);
            this.product_option_button.Name = "product_option_button";
            this.product_option_button.Size = new System.Drawing.Size(75, 23);
            this.product_option_button.TabIndex = 3;
            this.product_option_button.Text = "Refresh";
            this.product_option_button.UseVisualStyleBackColor = true;
            this.product_option_button.Click += new System.EventHandler(this.product_option_button_Click);
            // 
            // product_option_list
            // 
            this.product_option_list.AllowUserToDeleteRows = false;
            this.product_option_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.product_option_list.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.product_option_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_option_list.Location = new System.Drawing.Point(298, 43);
            this.product_option_list.Name = "product_option_list";
            this.product_option_list.ReadOnly = true;
            this.product_option_list.Size = new System.Drawing.Size(319, 150);
            this.product_option_list.TabIndex = 2;
            // 
            // item_info
            // 
            this.item_info.Controls.Add(this.close_item_info_button);
            this.item_info.Controls.Add(this.item_id_info);
            this.item_info.Controls.Add(this.check_item_button);
            this.item_info.Controls.Add(this.item_id_textbox);
            this.item_info.Controls.Add(this.item_id_label);
            this.item_info.Location = new System.Drawing.Point(4, 22);
            this.item_info.Name = "item_info";
            this.item_info.Size = new System.Drawing.Size(755, 284);
            this.item_info.TabIndex = 2;
            this.item_info.Text = "Инфо о товаре";
            this.item_info.UseVisualStyleBackColor = true;
            // 
            // close_item_info_button
            // 
            this.close_item_info_button.Location = new System.Drawing.Point(473, 194);
            this.close_item_info_button.Name = "close_item_info_button";
            this.close_item_info_button.Size = new System.Drawing.Size(87, 20);
            this.close_item_info_button.TabIndex = 3;
            this.close_item_info_button.Text = "close";
            this.close_item_info_button.UseVisualStyleBackColor = true;
            this.close_item_info_button.Click += new System.EventHandler(this.close_item_info_button_Click);
            // 
            // item_id_info
            // 
            this.item_id_info.AllowUserToDeleteRows = false;
            this.item_id_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.item_id_info.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.item_id_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_id_info.Location = new System.Drawing.Point(71, 105);
            this.item_id_info.Name = "item_id_info";
            this.item_id_info.ReadOnly = true;
            this.item_id_info.Size = new System.Drawing.Size(489, 83);
            this.item_id_info.TabIndex = 2;
            // 
            // check_item_button
            // 
            this.check_item_button.Location = new System.Drawing.Point(308, 65);
            this.check_item_button.Name = "check_item_button";
            this.check_item_button.Size = new System.Drawing.Size(72, 20);
            this.check_item_button.TabIndex = 2;
            this.check_item_button.Text = "check";
            this.check_item_button.UseVisualStyleBackColor = true;
            this.check_item_button.Click += new System.EventHandler(this.check_item_button_Click);
            // 
            // item_id_textbox
            // 
            this.item_id_textbox.Location = new System.Drawing.Point(192, 65);
            this.item_id_textbox.Name = "item_id_textbox";
            this.item_id_textbox.Size = new System.Drawing.Size(70, 20);
            this.item_id_textbox.TabIndex = 1;
            // 
            // item_id_label
            // 
            this.item_id_label.AutoSize = true;
            this.item_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_id_label.Location = new System.Drawing.Point(68, 68);
            this.item_id_label.Name = "item_id_label";
            this.item_id_label.Size = new System.Drawing.Size(118, 13);
            this.item_id_label.TabIndex = 0;
            this.item_id_label.Text = "Введите ID товара";
            // 
            // Disconnect_button
            // 
            this.Disconnect_button.Location = new System.Drawing.Point(708, 351);
            this.Disconnect_button.Name = "Disconnect_button";
            this.Disconnect_button.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_button.TabIndex = 1;
            this.Disconnect_button.Text = "Disconnect";
            this.Disconnect_button.UseVisualStyleBackColor = true;
            this.Disconnect_button.Click += new System.EventHandler(this.Disconnect_button_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(789, 376);
            this.Controls.Add(this.Disconnect_button);
            this.Controls.Add(this.Tabs_head);
            this.DoubleBuffered = true;
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Anna\'s Cosmetics";
            this.Tabs_head.ResumeLayout(false);
            this.Products.ResumeLayout(false);
            this.Tabs_products.ResumeLayout(false);
            this.all_products.ResumeLayout(false);
            this.all_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_view)).EndInit();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_option_list)).EndInit();
            this.item_info.ResumeLayout(false);
            this.item_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_id_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs_head;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabControl Tabs_products;
        private System.Windows.Forms.TabPage all_products;
        private System.Windows.Forms.DataGridView products_view;
        private System.Windows.Forms.TabPage options;
        private System.Windows.Forms.Button Disconnect_button;
        private System.Windows.Forms.DataGridView product_option_list;
        private System.Windows.Forms.Button product_option_button;
        private System.Windows.Forms.TextBox from_range_textbox;
        private System.Windows.Forms.Label to_range_label;
        private System.Windows.Forms.Label from_range_label;
        private System.Windows.Forms.TextBox to_range_textbox;
        private System.Windows.Forms.TabPage item_info;
        private System.Windows.Forms.Label item_id_label;
        private System.Windows.Forms.DataGridView item_id_info;
        private System.Windows.Forms.Button check_item_button;
        private System.Windows.Forms.TextBox item_id_textbox;
        private System.Windows.Forms.Button close_item_info_button;
        private System.Windows.Forms.Label update_item_amount_label;
        private System.Windows.Forms.Button upd_item_amount_button;
        private System.Windows.Forms.TextBox upd_item_amount_textbox;
        private System.Windows.Forms.TextBox upd_item_amount_item_ID_textbox;
        private System.Windows.Forms.Label upd_item_amount_plus_amount_label;
        private System.Windows.Forms.Label upd_item_amount_item_ID_label;
        private System.Windows.Forms.Button new_item_button;
    }
}