namespace Administrator
{
    partial class Pracownicy
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
            this.listView_lista_pracownikow = new System.Windows.Forms.ListView();
            this.Identyfikator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypPracownika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Haslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_dodaj_pracownika = new System.Windows.Forms.Button();
            this.button_usun_pracownika = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_odswiez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista pracowników:";
            // 
            // listView_lista_pracownikow
            // 
            this.listView_lista_pracownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_lista_pracownikow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Identyfikator,
            this.TypPracownika,
            this.Imie,
            this.Nazwisko,
            this.Login,
            this.Haslo});
            this.listView_lista_pracownikow.FullRowSelect = true;
            this.listView_lista_pracownikow.GridLines = true;
            this.listView_lista_pracownikow.HideSelection = false;
            this.listView_lista_pracownikow.Location = new System.Drawing.Point(15, 33);
            this.listView_lista_pracownikow.MinimumSize = new System.Drawing.Size(489, 97);
            this.listView_lista_pracownikow.Name = "listView_lista_pracownikow";
            this.listView_lista_pracownikow.Size = new System.Drawing.Size(489, 97);
            this.listView_lista_pracownikow.TabIndex = 1;
            this.listView_lista_pracownikow.UseCompatibleStateImageBehavior = false;
            this.listView_lista_pracownikow.View = System.Windows.Forms.View.Details;
            // 
            // Identyfikator
            // 
            this.Identyfikator.Text = "Identyfikator";
            this.Identyfikator.Width = 70;
            // 
            // TypPracownika
            // 
            this.TypPracownika.Text = "Typ Pracownika";
            this.TypPracownika.Width = 115;
            // 
            // Imie
            // 
            this.Imie.Text = "Imie";
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 100;
            // 
            // Login
            // 
            this.Login.Text = "Login";
            this.Login.Width = 80;
            // 
            // Haslo
            // 
            this.Haslo.Text = "Hasło";
            // 
            // button_dodaj_pracownika
            // 
            this.button_dodaj_pracownika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_dodaj_pracownika.Location = new System.Drawing.Point(12, 151);
            this.button_dodaj_pracownika.Name = "button_dodaj_pracownika";
            this.button_dodaj_pracownika.Size = new System.Drawing.Size(111, 23);
            this.button_dodaj_pracownika.TabIndex = 2;
            this.button_dodaj_pracownika.Text = "Dodaj pracownika";
            this.button_dodaj_pracownika.UseVisualStyleBackColor = true;
            this.button_dodaj_pracownika.Click += new System.EventHandler(this.button_dodaj_pracownika_Click);
            // 
            // button_usun_pracownika
            // 
            this.button_usun_pracownika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_usun_pracownika.Location = new System.Drawing.Point(150, 151);
            this.button_usun_pracownika.Name = "button_usun_pracownika";
            this.button_usun_pracownika.Size = new System.Drawing.Size(122, 23);
            this.button_usun_pracownika.TabIndex = 3;
            this.button_usun_pracownika.Text = "Usun pracownika";
            this.button_usun_pracownika.UseVisualStyleBackColor = true;
            this.button_usun_pracownika.Click += new System.EventHandler(this.button_usun_pracownika_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(429, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_odswiez
            // 
            this.button_odswiez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_odswiez.Location = new System.Drawing.Point(290, 151);
            this.button_odswiez.Name = "button_odswiez";
            this.button_odswiez.Size = new System.Drawing.Size(96, 23);
            this.button_odswiez.TabIndex = 5;
            this.button_odswiez.Text = "Odśwież listę";
            this.button_odswiez.UseVisualStyleBackColor = true;
            this.button_odswiez.Click += new System.EventHandler(this.button_odswiez_Click);
            // 
            // Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 212);
            this.Controls.Add(this.button_odswiez);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_usun_pracownika);
            this.Controls.Add(this.button_dodaj_pracownika);
            this.Controls.Add(this.listView_lista_pracownikow);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(540, 251);
            this.Name = "Pracownicy";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pracownicy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_lista_pracownikow;
        private System.Windows.Forms.ColumnHeader Identyfikator;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Haslo;
        private System.Windows.Forms.Button button_dodaj_pracownika;
        private System.Windows.Forms.Button button_usun_pracownika;
        private System.Windows.Forms.ColumnHeader TypPracownika;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_odswiez;
    }
}