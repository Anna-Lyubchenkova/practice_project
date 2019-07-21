namespace shop
{
    partial class NEW_Staff
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
            this.name_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.position_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.position_textbox = new System.Windows.Forms.TextBox();
            this.add_staff_button = new System.Windows.Forms.Button();
            this.add_staff_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(33, 66);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(39, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_label.Location = new System.Drawing.Point(33, 114);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(56, 13);
            this.surname_label.TabIndex = 1;
            this.surname_label.Text = "Surname";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_label.Location = new System.Drawing.Point(33, 156);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(29, 13);
            this.age_label.TabIndex = 2;
            this.age_label.Text = "Age";
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_label.Location = new System.Drawing.Point(33, 199);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(87, 13);
            this.position_label.TabIndex = 3;
            this.position_label.Text = "Position (num)";
            this.position_label.Visible = false;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(155, 63);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(104, 20);
            this.name_textbox.TabIndex = 4;
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(155, 111);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(104, 20);
            this.surname_textbox.TabIndex = 5;
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(155, 153);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(104, 20);
            this.age_textbox.TabIndex = 6;
            // 
            // position_textbox
            // 
            this.position_textbox.Location = new System.Drawing.Point(155, 196);
            this.position_textbox.Name = "position_textbox";
            this.position_textbox.Size = new System.Drawing.Size(104, 20);
            this.position_textbox.TabIndex = 7;
            this.position_textbox.Visible = false;
            // 
            // add_staff_button
            // 
            this.add_staff_button.Location = new System.Drawing.Point(98, 236);
            this.add_staff_button.Name = "add_staff_button";
            this.add_staff_button.Size = new System.Drawing.Size(103, 21);
            this.add_staff_button.TabIndex = 8;
            this.add_staff_button.Text = "ADD STAFF";
            this.add_staff_button.UseVisualStyleBackColor = true;
            this.add_staff_button.Click += new System.EventHandler(this.add_staff_button_Click);
            // 
            // add_staff_label
            // 
            this.add_staff_label.AutoSize = true;
            this.add_staff_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_staff_label.Location = new System.Drawing.Point(95, 28);
            this.add_staff_label.Name = "add_staff_label";
            this.add_staff_label.Size = new System.Drawing.Size(112, 13);
            this.add_staff_label.TabIndex = 9;
            this.add_staff_label.Text = "put some info here";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(227, 234);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(62, 24);
            this.cancel_button.TabIndex = 21;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // NEW_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 265);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_staff_label);
            this.Controls.Add(this.add_staff_button);
            this.Controls.Add(this.position_textbox);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.name_label);
            this.Name = "NEW_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW_Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.TextBox position_textbox;
        private System.Windows.Forms.Button add_staff_button;
        private System.Windows.Forms.Label add_staff_label;
        private System.Windows.Forms.Button cancel_button;
    }
}