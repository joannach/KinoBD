namespace Administrator
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
            this.button_pracownicy = new System.Windows.Forms.Button();
            this.button_seanse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_pracownicy
            // 
            this.button_pracownicy.Location = new System.Drawing.Point(100, 35);
            this.button_pracownicy.Name = "button_pracownicy";
            this.button_pracownicy.Size = new System.Drawing.Size(75, 23);
            this.button_pracownicy.TabIndex = 0;
            this.button_pracownicy.Text = "Pracownicy";
            this.button_pracownicy.UseVisualStyleBackColor = true;
            this.button_pracownicy.Click += new System.EventHandler(this.button_pracownicy_Click);
            // 
            // button_seanse
            // 
            this.button_seanse.Location = new System.Drawing.Point(100, 64);
            this.button_seanse.Name = "button_seanse";
            this.button_seanse.Size = new System.Drawing.Size(75, 23);
            this.button_seanse.TabIndex = 1;
            this.button_seanse.Text = "Seanse";
            this.button_seanse.UseVisualStyleBackColor = true;
            this.button_seanse.Click += new System.EventHandler(this.button_seanse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sprzedane bilety";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(184, 132);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(75, 23);
            this.button_anuluj.TabIndex = 3;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_seanse);
            this.Controls.Add(this.button_pracownicy);
            this.MaximumSize = new System.Drawing.Size(300, 206);
            this.MinimumSize = new System.Drawing.Size(300, 206);
            this.Name = "Form1";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_pracownicy;
        private System.Windows.Forms.Button button_seanse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_anuluj;
    }
}

