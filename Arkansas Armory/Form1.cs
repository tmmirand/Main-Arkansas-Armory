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
        SqlDataAdapter adpt;
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2241;User ID=PROJECTS2241;Password=CN74kyu$";

        DataTable dtCustomer;

        public void refresh()
        {
            //connection.Open();
            //adpt = new SqlDataAdapter("Select * from dbo.Customer Where CustomerID=" + txtLoginCustomerID + " & ",connection);
            //adpt.Fill(dtCustomer);
            //connection.Close();


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
                string sql = "INSERT INTO dbo.Customer(Password,FirstName,LastName,ShippingStreetAddress,ShippingCity,ShippingZipcode,ShippingState,BillingStreetAddress,BillingCity,BillingZipcode,BillingState,DoB,DriversLicenseNumber,ConcealCarryStatus,CreditCardNumber,Email) VALUES (@Pass, @Fname, @Lname, @ShipStreet, @ShipCity, @ShipZip, @ShipState, @BillStreet, @BillCity, " +
                "@BillZip, @BillState, @DoB, @DLNum, @CCStatus, @CCNUmber,@Email)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Fname", txtFirst_Name.Text);
                command.Parameters.AddWithValue("@Lname", txtLast_Name.Text);
                command.Parameters.AddWithValue("@Pass", txtPassword.Text);
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
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                answer = command.ExecuteNonQuery();



                int Count;
                string sqlcount = "SELECT COUNT(CustomerID) FROM Customer";
                SqlDataReader datareader;
                command = new SqlCommand(sqlcount, connection);
                datareader = command.ExecuteReader();
                //while (datareader.Read())
                //{
                 //   int Count = datareader.Depth;
               // }
                
                datareader.Close();
                MessageBox.Show("You have successfully entered " + answer + " into the database. Your Customer ID is " + Count + "");
                connection.Close();
                command.Dispose();

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
            pnlOrders.Visible = false;

           
            txtLoginPassword.Text = "Guest";
            txtLoginCustomerID.Text = "1";
            

            refresh();

            
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            pnlCreateAccount.Visible = true;
            pnlCreateAccount.Location = new Point(0, 0);
            pnlCreateAccount.BringToFront();
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            pnlShoppingCart.Visible = true;
            pnlShoppingCart.Location = new Point(0, 0);
            pnlShoppingCart.BringToFront();

           // var da = new SqlDataAdapter(sql, connectionstring);
          //  var ds = new DataSet();
           // da.Fill(ds);
           // dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlCreateAccount.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.BringToFront();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrdersMainMenu_Click(object sender, EventArgs e)
        {
            pnlOrders.Visible = false;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlOrders.Visible = true;
            pnlOrders.Location = new Point(0, 0);
            pnlOrders.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FNs 509 pistol is built on the proven architecture of the FNS Compact. It features a cold hammer-forged stainless-steel barrel with a recessed target crown and polished chamber and feed ramp. The polymer frame has an enhanced grip texture for faster follow-up shots in all conditions a MIL-STD-1913 accessory rail and interchangeable backstraps. This striker-fired double action pistol has an external extractor loaded chamber indicator and no manual safety. It is equipped with a fully ambidextrous slide stop lever and magazine release. This FN 509 Tactical model has a Flat Dark Earth slide with an FDE polymer gripframe two FDE interchangeable backstraps and suppressor height night sights. This model comes with one (1) 17-round magazine two (2) 24-round magazines and a FN logo soft pistol case.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The new Spec Series Kit from Smith & Wesson includes an M&P9 M2.0 optics-ready Spec Series pistol, an M&P single-edge, spear point knife, and a M&P Spec Series challenge coin. The M&P M2.0 OR Spec Series pistol features a 4.6 threaded barrel, suppressor height night sights, an optics-ready slide and a Crimson Trace CTS-1500 red dot optic. The M&P Boot Knife features a full tang, fixed blade with black oxide finish and comes with a molded nylon sheath. The Coin has a 3D, high relief sculpted design and is made of a solid nickel metal with antique finish & hard baked enamel. It comes with a clear acrylic capsule.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manufactured from 1995 to 2010 the Glock G19 Gen 3 is a semi-automatic handgun with a polymer frame chambered in 9mm with a 151 capacity.\n This generation of the G19 saw modifications that included frontstraps with molded finger grooves thumb rests and an integrated forward accessory rail for easy mounting of laser sights tactical lights and other accessories. \n Additional upgrades to the Glock 19 Gen 3 also included a modified extractor that doubled as a loaded chamber indicator an enlarged locking block and an extra cross pin.\n Details - Black polymer frame matte black finish. Fixed sights. Includes (2) magazines. 9mm 10rd 4.\n Manufactured from 1995 to 2010 the Glock G19 Gen 3 is a semi-automatic handgun with a polymer frame chambered in 9mm with a 151 capacity.\n This generation of the G19 saw modifications that included frontstraps with molded finger grooves thumb rests and an integrated forward accessory rail for easy mounting of laser sights tactical lights and other accessories. \n Additional upgrades to the Glock 19 Gen 3 also included a modified extractor that doubled as a loaded chamber indicator an enlarged locking block and an extra cross pin.\n Details - Black polymer frame matte black finish. Fixed sights. Includes (2) magazines. 9mm 10rd 4.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Glock 19 Gen4 pistol in 9mm offers incredible firepower alongside quick shooting and accuracy. It is ideal for a more versatile role due to its reduced dimensions but does not sacrifice all-important magazine capacity. The modular backstrap system makes it possible to instantly customize the grip to accommodate any hand size. The reversible magazine catch makes it ideal for left and right-handed shooters. \n\n SELLER DESCRIPTION \n The Glock 19 is one of the most widely used handguns in the world and is a favorite among militaries, law enforcement agencies, and private citizens. It makes an excellent duty sidearm or self-defense weapon. This G19 Gen 4 includes the original case and one 15-round magazine.");
        }


        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The P365 redefined what a concealed-carry pistol should be. Now, the new P365 XL ROMEOZERO is doing it again. The perfect balance of micro-compact concealability with full-size shootability, the P365 XL ROMEOZERO packs 12 + 1 or available 15 + 1 capacity in a micro-compact, highly concealable size. Sight radius is improved with an extended 3.7\" slide and barrel, and the new 365 XSeries grip module ensures a more comfortable grip and boasts an integrated magwell. These features, along with the signature XSeries flat trigger, all come standard with a ROMEOZERO 3 MOA optic installed and ready to go right out of the box. The P365XL ROMEOZERO maintains the crisp, clean P365 trigger pull that compliments the inherent accuracy improvement of a red dot-equipped pistol. Never has so much versatility and capability been squeezed into such a perfectly concealable size.");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made in the United States the Hi-Point 916 is a single stack compact semi-automatic pistol chambered in 9mm and rated for P ammo. With a 3.5 barrel and adorned with adjustable three dot sights the polymer framed 916 weighs 29 ounces. Locking open after the last round the Hi-Point 916 also includes a durable easy-grip finish to lock in your hold on this pistol. \n\n Details \n\n Caliber 9mm - Capacity 8rds - Barrel 3.5 - Sights 3-Dot Fully Adjustable Rear - Action Striker Fired - Frame Black Polymer - Slide Black Powder Coated - Grips Black Synthetic - Length 6.75 - Weight 29 oz - Additional Features - Durable attractive easy-grip finish - Last round lock open - Quick on-off thumb safety - Operations safety sheet - P rated - Free extra rear peep sight - Free trigger lock - Lifetime warranty - 100 American-made parts and assembly");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The new frame design of the Glock G17 Gen 5 removed the finger grooves for more versatility but still allows to easily customize its grip by using the different back straps. A flared mag-well and a cutout at the front of the frame give the user more speed during reloading when fractions of a second matter. A reversible enlarged magazine catch, changeable at user level as well as the ambidextrous slide stop lever accommodate left and right-handed operators. \n\n The rifling and the crown of the barrel were slightly modified for increased precision.");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Kimber Stainless II is a single-action semi-automatic pistol chambered in .45 ACP with a 7-plus-1 round capacity. A 5-inch match grade barrel is adorned with Kimber dovetail sights. Both the hammer and trigger of the Stainless II are skeletonized, allowing for quicker follow-up shots. Checkered rosewood grips work with the lined mainspring housing to ensure users have a firm grasp with each shot fired. \n A dependable and enduring personal protection pistol, The Stainless II from Kimber is a dependable and enduring personal protection pistol.");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Because you can never be too prepared, this Ruger SP101 offers larger-caliber protection in a smaller-framed revolver. Rugged and dependable, this double-action revolver was created with personal protection in mind and constructed with a solid stainless steel frame, while tool-free disassembly and reassembly make for easy maintenance. The cushioned rubber of the peg-style grip frame ensures no metal is exposed in the backstrap, offering comfort and control. The triple-locking cylinder aids in positive alignment for lasting, dependable operation, round after round. Whether for home or personal defense, in the field, or in the woods, the SP101 is a trusted and reliable revolver.");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compact sleek and ergonomic the MP BODYGUARD 380 delivers personal protection in an easy-to-carry comfortable platform. Chambered for .380 ACP the lightweight pistol features a high-strength polymer frame with a black matte-coated stainless-steel slide and barrel. The new MP BODYGUARD 380 retains original design features including a 2 -inch barrel which contributes to an overall length of 5 inches and an unloaded weight of only 12.3 ounces making it perfectly suited for concealed carry. - Features - Custom machine engraved - Matte silver slide - Caliber .380 Auto - Capacity 61 - Safety Thumb Safety - Barrel Length 2.75 6.9 cm - Overall Length 5.3 - Front Sight Stainless Steel Drift Adjustable - Rear Sight Stainless Steel Drift Adjustable - Action Double Action Only - Grip Polymer - Weight 12.0 oz 340.2g - Barrel Material Stainless Steel - Slide Material Stainless Steel - Frame Material Polymer - Purpose Concealed Carry Enthusiast");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The new standard for Discreet Carry - a folding, single-shot .22WMR pistol that's no bigger than a stack of credit cards. At .5 inches thin and weighing less than 7 ounces, LifeCard will be the last gun you'll leave behind.");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The CZ-USA Scorpion Evo 3 S1 is a semi-automatic handgun variant of the well-known CZ Scorpion sub-machinegun. Ever since Scorpion’s were brought to the civilian market, they have been incredibly popular in the U.S., and rightfully so, they are fantastic firearms through and through. \n\nThat said, we decided to take this Scorpion pistol and turn it up a notch. \n\n With this purchase you will receive a Trijicon RMR (RM01C 3.2 MOA), a Magpul angled foregrip, and an extra 30 round CZ windowed magazine – a value of over $2,000 MSRP.");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A semi-auto handgun modeled after the popular P365 but boasting a larger capacity, this P365 XL by Sig Sauer is well-suited for self-defense. The perfect combination of concealment and shootability, this pistol is built with a longer slide, barrel, and grip to accommodate the larger capacity. The longer barrel additionally aids in better target acquisition, while other features of the P365 XL include an extended beavertail, integrated carry magwell, flat trigger, and an optics-ready slide.");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lightweight. Easy to conceal. Exceptionally reliable. The Taurus Defender 856 is finely tuned to deliver the ultimate peace of mind for home and personal defense situations. It comes with night sights and special Hogue Rubber grips.");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Century Centurion BP-12 12 Gauge 19.75\" 5+1 Black Black Fixed Bullpup Stock");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Browning B-S/S \n 20 Gauge, 28\" Blued Mod Full, Single Select Trigger, English Stock, Beavertail Forend, No box");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Pistol Grip GF3T from GForce Arms features a 19.5\" barrel with a chamber capable of firing 2-3/4\" & 3\" shells. Other features include Ghost Ring sights, a pistol grip, and a top rail for optics mounting. \n\n Pump-action shotguns are widely regarded for their flexible, simple, and reliable design. Making this an excellent option for home-defense or general-purpose use. \n\n ATTN: This model DOES NOT shoot slugs.");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Kel-Tec KSG is a semi-automatic 12-gauge shotgun with a 121 capacity in 3 shells. An 18.5 smooth bore barrel is fed from a dual-tube system allowing users to change projectiles at the flick of a switch. A downward ejection system makes the KSG a truly ambidextrous shotgun while a pair of picatinny rail allows users to attach the accessories of their choice. \n\n Details \n\n Kel-Tec KSGGRN KSG Pump 12 ga 18.5 3 121 Syn Green Stk Green");

        }

        private void button46_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Benelli M4 is a well-renowned tactical shotgun with a reputation for its ruggedness and reliability. So reliable that it has been used by the United States Marine Corps since 1998. The M4 utilizes the A.R.G.O (auto-regulated gas-operation) gas system, a unique system that uses two stainless steel, self-cleaning pistons that that bear directly on the bolt assembly. This brilliantly simple, ultra-reliable action eliminates complex mechanics found in many comparable semi-automatic shotguns that tend to foul up faster and are more difficult to clean. This means the A.G.R.O system allows the Benelli M4 the reliably cycle nearly any type of 3\" shell without having to make adjustments, from the heavy 00 buckshot to light field loads. The stock is made from a durable poly/rubber material and is available in the typical shotgun stock design as well as a pistol grip version. Both versions come with a receiver mounted picatinny rail for the installation of an optic and a sling mount for an ambidextrous shoulder sling. With its reliable A.R.G.O gas operating system and its ability to cycle almost any type of 3\" shell, the Benelli M4 has a multitude of applications ranging from home defense, protection in Grizzly bear territory or law enforcement/military usage.");

        }

        private void button44_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silver Eagle TAC-LC is new for 2020! AR Style, 12 ga, gas operated semi auto shotgun featuring a 3? chamber, 19.5? smooth bore barrel, door breacher style muzzle brake, polymer fore end with picatinny rail sections, pistol grip butt stock, rear sight/carry handle, and two magazines (2-and 5- shell). The two piece fore end is easily removed for quick and easy access for cleaning.");

        }

        private void button50_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Remington 870 Express synthetic pump shotguns have non-binding twin action bars for smooth, easy operation. Strong lock-up of breech bolt lug in to a massive barrel extension. Features a non-reflective matte black synthetic stock.");

        }

        private void button48_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Mossberg 590 Shockwave is a firearm intended for self-defense. It shares the Mossberg 590s features including ambidextrous tang safety dual extractors positive steel-to-steel lockup twin action bars and anti-jam elevator. The pump action 590 Shockwave sports a heavy-walled matte blued 14 barrel Shockwave Raptor birds head-style recoil minimizing pistol grip protective forend strap front bead sight and clean-out tube magazine cap. \n\n Details \n\n Gauge 12 - Capacity 5+1 - Barrel Type Heavy-Walled - Barrel Length 14\" - Sight Bead - Choke Cylinder Bore - Barrel Finish Matte Blued - Weight 5.25 Lbs. - Length 26.37\"");

        }

        private void button54_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mossberg 590SP Tactical features dual extractors, positive steel-to-steel lockup, twin action bars and an anti-jam elevator ensure smooth operation. Top mounted safety provides for ambidextrous operation. Additional special features include tri-railed forends to facilitate accessory lights and lasers, adjustable stocks for rapid adjustment of length of pull.");

        }

        private void button52_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Great for home defense, the Benelli M2 Tactical is a semi automatic shotgun chambered in 12GA and features an 18.5 inch barrel Ghost ring front sight pistol grip and black synthetic stock.");

        }

        private void button56_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IWIs Tavor TS12 shotgun features an adjustable gas regulator 4140 steel barrel with BerettaBenelli MultiChoke threads and is chrome lined. Additional features of the TS12 include four sling attachment points MLOK compatible rails a continuous accessory rail on top and a synthetic bullpup stock.");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The VRF14 is the first semi-automatic short barrel firearm of its kind. It boasts a familiar pistol-style grip so you can shoot 12 Gauge shells from the hip. And if the 5-round magazine isn't enough, its also compatible with VR-Series 9- and 19-round mags.");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An evolution of CZ's wildly popular Ringneck the Sharp-Tail is an entirely new action. Much smaller overall it now features coil springs instead of leaf springs and sports the same color case-hardened finish. With a single selectable mechanical trigger and pistol grip the Sharp-Tail is one the sharpest-looking side-by-sides on the market. Updated with new technology the one-piece CNC'ed receiver now has independent floating firing pins coil spring operated hammers and newly designed sears. This all equates to longer life and greater consistency. FEATURES: Color Case Hardened Receiver Finish; Gloss Black Barrel Finish; Mechanical Single Selectable Trigger; Turkish Walnut FINISH: BLACK");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Stoeger Coach Gun Double Trigger is a family of double trigger side-by-side shotguns. 20” barrels are adorned with a brass bead front sight and are equipped with extractors for easier reloading. An improved cylinder and modified chokes are included to allow users to select their shot pattern. The Coach Gun Double Trigger’s walnut furniture is checkered at the forend and grip, while a recoil pad reduces abuse to users’ shoulders.");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stoeger's new Double Defense side-by-side shotgun is a straightforward, rugged and reliable home defense shotgun. Ideal for use in tight quarters and tense situations, the Stoeger Double Defense with its traditional break-action and short, efficient design is easy to load and quick to deploy in an emergency. \n A double-barrel shotgun has been the defensive firearm of choice for generations, but Stoeger has added practical, up-to-date features to the \"tried - and - true\" double gun. The Double Defense is chambered for 2-3/4- and 3-inch shells, in either 12- or 20-gauge. The tactical-length 20-inch ported barrels feature fixed, improved cylinder chokes. The fast, single-trigger design and convenient, tang-mounted automatic safety makes the Stoeger Double Defense ideal for home security use. \n The Double Defense gun is outfitted with a green, fiber-optic front sight and comes standard with two Picatinny Rail accessory mounts: one on the receiver for red-dot sights and a second factory-installed rail under the barrels for attaching targeting lasers or tactical lights. All metal surfaces are finished in matte blue and come complete with non-reflective matte black hardwood stock and forearm.");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The MKA1919 Match is a gas operated semiauto shotgun with 7075T6 aluminum receiver polymer stock and handguard and a 4140 steel barrel with three choke tubes F C M.");
        }

        private void button68_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Charles Daly AR12s is a semi automatic AR-style shotgun chambered in 12GA. The AR12s features 3\" chambers and an 18.9\" barrel.");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Radikal NK-1 is a Bullpup 12 gauge magazine fed shotgun. It features a 19\" barrel, back up sights, angled grip and an adjustable cheek riser.");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Radikal MKX is an AR style 12 gauge mag fed shotgun with a 19\" barrel and includes two 5 - round mags, back up sights, and a choke kit.");
        }

        private void button74_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The BPX 902 Shotgun is gas operated and features 18.50\" with 3 chokes.It also has a bullpup stock, folding front & rear sights, sling swivel, and comes with two 5 - round and one 2 - round magazines.");
        }

        private void button76_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed to be used with a suppressor this oneofakind rifle allows you to combine signature reduction capabilities with the flawless reliability of the original Barrett M107 but with a rifle weight reduction of 5 pounds. An all new bolt carrier group has been designed and is key to making the rifle suppressor ready. Its steel four port cylindrical muzzle brake is engineered to work seamlessly with a quick attach Barrett QDL Suppressor. The lightweight aluminum upper receiver features an integrated 27 MOA optics rail. Inside the upper receiver the bolt carrier rides on a hardened steel anti wear strip for added durability. A thermalguard cheek piece protects the users face from extreme heat or cold. The rear barrel stop and front barrel bushing are bolted and bonded with a high strength compound. A titanium barrel key and fullychromelined bore and chamber add to the rifles durability. The newly designed titanium and polymer monopod is adjustable from either side. The M107A1 rifles lower receiver includes an aluminum recoil buffer system thats optimized for use with the Barrett QDL Suppressor. The bolt carriers components are protected with a mix of ultra hard coatings and advanced nickel Teflon plating that increases lubricity is corrosion resistant and greatly eases cleaning. Numbered witness holes on the magazine are just another example of how even the smallest detail makes a powerful difference.");
        }

        private void button78_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This KRISS Vector Gen II CRB is a pistol caliber carbine ideal for recreational use and competition. The innovative nonlinear operating system and low bore axis aid in significantly reduced recoil. This rifle is made with an M4-style adjustable stock, chrome-lined barrel, flip-up sights, and ergonomic controls, while the cerakote finish offers superior corrosion resistance. Dual Picatinny rails make the addition of optics and accessories quick and easy, and, like all KRISS Vector models, this rifle is compatible with full-size Glock magazines. \n - CALIBER 10MM \n - MAGAZINE (1) 15rd capacity \n - BARREL 16\" 4140 Chrome Moly, Enhanced barrel shroud \n - RECEIVER Polymer Composite \n - SIGHTS Low Profile Folding \n - TRIGGER Audible / Tactile Reset \n - STOCK 6 - Postion DEFIANCE M4");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Pioneer AKM style firearms are build form 100% new parts produced in their plant in Radom, Poland. 7.62x39 Sporter AKM style rifle.");
        }

        private void button82_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The GSG16 22lr Rifle is a light weight tactical style rifle based off of the classic GSG 22 caliber rifle operating system. The GSG16 features a collapsible stock also serves as an additional magazine storage compartment for either high or low capacity magazines. The redesigned forend features standard picatinny rails mounted onto an MLOK style hand guard. The cocking tube assembly features an ambidextrous charging handle so you can switch up charging rounds to meet your comfort style. The redesigned front and rear sight have been simplified and streamlined to give the shooter faster target acquisition over previous GSG models.");
        }

        private void button84_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The M4-22 ELITE is a premium .22 caliber semi-automatic tactical rimfire rifle with aluminum upper and lower receivers and all the features of a true M4. The M4-22 is largely mil-spec compatible and will accept most AR15 stocks, handguards and sights. The M4-22 has the look, feel and controls of a true M4 and is a perfect platform for competition and training applications or backyard plinking.");
        }

        private void button86_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Revolution is POFs 308 that handles like a 5.56 because it is the same size and weight as one by using a 5.56 bolt carrier and other 5.56 parts allowing for a shorter overall receiver size and reduced weight. The Revolution features many 5.56 parts such as charging handle bolt carrier cam pin buffer heat sink barrel nut handguard and 5position gas piston operating system. The barrel extension bolt assembly upper and lower receiver are the exact same size as those on an AR15. This 6.5 Creedmoor model is built on the Gen 4 lower receiver with a burnt bronze metal finish a 14.5 MLok MRR freefloat handguard and POFs standard 4.5 lb. dropin trigger.");
        }

        private void button88_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The ZRO Delta Base is an AR-15 pattern rifle that is rugged, dependable, and cost effective. This model is equipped with a Mission First Tactical minimalist stock, free float M-LOK handguard, and a standard A2 birdcage flash hider. Whether you’re a new shooter or a seasoned pro, this rifle will serve you well.");
        }

        private void button90_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Battle Arms Workhorse series of firearms are built for duty and hard use in mind. It is purpose-built around the forged BAD-15 7075-T6 aircraft-grade aluminum receiver and free-float rail handguard with M-LOK attachment point at 3, 6, and 9 o'clock positions. At 12 o'clock is a full-length Picatinny accessory rail with our signature notch cut matching the upper receiver. Every firearm is equipped with a 4150 chrome-moly steel black nitride barrel for durability and accuracy. Each barrel is individually head-spaced with matching 9130 steel bolt and 8620 black nitride carrier for ultimate reliability and ease of cleaning. Rifle models utilize a mid-length gas system for reliable and smooth cycling action while reducing recoil and minimizing wear.");
        }

        private void button92_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rock River Arms was founded in 1996 and originally manufactured hand fitted custom 1911's. Shortly after their founding they started producing AR-15 pattern rifles. Over the decades they have grown immensely popular thanks to their dedication to peak performance and high-quality manufacturing. \n\n They currently produce rifles for the DEA (Drug Enforcement Agency), FBI, several private military corporations, and countless law enforcement agencies. \n\n SELLER DESCRIPTION \n For sale is a Rock River Arms LAR-15 chambered in 5.56 NATO. Accurate, well-made, dependable, and durable, if you're looking for a tac-driver AR-15, this RRA is an excellent option. This model is a law enforcement trade-in. It has a Daniel Defense quad rail, ergo grip, and flip-up sights. Overall, it is in good condition, with the finish scratched. There is no magazine included in this package.");
        }

        private void button94_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Born from the ashes of WWII, the CETME design group was established in Spain, and staffed by many Mauser employees like Dr. Ludwig Vorgrimler, who brought their research and designs with them. They would later develop and adopt the CETME C, better known to American shooters and collectors under its German licensed designation: the G3 / HK91 in 7.62x51 / .308. \n\n Faced with the transition by militaries to the 5.56 in the 1970s, and with their pending entrance into NATO, Spain and CETME began in earnest to develop a 5.56 rifle for their military. The result was the last roller-locking rifle to be adopted by any military, and the first and only one specifically designed for the 5.56/.223 from the ground up, the CETME L.");
        }

        private void button96_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chambered for the AK-47 7.62x39 round, the WASR Rifle from Century Arms International is incredibly sturdy and durable. Weighing in at only 6.9 pounds, this rifle is comfortable to carry on those missions to the unknown. Be it in the field, at the range or a Special Ops mission.");
        }

        private void button98_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perfectly calibrated for long-range precision fire, the FN SCAR 20S gives you the ability to engage targets up to 1,000 meters. The 1:10\" twist rate chrome - lined barrel delivers precision accuracy with heavier long range projectiles popular with serious shooters.The gas - operated piston design and Surefire ProComp 762 muzzle device manage recoil efficiently, speeding follow - up shots and maintaining target acquisition.Lending further aid is the Geissele two - stage trigger that breaks crisply at 3.5 - 4.5 pounds, full - length MIL - STD 1913 rail at 12 oclock position and fixed buttstock providing adaptability to fit to each users needs through adjustable length of pull and cheek rest height.");
        }

        private void button100_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Like the 7.62 FN SCAR 20S, the rifle features an extended monolithic receiver with ample space to mount optics, Geissele Super SCAR trigger with an average of 4lb. trigger pull, FN MK 20 SSR precision stock that is adjustable for length of pull and comb height, as well as the Hogue grip. Both the FN SCAR 20S in 7.62 and 6.5 Creedmoor accept the 10rd FN SCAR 17S magazines.");
        }

        private void button104_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Colt M4 Carbine CR6920 is a semi-automatic variant of the legendary military issue M4 Carbine. It delivers the same reliability, accuracy, and performance as its combat-proven brother, all offered in a civilian version. This CR6920 sports a B5 adjustable stock, BCM lightweight quad rail with covers, 16\" barrel with 1 / 7 twist, and a flip - up rear sight.Purchase includes the owner's manual and one 30-round magazine.");
        }

        private void button106_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The iconic bullpup-style Steyr AUG has been one of the most recognizable rifles in the world since its adoption by the Austrian army in 1977 and is now available for civilian use as the Steyr AUG A3 M1. The short-stroke gas-piston operation of the AUG runs exceptionally cleaner by nature because all of the operational exhaust gas vents out of the front of the rifle. The AUG A3 M1 has all the classic features and benefits that established it as the pinnacle of modern rifle design. It also features a quick-change barrel with a collapsible forward grip as well as a two-position cross-bolt safety that locks the trigger. This firearm is chambered in 223 Rem/5.56 NATO, has a 16\" barrel with a black metal finish, a black synthetic stock, and has a extended rail for optics.");
        }

        private void button108_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The M&P15-22 SPORT features a 10-inch M&P slim handguard that incorporates the popular Magpul M-LOK system. The M-LOK system allows rifle owners to easily customize their M&P15-22 SPORT by adding accessories without removing the handguard. It comes with removable Magpul MBUS front and rear folding sights are lightweight and durable, further enhancing the performance and value of the M&P15-22 SPORT.");
        }

        private void button110_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Smith Wesson MP15 is an AR-style gas-operated semi-automatic rifle designed with military and police as well as personal use in mind. It is chambered in 5.56mm NATO.223 Remington 22 LR and 5.4539mm with an aluminum receiver with hard-coat black anodized finish and either melonite- or chrome-lined barrel. It features a integral trigger guard 6-position telescoping butt stock and adjustable sights. The MP15 is compatible with most standard AR-15 mil-spec components and accessories.");
        }

        private void button114_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Bird Dog Armory BD-15 is an Armalite pattern rifle that offers enhanced performance at a price point that’s hard to match. \n\n The notable features of this rifle include a 16” match grade stainless-steel Cerakoted barrel, Mid-Length gas system, Salt Bath Nitrited BCG (bolt carrier group), Free-float 15” handguard with Picatinny and M-LOK rail areas, a Thril CCS adjustable stock, Ergo pistol grip, tuned Mil-Spec trigger, and an Ambi-safety. \n\n The AR-15 may be the most common rifle pattern on the market, but it doesn’t mean they are all created equal. Pick up a Bird Dog Armory BD-15 today and understand the difference for yourself. \n\n 1-30 round Thril PMX magazine is included with this purchase.");
        }

        private void button118_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Ruger Precision Rifle was built for long-range accuracy and to distance itself from the competition. This bolt-action rifle boasts a solidly constructed upper receiver and one-piece bolt, both of which are precision machined from pre-hardened chrome-moly steel, while the lower magazine well halves are machined from aerospace-grade aluminum and hard coat anodized for increased durability. The cold hammer-forged barrel is made of chrome-moly steel, and a Picatinny rail is ready for your favorite optics and accessories. The Hybrid Muzzle Brake effectively reduces recoil and minimizes noise for the user.");
        }

        private void button116_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Sig Cross was designed and built from the ground up at the Sig Sauer research and development facilities in New Hampshire with the input of hunters, military snipers and elite long-range shooters. The Cross rifle was created to meet the demands of both precision long-range shooting and extreme back country hunting. The rifle features the lightest, most portable rifle in its class, folding precision-style stock, one piece receiver for increased accuracy, 2 Stage adjustable match trigger and a free floating M-LOK handguard. Designed and built in the USA.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=essql1.walton.uark.edu; Initial Catalog=PROJECTS2241; User ID=PROJECTS2241; Password=CN74kyu$;";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();

            //I think we need to use a data reader here and display the result in the hidden text box.
            
                command = new SqlCommand("Select FROM dbo.Customer(CustomerID) WHERE Username=@Username,Password=@Password", cnn);
                command.Parameters.AddWithValue("@Username",txtLoginCustomerID.Text);
                command.Parameters.AddWithValue("@Password", txtLoginPassword.Text);


           
                //MessageBox.Show("Incorrect Login!");

               

            


           // MessageBox.Show("Connection Open!");
            cnn.Close();
           // pnlLogin.Visible = false;
            
          
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
                    {
                Handguns.Visible = false;
                    }
            else
            {
                Handguns.Visible = true;
                Handguns.Location = new Point(105, 154);
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pnlShoppingCart.Visible = false; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false)
            {
                gboShotguns.Visible = false;
            }
            else
            {
                gboShotguns.Visible = true;
                gboShotguns.Location = new Point(105, 154);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            connection = new SqlConnection(connectionstring);
            connection.Open();
            int answer;
            string sql = "INSERT INTO ShoppingCart VALUES (@CustomerID, 3)";
            command = new SqlCommand(sql, connection);
            //These @Name command parameters reference the @name insert into statement above
            command.Parameters.AddWithValue("@CustomerID", txtLoginCustomerID.Text);

            answer = command.ExecuteNonQuery();
            MessageBox.Show("Successfully added Gun to cart");
            connection.Close();
            command.Dispose();


        }
    }
}
