namespace shop
{
    partial class Form1
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
            this.Login_button = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.sign_up_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(109, 171);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Log In";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(97, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(106, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Anna\'s Cosmetics";
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(100, 99);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(100, 20);
            this.Login_box.TabIndex = 2;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(100, 145);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(100, 20);
            this.password_box.TabIndex = 3;
            this.password_box.UseSystemPasswordChar = true;
            this.password_box.UseWaitCursor = true;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(38, 102);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(53, 13);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(38, 148);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(52, 13);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "password";
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(197, 226);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // sign_up_button
            // 
            this.sign_up_button.Location = new System.Drawing.Point(109, 200);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Size = new System.Drawing.Size(75, 23);
            this.sign_up_button.TabIndex = 7;
            this.sign_up_button.Text = "Sign Up";
            this.sign_up_button.UseVisualStyleBackColor = true;
            this.sign_up_button.Click += new System.EventHandler(this.sign_up_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sign_up_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.Login_button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button sign_up_button;
    }
}

