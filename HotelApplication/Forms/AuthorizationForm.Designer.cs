namespace HotelApplication.Forms
{
    partial class AuthorizationForm
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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setIn = new System.Windows.Forms.Button();
            this.setUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(135, 159);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(151, 20);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(135, 233);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(151, 20);
            this.password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // setIn
            // 
            this.setIn.Location = new System.Drawing.Point(70, 314);
            this.setIn.Name = "setIn";
            this.setIn.Size = new System.Drawing.Size(75, 23);
            this.setIn.TabIndex = 4;
            this.setIn.Text = "Войти";
            this.setIn.UseVisualStyleBackColor = true;
            this.setIn.Click += new System.EventHandler(this.setIn_Click);
            // 
            // setUp
            // 
            this.setUp.Location = new System.Drawing.Point(235, 314);
            this.setUp.Name = "setUp";
            this.setUp.Size = new System.Drawing.Size(99, 44);
            this.setUp.TabIndex = 5;
            this.setUp.Text = "Регистрация";
            this.setUp.UseVisualStyleBackColor = true;
            this.setUp.Click += new System.EventHandler(this.setUp_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 437);
            this.Controls.Add(this.setUp);
            this.Controls.Add(this.setIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setIn;
        private System.Windows.Forms.Button setUp;
    }
}