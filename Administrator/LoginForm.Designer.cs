namespace Administrator
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_zaloguj = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // button_zaloguj
            // 
            this.button_zaloguj.Location = new System.Drawing.Point(100, 125);
            this.button_zaloguj.Name = "button_zaloguj";
            this.button_zaloguj.Size = new System.Drawing.Size(75, 23);
            this.button_zaloguj.TabIndex = 2;
            this.button_zaloguj.Text = "Zaloguj";
            this.button_zaloguj.UseVisualStyleBackColor = true;
            this.button_zaloguj.Click += new System.EventHandler(this.button_zaloguj_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(80, 19);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(117, 20);
            this.textBox_login.TabIndex = 3;
            this.textBox_login.Text = "jan";
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Location = new System.Drawing.Point(80, 62);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(117, 20);
            this.textBox_haslo.TabIndex = 4;
            this.textBox_haslo.Text = "kowalski";
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(100, 173);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(75, 23);
            this.button_anuluj.TabIndex = 5;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 229);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_zaloguj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(294, 268);
            this.Name = "LoginForm";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_zaloguj;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.Button button_anuluj;
    }
}