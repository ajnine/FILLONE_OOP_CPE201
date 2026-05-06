using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Activity2New_Function : Form
    {
        int qty_total = 0;
        double discount_totalgiven = 0;
        double discounted_total = 0;

        int qty = 0;
        double price = 0;
        double discounted_amt = 0;
        double discount_amt = 0;
        public Activity2New_Function()
        {
            InitializeComponent();
        }

        //function method for clearing the quantity textbox and placing the cursor inside it
        private void quantityTxtbox()
        {
            qtytxtbox.Clear();
            qtytxtbox.Focus();
        }

        // function method for converting quantity and price input from a string to a numer value
        private void quantity_price_Convert()
        {
            qty = Convert.ToInt32(qtytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
        }

        // function method for the formula needed in the program's computations
        private void computation_formula_and_displaydata()
        {
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
        }

        // function with a return value for the item name and price textboxes 
        public void price_item_textvalue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = price;
        }
        private void Activity2New_Function_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

            pictureBox20.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\School\\OOP\\jollibee menu\\2-pc.-Pancakes-Solo.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\School\\OOP\\jollibee menu\\6-pc.-Chicken-Nuggets.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\School\\OOP\\jollibee menu\\Amazing-Aloha-Champ-Jr.-Fries-Drink.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\School\\OOP\\jollibee menu\\Yumburger-Half-Jolly-Spaghetti-Reg.-Fries-Super-Meal-With-Drink.png");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\School\\OOP\\jollibee menu\\Jolly-Spaghetti-With-1-pc.-Burger-Steak-With-Drink.png");

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
        }

        private void seniorcitizenRBTN_CheckedChanged(object sender, EventArgs e)
        {
            /*int qty;
            double price, discount_amt, discounted_amt;*/
            // convert
            try
            {
                //access the function with methods to convert string inputs to numeric values from the quantity and price textboxes
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;

                // access the function with methods for the computation formula of the program and display the computed output
                computation_formula_and_displaydata();

                // codes for unchecking the other radio buttons in the interface
                withdiscRBTN.Enabled = false;
                employeediscRBTN.Enabled = false;
                nodiscountRBTN.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                // acces the function with methods for clearing the quantity textbox and placing the cursor inside it
                quantityTxtbox();
            }
        }

        private void withdiscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            /*int qty;
            double price, discount_amt, discounted_amt;*/

            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.10;

                computation_formula_and_displaydata();

                seniorcitizenRBTN.Enabled = false;
                employeediscRBTN.Enabled = false;
                nodiscountRBTN.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void employeediscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            /*int qty;
            double price, discount_amt, discounted_amt;*/

            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.15;

                computation_formula_and_displaydata();

                seniorcitizenRBTN.Enabled = false;
                withdiscRBTN.Enabled = false;
                nodiscountRBTN.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantityTxtbox();
            }
        }

        private void nodiscountRBTN_CheckedChanged(object sender, EventArgs e)
        {
            /*int qty;
            double price, discount_amt, discounted_amt;*/

            try
            {
                quantity_price_Convert();

                discount_amt = (qty * price) * 0;

                computation_formula_and_displaydata();

                seniorcitizenRBTN.Enabled = false;
                withdiscRBTN.Enabled = false;
                employeediscRBTN.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input in quantity");
                quantityTxtbox();
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
            // accessing a function with an assigned return value for the text property of the price and item name textboxes
            price_item_textvalue("Burger Steak w/Drink", "84");
            /*(itemnametxtbox.Text = "Burger Steak w/Drink;
            pricetextbox.Text = "84";*/

            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // accessing a function with an assigned return value for the text property of the price and item name textboxes
            price_item_textvalue("CJ, BS, Spag w/Drink", "224");
            /*itemnametxtbox.Text = "CJ, BS, Spag w/Drink";
            pricetextbox.Text = "224";*/

            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // accessing a function with an assigned return value for the text property of the price and item name textboxes
            price_item_textvalue("1pc ChickenJoy", "85");
            /*itemnametxtbox.Text = "1pc ChickenJoy";
            pricetextbox.Text = "85";*/

            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_textvalue("1pc CJ w/CokeFloat", "134");
            /*itemnametxtbox.Text = "1pc CJ w/CokeFloat";
            pricetextbox.Text = "134";*/

            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_textvalue("1pc Cj w/Drink", "105");
            /*itemnametxtbox.Text = "1pc Cj w/Drink";
            pricetextbox.Text = "105";*/

            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Chicken Spag", "135");
            /*itemnametxtbox.Text = "Chicken Spag";
            pricetextbox.Text = "135";*/

            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Chicken Spag w/Drink", "172");
            /*itemnametxtbox.Text = "Chicken Spag w/Drink";
            pricetextbox.Text = "172";*/

            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Chicken Palabok", "205");
            /*itemnametxtbox.Text = "Chicken Palabok";
            pricetextbox.Text = "205";*/

            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Bacon Cheeseburger", "117");
            /*itemnametxtbox.Text = "Bacon Cheeseburger";
            pricetextbox.Text = "117";*/

            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Double CB, Fries w/Drink", "217");
            /*itemnametxtbox.Text = "Double CB, Fries w/Drink";
            pricetextbox.Text = "217";*/

            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_textvalue("6pc CJ Bucket", "467");
            /*itemnametxtbox.Text = "6pc CJ Bucket";
            pricetextbox.Text = "467";*/

            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_textvalue("CJ Bucket with Spag", "697");
            /*itemnametxtbox.Text = "CJ Bucket with Spag";
            pricetextbox.Text = "697";*/

            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_textvalue("CJ Bucket with Palabok", "927");
            /*itemnametxtbox.Text = "CJ Bucket with Palabok";
            pricetextbox.Text = "927";*/

            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Family Pan", "745");
            /*itemnametxtbox.Text = "Family Pan";
            pricetextbox.Text = "745";*/

            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Bucket Fries", "191");
            /*temnametxtbox.Text = "Bucket Fries";
            pricetextbox.Text = "191";*/

            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Spag, BS w/Drink", "161");
            /*itemnametxtbox.Text = "Spag, BS w/Drink";
            pricetextbox.Text = "161";*/

            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Spag, BS w/Drink", "143");
            /*itemnametxtbox.Text = "Spag, BS w/Drink";
            pricetextbox.Text = "143";*/

            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Aloha Champ Fries w/Drink", "221");
            /*itemnametxtbox.Text = "Aloha Champ Fries w/Drink";
            pricetextbox.Text = "221";*/

            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_textvalue("Bucket Nuggets", "119");
            /*itemnametxtbox.Text = "Bucket Nuggets";
             pricetextbox.Text = "119";*/

            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_textvalue("2pcs Pancakes", "87");
            /*itemnametxtbox.Text = "2pcs Pancakes";
            pricetextbox.Text = "87";*/

            quantityTxtbox();
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

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
    }
}
