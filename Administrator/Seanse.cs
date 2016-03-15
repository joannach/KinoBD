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
    public partial class Seanse : Form
    {
        public Seanse()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            DateTime data = new DateTime();
            Decimal cena = new Decimal();

            int nr_sali = int.Parse(comboBox1.Text);
            //string numer_sali = 
            string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                ("select * from Seans S,Film F where S.IDFilmu = F.IdFilmu AND DATEADD(second, DATEPART(hour, F.CzasTrwania)*3600 + DATEPART(minute, F.CzasTrwania)*60 + DATEPART(second, F.CzasTrwania), S.Data) >= getdate()");
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
                        if (nr_sali == (int)dataReader["IDSali"])
                        {
                            ListViewItem item = listView_seanse.Items.Add(dataReader.GetValue(0).ToString());
                            item.SubItems.Add(dataReader["IDSali"].ToString());
                            item.SubItems.Add(dataReader["IDFilmu"].ToString());
                            item.SubItems.Add(dataReader["WersjaJezykowa"].ToString());
                            item.SubItems.Add(dataReader["Wymiar"].ToString());
                            item.SubItems.Add(dataReader["Data"].ToString());
                            item.SubItems.Add(dataReader["Cena"].ToString());
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

        private void button_sprzedaj_bilet_Click(object sender, EventArgs e)
        {
            if (listView_seanse.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_seanse.SelectedItems[0];
                SprzedazBiletu sb = new SprzedazBiletu();
                sb.show(int.Parse(item.SubItems[0].Text));

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

