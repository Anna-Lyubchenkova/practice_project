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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.fix_reserve_button = new System.Windows.Forms.Button();
            this.close_item_info_button = new System.Windows.Forms.Button();
            this.item_id_info = new System.Windows.Forms.DataGridView();
            this.check_item_button = new System.Windows.Forms.Button();
            this.item_id_textbox = new System.Windows.Forms.TextBox();
            this.item_id_label = new System.Windows.Forms.Label();
            this.Orders = new System.Windows.Forms.TabPage();
            this.Tabs_Orders = new System.Windows.Forms.TabControl();
            this.general_orders = new System.Windows.Forms.TabPage();
            this.sort_orders_label = new System.Windows.Forms.Label();
            this.sort_orders_box = new System.Windows.Forms.ComboBox();
            this.orders_button = new System.Windows.Forms.Button();
            this.orders_box = new System.Windows.Forms.ComboBox();
            this.orders_list = new System.Windows.Forms.DataGridView();
            this.order_info_tab = new System.Windows.Forms.TabPage();
            this.close_order_button = new System.Windows.Forms.Button();
            this.order_cancelled_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upd_order_button = new System.Windows.Forms.Button();
            this.order_sort_box = new System.Windows.Forms.ComboBox();
            this.order_sort_label = new System.Windows.Forms.Label();
            this.order_id_button = new System.Windows.Forms.Button();
            this.order_id_textbox = new System.Windows.Forms.TextBox();
            this.order_id_label = new System.Windows.Forms.Label();
            this.order_info_list = new System.Windows.Forms.DataGridView();
            this.create_order = new System.Windows.Forms.TabPage();
            this.basket_label = new System.Windows.Forms.Label();
            this.make_order_button = new System.Windows.Forms.Button();
            this.item_add_button = new System.Windows.Forms.Button();
            this.itemnum_textbox = new System.Windows.Forms.TextBox();
            this.itemid_textbox = new System.Windows.Forms.TextBox();
            this.itemnum_label = new System.Windows.Forms.Label();
            this.itemid_label = new System.Windows.Forms.Label();
            this.exit_neworder_button = new System.Windows.Forms.Button();
            this.clean_basket_button = new System.Windows.Forms.Button();
            this.basket_list = new System.Windows.Forms.DataGridView();
            this.put_clientid_button = new System.Windows.Forms.Button();
            this.put_clientid_textbox = new System.Windows.Forms.TextBox();
            this.put_clientid_label = new System.Windows.Forms.Label();
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
            this.Orders.SuspendLayout();
            this.Tabs_Orders.SuspendLayout();
            this.general_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_list)).BeginInit();
            this.order_info_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_info_list)).BeginInit();
            this.create_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basket_list)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs_head
            // 
            this.Tabs_head.Controls.Add(this.Products);
            this.Tabs_head.Controls.Add(this.Orders);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.products_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.products_view.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.item_info.Controls.Add(this.fix_reserve_button);
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
            // fix_reserve_button
            // 
            this.fix_reserve_button.Enabled = false;
            this.fix_reserve_button.Location = new System.Drawing.Point(445, 65);
            this.fix_reserve_button.Name = "fix_reserve_button";
            this.fix_reserve_button.Size = new System.Drawing.Size(115, 20);
            this.fix_reserve_button.TabIndex = 4;
            this.fix_reserve_button.Text = "make reservation";
            this.fix_reserve_button.UseVisualStyleBackColor = true;
            this.fix_reserve_button.Click += new System.EventHandler(this.fix_reserve_button_Click);
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
            // Orders
            // 
            this.Orders.Controls.Add(this.Tabs_Orders);
            this.Orders.Location = new System.Drawing.Point(4, 22);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(766, 310);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "Заказы";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // Tabs_Orders
            // 
            this.Tabs_Orders.Controls.Add(this.general_orders);
            this.Tabs_Orders.Controls.Add(this.order_info_tab);
            this.Tabs_Orders.Controls.Add(this.create_order);
            this.Tabs_Orders.Location = new System.Drawing.Point(1, 1);
            this.Tabs_Orders.Name = "Tabs_Orders";
            this.Tabs_Orders.SelectedIndex = 0;
            this.Tabs_Orders.Size = new System.Drawing.Size(762, 309);
            this.Tabs_Orders.TabIndex = 0;
            // 
            // general_orders
            // 
            this.general_orders.Controls.Add(this.sort_orders_label);
            this.general_orders.Controls.Add(this.sort_orders_box);
            this.general_orders.Controls.Add(this.orders_button);
            this.general_orders.Controls.Add(this.orders_box);
            this.general_orders.Controls.Add(this.orders_list);
            this.general_orders.Location = new System.Drawing.Point(4, 22);
            this.general_orders.Name = "general_orders";
            this.general_orders.Padding = new System.Windows.Forms.Padding(3);
            this.general_orders.Size = new System.Drawing.Size(754, 283);
            this.general_orders.TabIndex = 0;
            this.general_orders.Text = "Заказы";
            this.general_orders.UseVisualStyleBackColor = true;
            // 
            // sort_orders_label
            // 
            this.sort_orders_label.AutoSize = true;
            this.sort_orders_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_orders_label.Location = new System.Drawing.Point(634, 96);
            this.sort_orders_label.Name = "sort_orders_label";
            this.sort_orders_label.Size = new System.Drawing.Size(47, 13);
            this.sort_orders_label.TabIndex = 4;
            this.sort_orders_label.Text = "Sort by";
            // 
            // sort_orders_box
            // 
            this.sort_orders_box.FormattingEnabled = true;
            this.sort_orders_box.Items.AddRange(new object[] {
            "OrderID",
            "[Order Date]",
            "Status"});
            this.sort_orders_box.Location = new System.Drawing.Point(637, 112);
            this.sort_orders_box.Name = "sort_orders_box";
            this.sort_orders_box.Size = new System.Drawing.Size(96, 21);
            this.sort_orders_box.TabIndex = 3;
            // 
            // orders_button
            // 
            this.orders_button.Location = new System.Drawing.Point(637, 199);
            this.orders_button.Name = "orders_button";
            this.orders_button.Size = new System.Drawing.Size(96, 23);
            this.orders_button.TabIndex = 2;
            this.orders_button.Text = "Refresh";
            this.orders_button.UseVisualStyleBackColor = true;
            this.orders_button.Click += new System.EventHandler(this.orders_button_Click);
            // 
            // orders_box
            // 
            this.orders_box.FormattingEnabled = true;
            this.orders_box.Items.AddRange(new object[] {
            "all",
            "new",
            "wait",
            "ready",
            "sold"});
            this.orders_box.Location = new System.Drawing.Point(637, 156);
            this.orders_box.Name = "orders_box";
            this.orders_box.Size = new System.Drawing.Size(96, 21);
            this.orders_box.TabIndex = 1;
            // 
            // orders_list
            // 
            this.orders_list.AllowUserToDeleteRows = false;
            this.orders_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orders_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_list.Location = new System.Drawing.Point(50, 28);
            this.orders_list.Name = "orders_list";
            this.orders_list.ReadOnly = true;
            this.orders_list.Size = new System.Drawing.Size(546, 194);
            this.orders_list.TabIndex = 0;
            // 
            // order_info_tab
            // 
            this.order_info_tab.Controls.Add(this.close_order_button);
            this.order_info_tab.Controls.Add(this.order_cancelled_button);
            this.order_info_tab.Controls.Add(this.label1);
            this.order_info_tab.Controls.Add(this.upd_order_button);
            this.order_info_tab.Controls.Add(this.order_sort_box);
            this.order_info_tab.Controls.Add(this.order_sort_label);
            this.order_info_tab.Controls.Add(this.order_id_button);
            this.order_info_tab.Controls.Add(this.order_id_textbox);
            this.order_info_tab.Controls.Add(this.order_id_label);
            this.order_info_tab.Controls.Add(this.order_info_list);
            this.order_info_tab.Location = new System.Drawing.Point(4, 22);
            this.order_info_tab.Name = "order_info_tab";
            this.order_info_tab.Padding = new System.Windows.Forms.Padding(3);
            this.order_info_tab.Size = new System.Drawing.Size(754, 283);
            this.order_info_tab.TabIndex = 1;
            this.order_info_tab.Text = "Инфо о заказе";
            this.order_info_tab.UseVisualStyleBackColor = true;
            // 
            // close_order_button
            // 
            this.close_order_button.Location = new System.Drawing.Point(579, 258);
            this.close_order_button.Name = "close_order_button";
            this.close_order_button.Size = new System.Drawing.Size(119, 22);
            this.close_order_button.TabIndex = 10;
            this.close_order_button.Text = "Close Order";
            this.close_order_button.UseVisualStyleBackColor = true;
            this.close_order_button.Click += new System.EventHandler(this.close_order_button_Click);
            // 
            // order_cancelled_button
            // 
            this.order_cancelled_button.Location = new System.Drawing.Point(152, 237);
            this.order_cancelled_button.Name = "order_cancelled_button";
            this.order_cancelled_button.Size = new System.Drawing.Size(63, 19);
            this.order_cancelled_button.TabIndex = 9;
            this.order_cancelled_button.Text = "DO!";
            this.order_cancelled_button.UseVisualStyleBackColor = true;
            this.order_cancelled_button.Click += new System.EventHandler(this.order_cancelled_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Отменить заказ";
            // 
            // upd_order_button
            // 
            this.upd_order_button.Location = new System.Drawing.Point(81, 40);
            this.upd_order_button.Name = "upd_order_button";
            this.upd_order_button.Size = new System.Drawing.Size(112, 29);
            this.upd_order_button.TabIndex = 6;
            this.upd_order_button.Text = "update state";
            this.upd_order_button.UseVisualStyleBackColor = true;
            this.upd_order_button.Click += new System.EventHandler(this.upd_order_button_Click);
            // 
            // order_sort_box
            // 
            this.order_sort_box.FormattingEnabled = true;
            this.order_sort_box.Items.AddRange(new object[] {
            "Item_Name",
            "Summa",
            "Status"});
            this.order_sort_box.Location = new System.Drawing.Point(152, 83);
            this.order_sort_box.Name = "order_sort_box";
            this.order_sort_box.Size = new System.Drawing.Size(99, 21);
            this.order_sort_box.TabIndex = 5;
            // 
            // order_sort_label
            // 
            this.order_sort_label.AutoSize = true;
            this.order_sort_label.Location = new System.Drawing.Point(32, 88);
            this.order_sort_label.Name = "order_sort_label";
            this.order_sort_label.Size = new System.Drawing.Size(99, 13);
            this.order_sort_label.TabIndex = 4;
            this.order_sort_label.Text = "Отсортировать по";
            // 
            // order_id_button
            // 
            this.order_id_button.Location = new System.Drawing.Point(80, 177);
            this.order_id_button.Name = "order_id_button";
            this.order_id_button.Size = new System.Drawing.Size(113, 26);
            this.order_id_button.TabIndex = 3;
            this.order_id_button.Text = "CHECK";
            this.order_id_button.UseVisualStyleBackColor = true;
            this.order_id_button.Click += new System.EventHandler(this.order_id_button_Click);
            // 
            // order_id_textbox
            // 
            this.order_id_textbox.Location = new System.Drawing.Point(152, 136);
            this.order_id_textbox.Name = "order_id_textbox";
            this.order_id_textbox.Size = new System.Drawing.Size(100, 20);
            this.order_id_textbox.TabIndex = 2;
            // 
            // order_id_label
            // 
            this.order_id_label.AutoSize = true;
            this.order_id_label.Location = new System.Drawing.Point(32, 139);
            this.order_id_label.Name = "order_id_label";
            this.order_id_label.Size = new System.Drawing.Size(102, 13);
            this.order_id_label.TabIndex = 1;
            this.order_id_label.Text = "Введите ID заказа";
            // 
            // order_info_list
            // 
            this.order_info_list.AllowUserToDeleteRows = false;
            this.order_info_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.order_info_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.order_info_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_info_list.Location = new System.Drawing.Point(281, 40);
            this.order_info_list.Name = "order_info_list";
            this.order_info_list.ReadOnly = true;
            this.order_info_list.Size = new System.Drawing.Size(417, 213);
            this.order_info_list.TabIndex = 0;
            // 
            // create_order
            // 
            this.create_order.Controls.Add(this.basket_label);
            this.create_order.Controls.Add(this.make_order_button);
            this.create_order.Controls.Add(this.item_add_button);
            this.create_order.Controls.Add(this.itemnum_textbox);
            this.create_order.Controls.Add(this.itemid_textbox);
            this.create_order.Controls.Add(this.itemnum_label);
            this.create_order.Controls.Add(this.itemid_label);
            this.create_order.Controls.Add(this.exit_neworder_button);
            this.create_order.Controls.Add(this.clean_basket_button);
            this.create_order.Controls.Add(this.basket_list);
            this.create_order.Controls.Add(this.put_clientid_button);
            this.create_order.Controls.Add(this.put_clientid_textbox);
            this.create_order.Controls.Add(this.put_clientid_label);
            this.create_order.Location = new System.Drawing.Point(4, 22);
            this.create_order.Name = "create_order";
            this.create_order.Size = new System.Drawing.Size(754, 283);
            this.create_order.TabIndex = 2;
            this.create_order.Text = "Новый заказ";
            this.create_order.UseVisualStyleBackColor = true;
            // 
            // basket_label
            // 
            this.basket_label.AutoSize = true;
            this.basket_label.Location = new System.Drawing.Point(434, 14);
            this.basket_label.Name = "basket_label";
            this.basket_label.Size = new System.Drawing.Size(50, 13);
            this.basket_label.TabIndex = 12;
            this.basket_label.Text = "Корзина";
            // 
            // make_order_button
            // 
            this.make_order_button.BackColor = System.Drawing.Color.Orange;
            this.make_order_button.Location = new System.Drawing.Point(342, 72);
            this.make_order_button.Name = "make_order_button";
            this.make_order_button.Size = new System.Drawing.Size(75, 78);
            this.make_order_button.TabIndex = 11;
            this.make_order_button.Text = "Завершить заказ";
            this.make_order_button.UseVisualStyleBackColor = false;
            this.make_order_button.Click += new System.EventHandler(this.make_order_button_Click);
            // 
            // item_add_button
            // 
            this.item_add_button.Location = new System.Drawing.Point(116, 233);
            this.item_add_button.Name = "item_add_button";
            this.item_add_button.Size = new System.Drawing.Size(95, 38);
            this.item_add_button.TabIndex = 10;
            this.item_add_button.Text = "Добавить в корзину";
            this.item_add_button.UseVisualStyleBackColor = true;
            this.item_add_button.Click += new System.EventHandler(this.item_add_button_Click);
            // 
            // itemnum_textbox
            // 
            this.itemnum_textbox.Location = new System.Drawing.Point(168, 191);
            this.itemnum_textbox.Name = "itemnum_textbox";
            this.itemnum_textbox.Size = new System.Drawing.Size(92, 20);
            this.itemnum_textbox.TabIndex = 9;
            // 
            // itemid_textbox
            // 
            this.itemid_textbox.Location = new System.Drawing.Point(168, 152);
            this.itemid_textbox.Name = "itemid_textbox";
            this.itemid_textbox.Size = new System.Drawing.Size(92, 20);
            this.itemid_textbox.TabIndex = 8;
            // 
            // itemnum_label
            // 
            this.itemnum_label.AutoSize = true;
            this.itemnum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemnum_label.Location = new System.Drawing.Point(67, 194);
            this.itemnum_label.Name = "itemnum_label";
            this.itemnum_label.Size = new System.Drawing.Size(76, 13);
            this.itemnum_label.TabIndex = 7;
            this.itemnum_label.Text = "Количество";
            // 
            // itemid_label
            // 
            this.itemid_label.AutoSize = true;
            this.itemid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemid_label.Location = new System.Drawing.Point(78, 155);
            this.itemid_label.Name = "itemid_label";
            this.itemid_label.Size = new System.Drawing.Size(65, 13);
            this.itemid_label.TabIndex = 6;
            this.itemid_label.Text = "ID товара";
            // 
            // exit_neworder_button
            // 
            this.exit_neworder_button.Location = new System.Drawing.Point(575, 247);
            this.exit_neworder_button.Name = "exit_neworder_button";
            this.exit_neworder_button.Size = new System.Drawing.Size(111, 24);
            this.exit_neworder_button.TabIndex = 5;
            this.exit_neworder_button.Text = "Отменить заказ";
            this.exit_neworder_button.UseVisualStyleBackColor = true;
            this.exit_neworder_button.Click += new System.EventHandler(this.exit_neworder_button_Click);
            // 
            // clean_basket_button
            // 
            this.clean_basket_button.Location = new System.Drawing.Point(433, 247);
            this.clean_basket_button.Name = "clean_basket_button";
            this.clean_basket_button.Size = new System.Drawing.Size(113, 25);
            this.clean_basket_button.TabIndex = 4;
            this.clean_basket_button.Text = "Очистить корзину";
            this.clean_basket_button.UseVisualStyleBackColor = true;
            this.clean_basket_button.Click += new System.EventHandler(this.clean_basket_button_Click);
            // 
            // basket_list
            // 
            this.basket_list.AllowUserToDeleteRows = false;
            this.basket_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.basket_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basket_list.Location = new System.Drawing.Point(432, 33);
            this.basket_list.Name = "basket_list";
            this.basket_list.ReadOnly = true;
            this.basket_list.Size = new System.Drawing.Size(256, 202);
            this.basket_list.TabIndex = 3;
            // 
            // put_clientid_button
            // 
            this.put_clientid_button.Location = new System.Drawing.Point(162, 60);
            this.put_clientid_button.Name = "put_clientid_button";
            this.put_clientid_button.Size = new System.Drawing.Size(50, 21);
            this.put_clientid_button.TabIndex = 2;
            this.put_clientid_button.Text = "DO";
            this.put_clientid_button.UseVisualStyleBackColor = true;
            this.put_clientid_button.Click += new System.EventHandler(this.put_clientid_button_Click);
            // 
            // put_clientid_textbox
            // 
            this.put_clientid_textbox.Location = new System.Drawing.Point(93, 61);
            this.put_clientid_textbox.Name = "put_clientid_textbox";
            this.put_clientid_textbox.Size = new System.Drawing.Size(50, 20);
            this.put_clientid_textbox.TabIndex = 1;
            // 
            // put_clientid_label
            // 
            this.put_clientid_label.AutoSize = true;
            this.put_clientid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.put_clientid_label.Location = new System.Drawing.Point(90, 33);
            this.put_clientid_label.Name = "put_clientid_label";
            this.put_clientid_label.Size = new System.Drawing.Size(122, 13);
            this.put_clientid_label.TabIndex = 0;
            this.put_clientid_label.Text = "Введите id клиента";
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
            this.Orders.ResumeLayout(false);
            this.Tabs_Orders.ResumeLayout(false);
            this.general_orders.ResumeLayout(false);
            this.general_orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_list)).EndInit();
            this.order_info_tab.ResumeLayout(false);
            this.order_info_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_info_list)).EndInit();
            this.create_order.ResumeLayout(false);
            this.create_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basket_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs_head;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabControl Tabs_products;
        private System.Windows.Forms.TabPage all_products;
        private System.Windows.Forms.DataGridView products_view;
        private System.Windows.Forms.TabPage options;
        private System.Windows.Forms.TabPage Orders;
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
        private System.Windows.Forms.TabControl Tabs_Orders;
        private System.Windows.Forms.TabPage general_orders;
        private System.Windows.Forms.TabPage order_info_tab;
        private System.Windows.Forms.TabPage create_order;
        private System.Windows.Forms.ComboBox orders_box;
        private System.Windows.Forms.DataGridView orders_list;
        private System.Windows.Forms.Button orders_button;
        private System.Windows.Forms.ComboBox sort_orders_box;
        private System.Windows.Forms.Label sort_orders_label;
        private System.Windows.Forms.TextBox order_id_textbox;
        private System.Windows.Forms.Label order_id_label;
        private System.Windows.Forms.DataGridView order_info_list;
        private System.Windows.Forms.Button order_id_button;
        private System.Windows.Forms.Label order_sort_label;
        private System.Windows.Forms.ComboBox order_sort_box;
        private System.Windows.Forms.Button upd_order_button;
        private System.Windows.Forms.Button order_cancelled_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label basket_label;
        private System.Windows.Forms.Button make_order_button;
        private System.Windows.Forms.Button item_add_button;
        private System.Windows.Forms.TextBox itemnum_textbox;
        private System.Windows.Forms.TextBox itemid_textbox;
        private System.Windows.Forms.Label itemnum_label;
        private System.Windows.Forms.Label itemid_label;
        private System.Windows.Forms.Button exit_neworder_button;
        private System.Windows.Forms.Button clean_basket_button;
        private System.Windows.Forms.DataGridView basket_list;
        private System.Windows.Forms.Button put_clientid_button;
        private System.Windows.Forms.TextBox put_clientid_textbox;
        private System.Windows.Forms.Label put_clientid_label;
        private System.Windows.Forms.Button close_order_button;
        private System.Windows.Forms.Button close_item_info_button;
        private System.Windows.Forms.Label update_item_amount_label;
        private System.Windows.Forms.Button upd_item_amount_button;
        private System.Windows.Forms.TextBox upd_item_amount_textbox;
        private System.Windows.Forms.TextBox upd_item_amount_item_ID_textbox;
        private System.Windows.Forms.Label upd_item_amount_plus_amount_label;
        private System.Windows.Forms.Label upd_item_amount_item_ID_label;
        private System.Windows.Forms.Button fix_reserve_button;
        private System.Windows.Forms.Button new_item_button;
    }
}