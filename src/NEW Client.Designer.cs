namespace shop
{
    partial class NEW_Client
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
            this.add_client_label = new System.Windows.Forms.Label();
            this.add_client_button = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_client_label
            // 
            this.add_client_label.AutoSize = true;
            this.add_client_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_client_label.Location = new System.Drawing.Point(97, 22);
            this.add_client_label.Name = "add_client_label";
            this.add_client_label.Size = new System.Drawing.Size(112, 13);
            this.add_client_label.TabIndex = 19;
            this.add_client_label.Text = "put some info here";
            // 
            // add_client_button
            // 
            this.add_client_button.Location = new System.Drawing.Point(100, 230);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(103, 21);
            this.add_client_button.TabIndex = 18;
            this.add_client_button.Text = "ADD CLIENT";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_client_button_Click_1);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(114, 190);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(147, 20);
            this.email_textbox.TabIndex = 17;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(157, 147);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(104, 20);
            this.phone_textbox.TabIndex = 16;
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(157, 105);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(104, 20);
            this.surname_textbox.TabIndex = 15;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(157, 57);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(104, 20);
            this.name_textbox.TabIndex = 14;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_label.Location = new System.Drawing.Point(35, 193);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 13);
            this.email_label.TabIndex = 13;
            this.email_label.Text = "E-mail";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_label.Location = new System.Drawing.Point(35, 150);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(43, 13);
            this.phone_label.TabIndex = 12;
            this.phone_label.Text = "Phone";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_label.Location = new System.Drawing.Point(35, 108);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(56, 13);
            this.surname_label.TabIndex = 11;
            this.surname_label.Text = "Surname";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(35, 60);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(39, 13);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "Name";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(230, 244);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(62, 24);
            this.cancel_button.TabIndex = 20;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // NEW_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 273);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_client_label);
            this.Controls.Add(this.add_client_button);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.name_label);
            this.Name = "NEW_Client";
            this.Text = "NEW_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_client_label;
        private System.Windows.Forms.Button add_client_button;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button cancel_button;
    }
}