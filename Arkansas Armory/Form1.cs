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

namespace Arkansas_Armory
{
    public partial class Form1 : Form
    {
        /////////////////////////////////////////////////////
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2241;User ID=PROJECTS2241;Password=CN74kyu$";
        /////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
        }

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////
            try
            {
                if (cboAccount.SelectedIndex > -1)
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open();
                    string sql = "SELECT * FROM Customer WHERE First_Name = '" + cboAccount.SelectedItem.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    datareader = command.ExecuteReader();
                    while (datareader.Read())
                    {
                        txtFirst_Name.Text = datareader[0].ToString();
                        txtLast_Name.Text = datareader[1].ToString();
                        txtEmail.Text = datareader[2].ToString();
                        txtPassword.Text = datareader[3].ToString();
                    }
                    connection.Close();
                    command.Dispose();
                    datareader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            /////////////////////////////////////////////////////
        }

        private void btnCreate_Account_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open();
                int answer;
                string sql = "INSERT INTO Cutsomer VALUES (@)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Fname", txtFirst_Name.Text);
                command.Parameters.AddWithValue("@Lname", txtLast_Name.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);

                answer = command.ExecuteNonQuery();

                connection.Close();
                command.Dispose();
                MessageBox.Show("You have successfully entered " + answer + " into the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! You need to solve: " + ex);
            }
            /////////////////////////////////////////////////////
        }
    }
}
