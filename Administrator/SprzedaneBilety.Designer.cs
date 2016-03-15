namespace Administrator
{
    partial class SprzedaneBilety
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
            this.listView_sprzedane = new System.Windows.Forms.ListView();
            this.id_biletu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_seansu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nr_miejsca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.czy_ulgowy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_sprzedane
            // 
            this.listView_sprzedane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_sprzedane.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_biletu,
            this.id_seansu,
            this.nr_miejsca,
            this.czy_ulgowy,
            this.cena});
            this.listView_sprzedane.GridLines = true;
            this.listView_sprzedane.Location = new System.Drawing.Point(12, 52);
            this.listView_sprzedane.Name = "listView_sprzedane";
            this.listView_sprzedane.Size = new System.Drawing.Size(384, 152);
            this.listView_sprzedane.TabIndex = 0;
            this.listView_sprzedane.UseCompatibleStateImageBehavior = false;
            this.listView_sprzedane.View = System.Windows.Forms.View.Details;
            // 
            // id_biletu
            // 
            this.id_biletu.Text = "IDBiletu";
            // 
            // id_seansu
            // 
            this.id_seansu.Text = "IDSeansu";
            // 
            // nr_miejsca
            // 
            this.nr_miejsca.Text = "Nr miejsca";
            this.nr_miejsca.Width = 90;
            // 
            // czy_ulgowy
            // 
            this.czy_ulgowy.Text = "Ulgowy";
            // 
            // cena
            // 
            this.cena.Text = "Cena";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(321, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wyjście";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SprzedaneBilety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_sprzedane);
            this.MinimumSize = new System.Drawing.Size(424, 273);
            this.Name = "SprzedaneBilety";
            this.Text = "SprzedaneBilety";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_sprzedane;
        private System.Windows.Forms.ColumnHeader id_biletu;
        private System.Windows.Forms.ColumnHeader id_seansu;
        private System.Windows.Forms.ColumnHeader nr_miejsca;
        private System.Windows.Forms.ColumnHeader czy_ulgowy;
        private System.Windows.Forms.ColumnHeader cena;
        private System.Windows.Forms.Button button1;
    }
}