namespace Administrator
{
    partial class Seanse
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_seanse = new System.Windows.Forms.ListView();
            this.IDSeansu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDSali = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDFilmu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wersjajezykowa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wymiar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_sprzedaj_bilet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(31, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer sali:";
            // 
            // listView_seanse
            // 
            this.listView_seanse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_seanse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDSeansu,
            this.IDSali,
            this.IDFilmu,
            this.wersjajezykowa,
            this.wymiar,
            this.data,
            this.cena});
            this.listView_seanse.FullRowSelect = true;
            this.listView_seanse.GridLines = true;
            this.listView_seanse.HideSelection = false;
            this.listView_seanse.Location = new System.Drawing.Point(31, 98);
            this.listView_seanse.Name = "listView_seanse";
            this.listView_seanse.Size = new System.Drawing.Size(658, 159);
            this.listView_seanse.TabIndex = 2;
            this.listView_seanse.UseCompatibleStateImageBehavior = false;
            this.listView_seanse.View = System.Windows.Forms.View.Details;
            // 
            // IDSeansu
            // 
            this.IDSeansu.Text = "Numer seansu";
            this.IDSeansu.Width = 90;
            // 
            // IDSali
            // 
            this.IDSali.Text = "Numer sali";
            this.IDSali.Width = 90;
            // 
            // IDFilmu
            // 
            this.IDFilmu.Text = "Numer filmu";
            this.IDFilmu.Width = 90;
            // 
            // wersjajezykowa
            // 
            this.wersjajezykowa.Text = "Wersja językowa";
            this.wersjajezykowa.Width = 100;
            // 
            // wymiar
            // 
            this.wymiar.Text = "Wymiar 2D/3D";
            this.wymiar.Width = 90;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 100;
            // 
            // cena
            // 
            this.cena.Text = "Cena";
            this.cena.Width = 90;
            // 
            // button_sprzedaj_bilet
            // 
            this.button_sprzedaj_bilet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sprzedaj_bilet.Location = new System.Drawing.Point(614, 32);
            this.button_sprzedaj_bilet.Name = "button_sprzedaj_bilet";
            this.button_sprzedaj_bilet.Size = new System.Drawing.Size(75, 47);
            this.button_sprzedaj_bilet.TabIndex = 3;
            this.button_sprzedaj_bilet.Text = "Sprzedaj bilet";
            this.button_sprzedaj_bilet.UseVisualStyleBackColor = true;
            this.button_sprzedaj_bilet.Click += new System.EventHandler(this.button_sprzedaj_bilet_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(614, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seanse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_sprzedaj_bilet);
            this.Controls.Add(this.listView_seanse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.MinimumSize = new System.Drawing.Size(733, 336);
            this.Name = "Seanse";
            this.Text = "Seanse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_seanse;
        private System.Windows.Forms.ColumnHeader IDSeansu;
        private System.Windows.Forms.ColumnHeader IDSali;
        private System.Windows.Forms.ColumnHeader IDFilmu;
        private System.Windows.Forms.ColumnHeader wersjajezykowa;
        private System.Windows.Forms.ColumnHeader wymiar;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader cena;
        private System.Windows.Forms.Button button_sprzedaj_bilet;
        private System.Windows.Forms.Button button1;
    }
}