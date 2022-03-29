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
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2241;User ID=PROJECTS2241;Password=CN74kyu$";

        DataTable dtInventory;

        public void refresh()
        {

           

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Account_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open();
                int answer;
                string sql = "INSERT INTO dbo.Customer(Username,Password,FirstName,LastName,ShippingStreetAddress,ShippingCity,ShippingZipcode,ShippingState,BillingStreetAddress,BillingCity,BillingZipcode,BillingState,DoB,DriversLicenseNumber,ConcealCarryStatus,CreditCardNumber,CryptoType,CryptoWalletAddress,Email) VALUES (@User, @Pass, @Fname, @Lname, @ShipStreet, @ShipCity, @ShipZip, @ShipState, @BillStreet, @BillCity, " +
                    "@BillZip, @BillState, @DoB, @DLNum, @CCStatus, @CCNUmber, @CryptoType, @CryptoWallet,@Email)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Fname", txtFirst_Name.Text);
                command.Parameters.AddWithValue("@Lname", txtLast_Name.Text);
                command.Parameters.AddWithValue("@Pass", txtPassword.Text);
                command.Parameters.AddWithValue("@User", txtUsername.Text);
                command.Parameters.AddWithValue("@ShipStreet", txtShippingStreetAddress.Text);
                command.Parameters.AddWithValue("@ShipCity", txtShippingCity.Text);
                command.Parameters.AddWithValue("@ShipZip", txtShippingZip.Text);
                command.Parameters.AddWithValue("@ShipState", txtShippingState.Text);
                command.Parameters.AddWithValue("@BillStreet", txtBillingStreetAddress.Text);
                command.Parameters.AddWithValue("@BillCity", txtBillingCity.Text);
                command.Parameters.AddWithValue("@BillZip", txtBillingZip.Text);
                command.Parameters.AddWithValue("@BillState", txtBillingState.Text);
                command.Parameters.AddWithValue("@DoB", txtDateOfBirth.Text);
                command.Parameters.AddWithValue("@DLNum", txtDriverLiscenceNum.Text);
                command.Parameters.AddWithValue("@CCStatus", txtConcealedCarry.Text);
                command.Parameters.AddWithValue("@CCNumber", txtCreditCardNum.Text);
              
                command.Parameters.AddWithValue("@CryptoType", txtCryptoType.Text);
                command.Parameters.AddWithValue("@CryptoWallet", txtBillingCity.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);


                answer = command.ExecuteNonQuery();

                connection.Close();
                command.Dispose();
                MessageBox.Show("You have successfully entered " + answer + " into the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! You need to solve: " + ex);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCreateAccount.Visible = false;
            pnlShoppingCart.Visible = false;
            pnlLogin.Visible = false;

            refresh();

            
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            pnlCreateAccount.Visible = true;
            pnlCreateAccount.Location = new Point(0, 0);
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            pnlShoppingCart.Visible = true;
            pnlShoppingCart.Location = new Point(0, 0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlCreateAccount.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.Location = new Point(0, 0);
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
