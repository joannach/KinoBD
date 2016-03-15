namespace Administrator
{
    partial class SprzedazBiletu
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
            this.comboBox_miejsca = new System.Windows.Forms.ComboBox();
            this.button_sprzedaj = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.labelTytul = new System.Windows.Forms.Label();
            this.label_tytul = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_sprzedane = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_miejsca
            // 
            this.comboBox_miejsca.FormattingEnabled = true;
            this.comboBox_miejsca.Location = new System.Drawing.Point(143, 25);
            this.comboBox_miejsca.Name = "comboBox_miejsca";
            this.comboBox_miejsca.Size = new System.Drawing.Size(121, 21);
            this.comboBox_miejsca.TabIndex = 0;
            // 
            // button_sprzedaj
            // 
            this.button_sprzedaj.Location = new System.Drawing.Point(197, 95);
            this.button_sprzedaj.Name = "button_sprzedaj";
            this.button_sprzedaj.Size = new System.Drawing.Size(75, 38);
            this.button_sprzedaj.TabIndex = 1;
            this.button_sprzedaj.Text = "Sprzedaj";
            this.button_sprzedaj.UseVisualStyleBackColor = true;
            this.button_sprzedaj.Click += new System.EventHandler(this.button_sprzedaj_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(197, 196);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(75, 38);
            this.button_anuluj.TabIndex = 2;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // labelTytul
            // 
            this.labelTytul.AutoSize = true;
            this.labelTytul.Location = new System.Drawing.Point(12, 67);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(35, 13);
            this.labelTytul.TabIndex = 3;
            this.labelTytul.Text = "label1";
            // 
            // label_tytul
            // 
            this.label_tytul.AutoSize = true;
            this.label_tytul.Location = new System.Drawing.Point(12, 28);
            this.label_tytul.Name = "label_tytul";
            this.label_tytul.Size = new System.Drawing.Size(125, 13);
            this.label_tytul.TabIndex = 4;
            this.label_tytul.Text = "Dostępne numery miejsc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button_sprzedane
            // 
            this.button_sprzedane.Location = new System.Drawing.Point(15, 196);
            this.button_sprzedane.Name = "button_sprzedane";
            this.button_sprzedane.Size = new System.Drawing.Size(75, 38);
            this.button_sprzedane.TabIndex = 8;
            this.button_sprzedane.Text = "Sprzedane bilety";
            this.button_sprzedane.UseVisualStyleBackColor = true;
            this.button_sprzedane.Click += new System.EventHandler(this.button_sprzedane_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Ulga ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cena ulgowa";
            // 
            // SprzedazBiletu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_sprzedane);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_tytul);
            this.Controls.Add(this.labelTytul);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_sprzedaj);
            this.Controls.Add(this.comboBox_miejsca);
            this.MaximumSize = new System.Drawing.Size(300, 285);
            this.MinimumSize = new System.Drawing.Size(300, 285);
            this.Name = "SprzedazBiletu";
            this.Text = "SprzedazBiletu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_miejsca;
        private System.Windows.Forms.Button button_sprzedaj;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Label label_tytul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_sprzedane;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}