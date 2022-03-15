
namespace Arkansas_Armory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate_Account = new System.Windows.Forms.Button();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.txtFirst_Name = new System.Windows.Forms.TextBox();
            this.txtLast_Name = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCreateAccount = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtShippingStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCryptoWallet = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCryptoType = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCreditCardNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtConcealedCarry = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDriverLiscenceNum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBillingState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBillingZip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBillingCity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBillingStreetAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtShippingState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShippingZip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShippingCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.cboInventoryFilter = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlShoppingCart = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlCreateAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueforSAS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create an Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // btnCreate_Account
            // 
            this.btnCreate_Account.Location = new System.Drawing.Point(545, 492);
            this.btnCreate_Account.Name = "btnCreate_Account";
            this.btnCreate_Account.Size = new System.Drawing.Size(99, 48);
            this.btnCreate_Account.TabIndex = 5;
            this.btnCreate_Account.Text = "Create";
            this.btnCreate_Account.UseVisualStyleBackColor = true;
            this.btnCreate_Account.Click += new System.EventHandler(this.btnCreate_Account_Click);
            // 
            // cboAccount
            // 
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(206, 88);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(345, 21);
            this.cboAccount.TabIndex = 6;
            this.cboAccount.SelectedIndexChanged += new System.EventHandler(this.cboAccount_SelectedIndexChanged);
            // 
            // txtFirst_Name
            // 
            this.txtFirst_Name.Location = new System.Drawing.Point(206, 123);
            this.txtFirst_Name.Name = "txtFirst_Name";
            this.txtFirst_Name.Size = new System.Drawing.Size(345, 20);
            this.txtFirst_Name.TabIndex = 7;
            // 
            // txtLast_Name
            // 
            this.txtLast_Name.Location = new System.Drawing.Point(206, 158);
            this.txtLast_Name.Name = "txtLast_Name";
            this.txtLast_Name.Size = new System.Drawing.Size(345, 20);
            this.txtLast_Name.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(206, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 270);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(345, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Shipping Street Address";
            // 
            // pnlCreateAccount
            // 
            this.pnlCreateAccount.BackColor = System.Drawing.Color.White;
            this.pnlCreateAccount.Controls.Add(this.btnBack);
            this.pnlCreateAccount.Controls.Add(this.label20);
            this.pnlCreateAccount.Controls.Add(this.txtShippingStreetAddress);
            this.pnlCreateAccount.Controls.Add(this.txtCryptoWallet);
            this.pnlCreateAccount.Controls.Add(this.label18);
            this.pnlCreateAccount.Controls.Add(this.txtCryptoType);
            this.pnlCreateAccount.Controls.Add(this.label19);
            this.pnlCreateAccount.Controls.Add(this.txtCreditCardNum);
            this.pnlCreateAccount.Controls.Add(this.label14);
            this.pnlCreateAccount.Controls.Add(this.txtConcealedCarry);
            this.pnlCreateAccount.Controls.Add(this.label15);
            this.pnlCreateAccount.Controls.Add(this.txtDriverLiscenceNum);
            this.pnlCreateAccount.Controls.Add(this.label16);
            this.pnlCreateAccount.Controls.Add(this.txtDateOfBirth);
            this.pnlCreateAccount.Controls.Add(this.label17);
            this.pnlCreateAccount.Controls.Add(this.txtBillingState);
            this.pnlCreateAccount.Controls.Add(this.label10);
            this.pnlCreateAccount.Controls.Add(this.txtBillingZip);
            this.pnlCreateAccount.Controls.Add(this.label11);
            this.pnlCreateAccount.Controls.Add(this.txtBillingCity);
            this.pnlCreateAccount.Controls.Add(this.label12);
            this.pnlCreateAccount.Controls.Add(this.txtBillingStreetAddress);
            this.pnlCreateAccount.Controls.Add(this.label13);
            this.pnlCreateAccount.Controls.Add(this.txtShippingState);
            this.pnlCreateAccount.Controls.Add(this.label9);
            this.pnlCreateAccount.Controls.Add(this.txtShippingZip);
            this.pnlCreateAccount.Controls.Add(this.label8);
            this.pnlCreateAccount.Controls.Add(this.txtShippingCity);
            this.pnlCreateAccount.Controls.Add(this.label7);
            this.pnlCreateAccount.Controls.Add(this.txtUsername);
            this.pnlCreateAccount.Controls.Add(this.label6);
            this.pnlCreateAccount.Controls.Add(this.btnCreate_Account);
            this.pnlCreateAccount.Controls.Add(this.txtPassword);
            this.pnlCreateAccount.Controls.Add(this.label5);
            this.pnlCreateAccount.Controls.Add(this.label1);
            this.pnlCreateAccount.Controls.Add(this.label4);
            this.pnlCreateAccount.Controls.Add(this.label2);
            this.pnlCreateAccount.Controls.Add(this.label3);
            this.pnlCreateAccount.Controls.Add(this.cboAccount);
            this.pnlCreateAccount.Controls.Add(this.txtFirst_Name);
            this.pnlCreateAccount.Controls.Add(this.txtEmail);
            this.pnlCreateAccount.Controls.Add(this.txtLast_Name);
            this.pnlCreateAccount.Location = new System.Drawing.Point(330, 90);
            this.pnlCreateAccount.Name = "pnlCreateAccount";
            this.pnlCreateAccount.Size = new System.Drawing.Size(1190, 621);
            this.pnlCreateAccount.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(113, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 21);
            this.label20.TabIndex = 43;
            this.label20.Text = "Password";
            // 
            // txtShippingStreetAddress
            // 
            this.txtShippingStreetAddress.Location = new System.Drawing.Point(206, 307);
            this.txtShippingStreetAddress.Name = "txtShippingStreetAddress";
            this.txtShippingStreetAddress.Size = new System.Drawing.Size(345, 20);
            this.txtShippingStreetAddress.TabIndex = 42;
            // 
            // txtCryptoWallet
            // 
            this.txtCryptoWallet.Location = new System.Drawing.Point(811, 425);
            this.txtCryptoWallet.Name = "txtCryptoWallet";
            this.txtCryptoWallet.Size = new System.Drawing.Size(345, 20);
            this.txtCryptoWallet.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(624, 425);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 21);
            this.label18.TabIndex = 41;
            this.label18.Text = "Crypto Wallet Address";
            // 
            // txtCryptoType
            // 
            this.txtCryptoType.Location = new System.Drawing.Point(811, 386);
            this.txtCryptoType.Name = "txtCryptoType";
            this.txtCryptoType.Size = new System.Drawing.Size(345, 20);
            this.txtCryptoType.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(707, 387);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 21);
            this.label19.TabIndex = 39;
            this.label19.Text = "CryptoType";
            // 
            // txtCreditCardNum
            // 
            this.txtCreditCardNum.Location = new System.Drawing.Point(811, 347);
            this.txtCreditCardNum.Name = "txtCreditCardNum";
            this.txtCreditCardNum.Size = new System.Drawing.Size(345, 20);
            this.txtCreditCardNum.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(642, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 21);
            this.label14.TabIndex = 37;
            this.label14.Text = "Credit Card Number";
            // 
            // txtConcealedCarry
            // 
            this.txtConcealedCarry.Location = new System.Drawing.Point(811, 307);
            this.txtConcealedCarry.Name = "txtConcealedCarry";
            this.txtConcealedCarry.Size = new System.Drawing.Size(345, 20);
            this.txtConcealedCarry.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(616, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 21);
            this.label15.TabIndex = 35;
            this.label15.Text = "Concealed Carry Status";
            // 
            // txtDriverLiscenceNum
            // 
            this.txtDriverLiscenceNum.Location = new System.Drawing.Point(811, 270);
            this.txtDriverLiscenceNum.Name = "txtDriverLiscenceNum";
            this.txtDriverLiscenceNum.Size = new System.Drawing.Size(345, 20);
            this.txtDriverLiscenceNum.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(614, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 21);
            this.label16.TabIndex = 33;
            this.label16.Text = "Driver Liscence Number";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(811, 231);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(345, 20);
            this.txtDateOfBirth.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(700, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 21);
            this.label17.TabIndex = 31;
            this.label17.Text = "Date of Birth";
            // 
            // txtBillingState
            // 
            this.txtBillingState.Location = new System.Drawing.Point(811, 191);
            this.txtBillingState.Name = "txtBillingState";
            this.txtBillingState.Size = new System.Drawing.Size(345, 20);
            this.txtBillingState.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(705, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Billing State";
            // 
            // txtBillingZip
            // 
            this.txtBillingZip.Location = new System.Drawing.Point(811, 158);
            this.txtBillingZip.Name = "txtBillingZip";
            this.txtBillingZip.Size = new System.Drawing.Size(345, 20);
            this.txtBillingZip.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(676, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Billing Zip Code";
            // 
            // txtBillingCity
            // 
            this.txtBillingCity.Location = new System.Drawing.Point(811, 124);
            this.txtBillingCity.Name = "txtBillingCity";
            this.txtBillingCity.Size = new System.Drawing.Size(345, 20);
            this.txtBillingCity.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(715, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Billing City";
            // 
            // txtBillingStreetAddress
            // 
            this.txtBillingStreetAddress.Location = new System.Drawing.Point(811, 89);
            this.txtBillingStreetAddress.Name = "txtBillingStreetAddress";
            this.txtBillingStreetAddress.Size = new System.Drawing.Size(345, 20);
            this.txtBillingStreetAddress.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(631, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Billing Street Address";
            // 
            // txtShippingState
            // 
            this.txtShippingState.Location = new System.Drawing.Point(206, 424);
            this.txtShippingState.Name = "txtShippingState";
            this.txtShippingState.Size = new System.Drawing.Size(345, 20);
            this.txtShippingState.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Shipping State";
            // 
            // txtShippingZip
            // 
            this.txtShippingZip.Location = new System.Drawing.Point(206, 386);
            this.txtShippingZip.Name = "txtShippingZip";
            this.txtShippingZip.Size = new System.Drawing.Size(345, 20);
            this.txtShippingZip.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Shipping Zip Code";
            // 
            // txtShippingCity
            // 
            this.txtShippingCity.Location = new System.Drawing.Point(206, 347);
            this.txtShippingCity.Name = "txtShippingCity";
            this.txtShippingCity.Size = new System.Drawing.Size(345, 20);
            this.txtShippingCity.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Shipping City";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(206, 231);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(345, 20);
            this.txtUsername.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 44);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLogOut);
            this.groupBox1.Controls.Add(this.btnOrders);
            this.groupBox1.Controls.Add(this.btnShoppingCart);
            this.groupBox1.Controls.Add(this.btnCreateAccount);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1388, 72);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arkansas Armory";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1256, 19);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(126, 44);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(969, 19);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(126, 44);
            this.btnOrders.TabIndex = 17;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Location = new System.Drawing.Point(657, 19);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(126, 44);
            this.btnShoppingCart.TabIndex = 17;
            this.btnShoppingCart.Text = "Shopping Cart";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(328, 19);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(126, 44);
            this.btnCreateAccount.TabIndex = 17;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(18, 190);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(1383, 522);
            this.dgvInventory.TabIndex = 17;
            // 
            // cboInventoryFilter
            // 
            this.cboInventoryFilter.FormattingEnabled = true;
            this.cboInventoryFilter.Location = new System.Drawing.Point(18, 143);
            this.cboInventoryFilter.Name = "cboInventoryFilter";
            this.cboInventoryFilter.Size = new System.Drawing.Size(403, 21);
            this.cboInventoryFilter.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Snow;
            this.label21.Location = new System.Drawing.Point(12, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(420, 39);
            this.label21.TabIndex = 19;
            this.label21.Text = "Select Gun Classifcation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1268, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 73);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlShoppingCart
            // 
            this.pnlShoppingCart.BackColor = System.Drawing.Color.White;
            this.pnlShoppingCart.Controls.Add(this.pictureBox1);
            this.pnlShoppingCart.Controls.Add(this.button2);
            this.pnlShoppingCart.Controls.Add(this.label24);
            this.pnlShoppingCart.Controls.Add(this.txttotal);
            this.pnlShoppingCart.Controls.Add(this.label23);
            this.pnlShoppingCart.Controls.Add(this.label22);
            this.pnlShoppingCart.Controls.Add(this.dataGridView1);
            this.pnlShoppingCart.Location = new System.Drawing.Point(1298, 92);
            this.pnlShoppingCart.Name = "pnlShoppingCart";
            this.pnlShoppingCart.Size = new System.Drawing.Size(686, 372);
            this.pnlShoppingCart.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Proceed to Checkout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(460, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(510, 125);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(73, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Product";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(266, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(162, 25);
            this.label22.TabIndex = 1;
            this.label22.Text = "Shopping Cart";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 142);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(687, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 48);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1444, 848);
            this.Controls.Add(this.pnlShoppingCart);
            this.Controls.Add(this.pnlCreateAccount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cboInventoryFilter);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCreateAccount.ResumeLayout(false);
            this.pnlCreateAccount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlShoppingCart.ResumeLayout(false);
            this.pnlShoppingCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate_Account;
        private System.Windows.Forms.ComboBox cboAccount;
        private System.Windows.Forms.TextBox txtFirst_Name;
        private System.Windows.Forms.TextBox txtLast_Name;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCreateAccount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtShippingStreetAddress;
        private System.Windows.Forms.TextBox txtCryptoWallet;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCryptoType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCreditCardNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConcealedCarry;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDriverLiscenceNum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBillingState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBillingZip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBillingCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBillingStreetAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtShippingState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShippingZip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtShippingCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.ComboBox cboInventoryFilter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlShoppingCart;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnBack;
    }
}

