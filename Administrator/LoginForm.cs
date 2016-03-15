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
    public partial class LoginForm : Form
    {
        string login;
        string haslo;
        string typ_pr = "administrator";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_zaloguj_Click(object sender, EventArgs e)
        {
            login = textBox_login.Text;
            haslo = textBox_haslo.Text;

            string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

            //string cmdString = ("SELECT UserName, Password FROM Users WHERE UserName ='" + userName +
            //                    "'AND Password ='" + password + "'");         //REMOVED AS THIS IS PRONE TO SQL INJECTIONS

            SqlConnection connection = new SqlConnection(connectionString);

            string cmdString = ("SELECT * FROM Pracownik WHERE LoginPracownika = @uname AND Haslo = @pw");

            SqlCommand cmd = new SqlCommand(cmdString, connection);

            cmd.Parameters.AddWithValue("uname", login);
            cmd.Parameters.AddWithValue("pw", haslo);
            //cmd.Parameters.Add("@TypPracownika", SqlDbType.VarChar).Value = typ_pr ;



            DataSet loginCredentials = new DataSet();
            SqlDataAdapter dataAdapter;

            try
            {
                if (textBox_login.Text != "" && textBox_haslo.Text != "")
                {
                    if (connection.State.Equals(ConnectionState.Closed))
                    {
                        connection.Open();


                        dataAdapter = new SqlDataAdapter(cmd);
                        dataAdapter.Fill(loginCredentials);


                        // cmd.Parameters.Add("administrator", SqlDbType.VarChar).Value = typ_pr;

                        if (loginCredentials.Tables[0].Rows.Count > 0)
                        {
                            string typ = loginCredentials.Tables[0].Rows[0]["TypPracownika"].ToString();
                            if (typ == "administrator")
                            {

                                Form1 f = new Form1();
                                f.widoczny_pracownicy();
                                f.ShowDialog();
                            }
                            else
                            {
                                Form1 f = new Form1();
                                f.niewidoczny_pracownicy();
                                f.ShowDialog();
                            }

                        }
                        else
                        {
                            //lblMessage.Text = "Incorrect Username or Password";
                            //lblMessage.Visible = true;
                            MessageBox.Show("Nie ma takiego pracownika");
                        }
                    }
                    connection.Close();
                }
                else
                    MessageBox.Show("Prosze wpisac login i/lub haslo");
                
            }
            catch (Exception err)
            {
               // lblMessage.Text = err.Message.ToString() + " Error connecting to the Database // " + cmd.Parameters.Count;
               // lblMessage.Visible = true;
                MessageBox.Show(err.Message.ToString());

            }





  /*          login = textBox_login.ToString();
            haslo = textBox_haslo.ToString();

            

            string connectionString = "Data Source=(local);Initial Catalog=KINO;" + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            
   * 

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
                    command.Parameters.Add(login, SqlDbType.VarChar).Value = login;
                    command.Parameters.Add(haslo, SqlDbType.VarChar).Value = haslo;

                   if (dataReader.Read())
                    {

                        if (command.Parameters.Equals(login) && command.Parameters.Equals(haslo))
                        {
                            command.Parameters.Add(login, SqlDbType.VarChar).Value = login;
                            command.Parameters.Add(login, SqlDbType.VarChar).Value = login;

                            MessageBox.Show("OK");
                            if (command.Parameters.Equals("administrator"))
                            {
                                Form1 f = new Form1();
                                f.ShowDialog();
                            }
                            else
                            {
                                Form1 f = new Form1();
                                f.widocznosc_pracownicy();
                                f.ShowDialog();

                            }
                        }

                    }

                    dataReader.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd " + ex.Message);
                }
            }*/
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
