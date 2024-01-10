namespace CallCenter1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(256, 67);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(228, 26);
            this.text_username.TabIndex = 2;
            this.text_username.TextChanged += new System.EventHandler(this.text_username_TextChanged);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(256, 104);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(228, 26);
            this.text_password.TabIndex = 3;
            this.text_password.TextChanged += new System.EventHandler(this.text_password_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(374, 190);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(168, 33);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(564, 270);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button btn_Login;
    }
}

