using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Activity2New : Form
    {
        pos_dbconnection pos_dbconnect = new pos_dbconnection();
        Price_item_Value price_item_value = new Price_item_Value();
        dbm_variables variables = new dbm_variables();

        /*int qty_total = 0;
        double discount_totalgiven = 0;
        double discounted_total = 0;*/
        public Activity2New()
        {
            pos_dbconnect.pos_connString();
            InitializeComponent();
        }

        private void quantityTxtbox()
        {
            qtytxtbox.Clear();
            qtytxtbox.Focus();
        }

        private void quantity_price_Convert()
        {
            variables.quantity = Convert.ToInt32(qtytxtbox.Text);
            variables.price = Convert.ToDouble(pricetextbox.Text);
        }

        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) - variables.discount_amt;
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");
        }

        public void GetItemPriceValue()
        {
            itemnametxtbox.Text = (price_item_value.GetItemName());
            pricetextbox.Text = (price_item_value.GetPrice());
        }

        private void cleartextboxes()
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;
        }

        private void Activity2New_Load(object sender, EventArgs e)
        {
            try
            {
                itemnametxtbox.Enabled = false;
                pricetextbox.Enabled = false;
                discountedtxtbox.Enabled = false;
                qty_totaltxtbox.Enabled = false;
                discount_totaltxtbox.Enabled = false;
                discounted_totaltxtbox.Enabled = false;
                changetxtbox.Enabled = false;
                discounttxtbox.Enabled = false;

                picpathtxtbox1.Hide();
                picpathtxtbox2.Hide();
                picpathtxtbox3.Hide();
                picpathtxtbox4.Hide();
                picpathtxtbox5.Hide();
                picpathtxtbox6.Hide();
                picpathtxtbox7.Hide();
                picpathtxtbox8.Hide();
                picpathtxtbox9.Hide();
                picpathtxtbox10.Hide();
                picpathtxtbox11.Hide();
                picpathtxtbox12.Hide();
                picpathtxtbox13.Hide();
                picpathtxtbox14.Hide();
                picpathtxtbox15.Hide();
                picpathtxtbox16.Hide();
                picpathtxtbox17.Hide();
                picpathtxtbox18.Hide();
                picpathtxtbox19.Hide();
                picpathtxtbox20.Hide();

                pos_dbconnect.pos_select_cashier();
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterSelect();
                pos_dbconnect.pos_sqldatasetSELECT();

                name1LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                name2LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                name3LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                name4LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                name5LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                name6LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                name7LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                name8LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                name9LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                name10LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                name11LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                name12LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                name13LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                name14LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                name15LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                name16LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                name17LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                name18LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                name19LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                name20LBL.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                picpathtxtbox1.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                pictureBox1.Image = Image.FromFile(picpathtxtbox1.Text);

                picpathtxtbox2.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                pictureBox2.Image = Image.FromFile(picpathtxtbox2.Text);

                picpathtxtbox3.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                pictureBox3.Image = Image.FromFile(picpathtxtbox3.Text);

                picpathtxtbox4.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                pictureBox4.Image = Image.FromFile(picpathtxtbox4.Text);

                picpathtxtbox5.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                pictureBox5.Image = Image.FromFile(picpathtxtbox5.Text);

                picpathtxtbox6.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                pictureBox6.Image = Image.FromFile(picpathtxtbox6.Text);

                picpathtxtbox7.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                pictureBox7.Image = Image.FromFile(picpathtxtbox7.Text);

                picpathtxtbox8.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                pictureBox8.Image = Image.FromFile(picpathtxtbox8.Text);

                picpathtxtbox9.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                pictureBox9.Image = Image.FromFile(picpathtxtbox9.Text);

                picpathtxtbox10.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                pictureBox10.Image = Image.FromFile(picpathtxtbox10.Text);

                picpathtxtbox11.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                pictureBox11.Image = Image.FromFile(picpathtxtbox11.Text);

                picpathtxtbox12.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                pictureBox12.Image = Image.FromFile(picpathtxtbox12.Text);

                picpathtxtbox13.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                pictureBox13.Image = Image.FromFile(picpathtxtbox13.Text);

                picpathtxtbox14.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                pictureBox14.Image = Image.FromFile(picpathtxtbox14.Text);

                picpathtxtbox15.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                pictureBox15.Image = Image.FromFile(picpathtxtbox15.Text);

                picpathtxtbox16.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                pictureBox16.Image = Image.FromFile(picpathtxtbox16.Text);

                picpathtxtbox17.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                pictureBox17.Image = Image.FromFile(picpathtxtbox17.Text);

                picpathtxtbox18.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                pictureBox18.Image = Image.FromFile(picpathtxtbox18.Text);

                picpathtxtbox19.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                pictureBox19.Image = Image.FromFile(picpathtxtbox19.Text);

                picpathtxtbox20.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                pictureBox20.Image = Image.FromFile(picpathtxtbox20.Text);

                pricelbl1.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                pricelbl2.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                pricelbl3.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                pricelbl4.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                pricelbl5.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                pricelbl6.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                pricelbl7.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                pricelbl8.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                pricelbl9.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                pricelbl10.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                pricelbl11.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                pricelbl12.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                pricelbl13.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                pricelbl14.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                pricelbl15.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                pricelbl16.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                pricelbl17.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                pricelbl18.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                pricelbl19.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                pricelbl20.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();

                pos_dbconnect.pos_select_cashier_display();
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterSelect();
                pos_dbconnect.pos_select_cashier_SELECTdisplay();

                terminal_noLbl.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                emp_idLbl.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][0].ToString();
                emp_fnameLbl.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][1].ToString();
                emp_surnameLbl.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                DateTime datetime = DateTime.Now;
                time_dateLbl.Text = datetime.ToString("MMMM dd, yyyy");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator");
            }
            /*
            pictureBox20.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\2-pc.-Pancakes-Solo.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\6-pc.-Chicken-Nuggets.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\Amazing-Aloha-Champ-Jr.-Fries-Drink.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\Yumburger-Half-Jolly-Spaghetti-Reg.-Fries-Super-Meal-With-Drink.png");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\Jolly-Spaghetti-With-1-pc.-Burger-Steak-With-Drink.png");

            name1LBL.Text = "Burger Steak w/Drink";
            name2LBL.Text = "CJ, BS, Spag w/Drink";
            name3LBL.Text = "1pc ChickenJoy";
            name4LBL.Text = "1pc CJ w/CokeFloat";
            name5LBL.Text = "1pc Cj w/Drink";
            name6LBL.Text = "Chicken Spag";
            name7LBL.Text = "Chicken Spag w/Drink";
            name8LBL.Text = "Chicken Palabok";
            name9LBL.Text = "Bacon Cheeseburger";
            name10LBL.Text = "Double CB, Fries w/Drink";
            */
        }

        private void seniorcitizenRBTN_CheckedChanged(object sender, EventArgs e)
        {
            // declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // try-catch block to handle exceptions that may occur during the execution of the code
            try
            {
                qty = Convert.ToInt32(qtytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);

                // create a formula needed for computation
                discount_amt = (qty * price) * 0.30;
                discounted_amt = (qty * price) - discount_amt;

                // converting numeric data to string and display it inside the textboxes
                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");

                // codes for unchecking the other radio buttons in the interface once the senior citizen method executed
                withdiscRBTN.Checked = false;
                employeediscRBTN.Checked = false;
                nodiscountRBTN.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }

        private void withdiscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            try
            {
                qty = Convert.ToInt32(qtytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);

                discount_amt = (qty * price) * 0.10;
                discounted_amt = (qty * price) - discount_amt;

                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");

                seniorcitizenRBTN.Checked = false;
                employeediscRBTN.Checked = false;
                nodiscountRBTN.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }

        private void employeediscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            try
            {
                qty = Convert.ToInt32(qtytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);

                discount_amt = (qty * price) * 0.15;
                discounted_amt = (qty * price) - discount_amt;

                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");

                seniorcitizenRBTN.Checked = false;
                withdiscRBTN.Checked = false;
                employeediscRBTN.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }

        private void nodiscountRBTN_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            try
            {
                qty = Convert.ToInt32(qtytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);

                discount_amt = (qty * price) * 0;
                discounted_amt = (qty * price) - discount_amt;

                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");

                seniorcitizenRBTN.Checked = false;
                withdiscRBTN.Checked = false;
                employeediscRBTN.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                qtytxtbox.Clear();
                qtytxtbox.Focus();
            }
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            qtytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cash_renderedtxtbox.Clear();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Burger Steak w/Drink";
            pricetextbox.Text = "84";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CJ, BS, Spag w/Drink";
            pricetextbox.Text = "224";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "1pc ChickenJoy";
            pricetextbox.Text = "85";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "1pc CJ w/CokeFloat";
            pricetextbox.Text = "134";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "1pc Cj w/Drink";
            pricetextbox.Text = "105";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken Spag";
            pricetextbox.Text = "135";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken Spag w/Drink";
            pricetextbox.Text = "172";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken Palabok";
            pricetextbox.Text = "205";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Bacon Cheeseburger";
            pricetextbox.Text = "117";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Double CB, Fries w/Drink";
            pricetextbox.Text = "217";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "6pc CJ Bucket";
            pricetextbox.Text = "467";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CJ Bucket with Spag";
            pricetextbox.Text = "697";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CJ Bucket with Palabok";
            pricetextbox.Text = "927";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Family Pan";
            pricetextbox.Text = "745";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Bucket Fries";
            pricetextbox.Text = "191";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Spag, BS w/Drink";
            pricetextbox.Text = "161";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Spag, BS w/Drink";
            pricetextbox.Text = "143";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Aloha Champ Fries w/Drink";
            pricetextbox.Text = "221";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Bucket Nuggets";
            pricetextbox.Text = "119";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "2pcs Pancakes";
            pricetextbox.Text = "87";
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;

            try
            {
                qty = Convert.ToInt32(qtytxtbox.Text);
                discount_amt = Convert.ToDouble(discounttxtbox.Text);
                discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                cash_rendered = Convert.ToDouble(cash_renderedtxtbox.Text);

                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                change = cash_rendered - discounted_amt;

                qty_totaltxtbox.Text = qty_total.ToString();
                discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = discounted_total.ToString("n");
                changetxtbox.Text = change.ToString("n");
                cash_renderedtxtbox.Text = cash_rendered.ToString("n");
            }

            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty invalid");
                cash_renderedtxtbox.Clear();
                cash_renderedtxtbox.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cash_renderedtxtbox.Text += ".";
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            qtytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cash_renderedtxtbox.Clear();
        }

        private void enterBTN_Click(object sender, EventArgs e)
        {
            try 
            {
                if (seniorcitizenRBTN.Checked == true)
                {
                   //pos_dbconnect.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction)";
                }
            } catch { }
        }
    }
}
