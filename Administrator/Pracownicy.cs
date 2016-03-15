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
    public partial class Pracownicy : Form
    {
        public Pracownicy()
        {
            InitializeComponent();
        }

        public void aktualizuj_liste_pracownikow()
        {
            string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "select * from Pracownik";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                MessageBox.Show("aktualizowanie");
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);




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
                        ListViewItem item = listView_lista_pracownikow.Items.Add(dataReader.GetValue(0).ToString());
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

            /* ListViewItem item = listView_lista_pracownikow.Items.Add("abc");
             item.SubItems.Add("aaa");
             item.SubItems.Add("add");
             item.SubItems.Add("da");
             item.SubItems.Add("bbba");*/

        }


        private void button_dodaj_pracownika_Click(object sender, EventArgs e)
        {
            Edytor_pracownika ep = new Edytor_pracownika();
            ep.ShowDialog();


        }

        private void button_usun_pracownika_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_lista_pracownikow.SelectedItems)
            {
                MessageBox.Show("Usuwam pracownika " + item.Text);
                /*if (item.SubItems[1].Text == "administrator")
                {
                    MessageBox.Show("Nie mozna usunac administratora");
                    break;
                }*/
                string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

                // Provide the query string with a parameter placeholder.
                string queryString =
                "delete from Pracownik where IDPracownika = @Identyfikator";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    MessageBox.Show("aktualizowanie");
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("Identyfikator", int.Parse(item.Text));

                    //command.

                        try
                      {
                             connection.Open();
                             command.ExecuteNonQuery();
                    

                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Błąd " + ex.Message);
                     }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_odswiez_Click(object sender, EventArgs e)
        {
         
      
           // item.SubItems.Clear();
          //  Pracownicy p = new Pracownicy();
          //  p.listView_lista_pracownikow.Clear();
          //  aktualizuj_liste_pracownikow();

        }
    }
}




