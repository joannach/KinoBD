using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Administrator
{
    public partial class Edytor_pracownika : Form
    {
        public string imie { get { return textBox1.Text; } set { } }
        public string nazwisko { get { return textBox2.Text; } set { } }
        public string login { get { return textBox3.Text; } set { } }
        public string haslo { get { return textBox4.Text; } set { } }
        public string typ_pracownika = "pracownik";
        public bool ok { get {return true;} private set {} }

        public Edytor_pracownika()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                ok = true;

                string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

                // Provide the query string with a parameter placeholder.
                string queryString =
                    "INSERT into Pracownik (Imie, Nazwisko, LoginPracownika, Haslo) values(@imie, @nazwisko, @login, @haslo)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    MessageBox.Show("dodawanie");
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@typ_pracownika", typ_pracownika);
                    command.Parameters.AddWithValue("@imie", imie);
                    command.Parameters.AddWithValue("@nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@haslo", haslo);

                    // Open the connection in a try/catch block. 
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    try
                    {
                        connection.Open();
                        int wynik = command.ExecuteNonQuery();
                        if (wynik == 1)
                        {
                            MessageBox.Show("Dodano nowego pracownika");
                        }
                        else
                        {
                            MessageBox.Show("Nie udało się dodać pracownika");
                        }
                        


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd " + ex.Message);
                    }
                }
                
                Close();
            }
            else
            {
                MessageBox.Show("Prosze wypelnic pola");
            }

        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            ok = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Close();
        }

        private void Edytor_pracownika_Load(object sender, EventArgs e)
        {

        }

        private void Edytor_pracownika_FormClosed(object sender, FormClosedEventArgs e)
        {

            ok = false;  /*****************************/
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
