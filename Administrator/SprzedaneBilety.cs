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
    public partial class SprzedaneBilety : Form
    {
        public SprzedaneBilety()
        {
            InitializeComponent();
        }

        public void aktualizacja_listy()
        {
            //string numer_sali = 
            string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                ("select * from Bilet");
            //and Seans.Data+Film.CzasTrwania >= getdate()



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                MessageBox.Show("aktualizowanie");
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                //data.ToString();
                //cena.ToString();


                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        //command.ExecuteReader(listView_lista_pracownikow.Columns.Add());
                        //command.ExecuteReader();
                        // listView_lista_pracownikow.Items.Add(command.ExecuteReader());
                        //ListViewItem item = listView_lista_pracownikow.Items.Add(dataReader.GetValue(0).ToString());
                        /*for (int j = 1; j < 5; j++)
                        {
                            item.SubItems.Add(dataReader.GetValue(j).ToString());
                        }*/
                       /* ListViewItem item = listView_sprzedane.Items.Add(dataReader.GetValue(0).ToString());
                        item.SubItems.Add(dataReader["IDBiletu"].ToString());
                        item.SubItems.Add(dataReader["IDSeansu"].ToString());
                        item.SubItems.Add(dataReader["NrMiejsca"].ToString());
                        item.SubItems.Add(dataReader["CzyUlgowy"].ToString());
                        item.SubItems.Add(dataReader["Cena"].ToString());*/

                        ListViewItem item = listView_sprzedane.Items.Add(dataReader.GetValue(0).ToString());
                        for (int j = 1; j < 5; j++)
                        {
                            item.SubItems.Add(dataReader.GetValue(j).ToString());
                        }

                    }

                    dataReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
