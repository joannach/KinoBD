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
    public partial class SprzedazBiletu : Form
    {
        public SprzedazBiletu()
        {

            InitializeComponent();
        }

        int m_id_seansu;

        public void show(int id_seansu)
        {


            m_id_seansu = id_seansu;
            string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                ("select NrMiejsca from Bilet where IDSeansu = @id_seansu");

            string queryString2 = ("select LiczbaMiejsc from Sala where IDSali = (select IDSali from Seans where IDSeansu = @id_seansu)");

            //and Seans.Data+Film.CzasTrwania >= getdate()
            string queryString3 = ("select * from Film where IDFilmu = (select IDFilmu from Seans where IDSeansu = @id_seansu)");

            string queryString4 = ("select Cena from Seans where IDSeansu = @id_seansu");



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                MessageBox.Show("aktualizowanie");
                // Create the Command and Parameter objects.
                SqlCommand command1 = new SqlCommand(queryString, connection);
                SqlCommand command2 = new SqlCommand(queryString2, connection);
                SqlCommand command3 = new SqlCommand(queryString3, connection);
                SqlCommand command4 = new SqlCommand(queryString4, connection);

                command1.Parameters.AddWithValue("id_seansu", id_seansu);
                command2.Parameters.AddWithValue("id_seansu", id_seansu);
                command3.Parameters.AddWithValue("id_seansu", id_seansu);
                command4.Parameters.AddWithValue("id_seansu", id_seansu);

                try
                {
                    connection.Open();



                    SqlDataReader dataReader3 = command3.ExecuteReader();
                    dataReader3.Read();

                    labelTytul.Text = dataReader3["Tytul"].ToString();

                    dataReader3.Close();

                    SqlDataReader dataReader2 = command2.ExecuteReader();
                    dataReader2.Read();
                    int liczba_miejsc = (int)dataReader2[0]; /******************/

                    dataReader2.Close();

                    bool[] zajete = new bool[liczba_miejsc + 1];
                    for (int i = 0; i < liczba_miejsc + 1; i++)
                        zajete[i] = false;

                    SqlDataReader dataReader1 = command1.ExecuteReader();
                    while (dataReader1.Read())
                    {
                        int nr_miejsca = (int)dataReader1["NrMiejsca"];

                        zajete[nr_miejsca] = true;

                    }

                    dataReader1.Close();

                    for (int i = 1; i <= liczba_miejsc; i++)
                    {
                        if (zajete[i] == false)
                            comboBox_miejsca.Items.Add(i.ToString());
                    }

                    SqlDataReader dataReader4 = command4.ExecuteReader();
                    dataReader4.Read();
                    //textBox1.Text = dataReader4[0].ToString();
                    float cena = float.Parse(dataReader4[0].ToString());
                    textBox1.Text = cena.ToString();

                    dataReader4.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd " + ex.Message);
                }
            }

            ShowDialog();

        }

        public void cena_ulgowa()
        {
            double cena = double.Parse(textBox1.Text) * 0.7;
            textBox2.Text = cena.ToString();
        }

        private void button_sprzedaj_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "insert into Bilet(IDSeansu, NrMiejsca, CzyUlgowy, Cena) values(@id_seansu, @nr_miejsca, 0, @cena)";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);


                if (checkBox1.Checked)
                {
                    double cena = double.Parse(textBox1.Text) * 0.7;
                    textBox2.Text = cena.ToString();
                    //command.Parameters.AddWithValue(cena, int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("id_seansu", m_id_seansu);
                    command.Parameters.AddWithValue("nr_miejsca", int.Parse(comboBox_miejsca.Text));
                    command.Parameters.AddWithValue("cena", double.Parse(textBox2.Text));
                }
                else
                {
                    command.Parameters.AddWithValue("cena", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("id_seansu", m_id_seansu);
                    command.Parameters.AddWithValue("nr_miejsca", int.Parse(comboBox_miejsca.Text));
                }

                command.ExecuteNonQuery();

                // niepoprawnie bo 2 osoby moga sprzedac bilet na to samo miejsce jednoczesnie

            }

            MessageBox.Show("Sprzedano bilet!");
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_sprzedane_Click(object sender, EventArgs e)
        {
            SprzedaneBilety sb = new SprzedaneBilety();
            sb.aktualizacja_listy();
            sb.ShowDialog();
        }
    }
}

// wyswietlanie sprzedanych

