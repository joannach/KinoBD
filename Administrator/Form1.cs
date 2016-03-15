using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class Form1 : Form
    {
        public void niewidoczny_pracownicy()
        {
            button_pracownicy.Enabled = false;
        }

        public void widoczny_pracownicy()
        {
            button_pracownicy.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_pracownicy_Click(object sender, EventArgs e)
        {
            Pracownicy p = new Pracownicy();
            p.aktualizuj_liste_pracownikow();
            p.ShowDialog();
        }

        private void button_seanse_Click(object sender, EventArgs e)
        {
            Seanse s = new Seanse();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SprzedaneBilety sb = new SprzedaneBilety();
            sb.aktualizacja_listy();
            sb.ShowDialog();

        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
