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
    public partial class Activity2New_Class : Form
    {
        int qty_total = 0;
        double discount_totalgiven = 0;
        double discounted_total = 0;

        int qty = 0;
        double price = 0;
        double discounted_amt = 0;
        double discount_amt = 0;
        public Activity2New_Class()
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
            variables.quantity = Convert.ToInt32(qtytxtbox.Text);
            variables.price = Convert.ToDouble(pricetextbox.Text);
        }

        // function with a return value for the item name and price textboxes 
        public void price_item_textvalue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = price;
        }

        // codes for accessing the class created
        Price_item_Value price_Item_Value = new Price_item_Value();
        Variables variables = new Variables();

        // function methods for the formulas needed in the program's computations
        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) - variables.discount_amt;
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");
        }

        // function with return value for item name and price textboxes
        public void GetPriceItemValue()
        {
            itemnametxtbox.Text = (price_Item_Value.GetItemName());
            pricetextbox.Text = (price_Item_Value.GetPrice());
        }

        private void Activity2New_Class_Load(object sender, EventArgs e)
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

        private void calculateBTN_Click(object sender, EventArgs e)
        {

            try
            {
                variables.quantity = Convert.ToInt32(qtytxtbox.Text);
                variables.discount_amt = Convert.ToDouble(discounttxtbox.Text);
                //variables.discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                variables.cash_given = Convert.ToDouble(cash_renderedtxtbox.Text);

                variables.qty_total += variables.quantity;
                variables.discount_totalgiven += variables.discount_amt;
                variables.discounted_total += variables.discounted_amt;
                //variables.change = variables.cash_given - variables.discounted_amt;
                variables.change = variables.cash_given - variables.discounted_total;

                qty_totaltxtbox.Text = variables.qty_total.ToString();
                discount_totaltxtbox.Text = variables.discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = variables.discounted_total.ToString("n");
                changetxtbox.Text = variables.change.ToString("n");
                cash_renderedtxtbox.Text = variables.cash_given.ToString("n");

                computation_Formula_and_DisplayData();
            }

            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty invalid");
                cash_renderedtxtbox.Clear();
                cash_renderedtxtbox.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // code for setting the values of the item name and price within the parameters defined onsode the class
            price_Item_Value.SetPriceItemValue("Burger Steak w/Drink", "84");

            // codes for accessing the function to retrieve the returned values of price and item name individually
            GetPriceItemValue();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("CJ, BS, Spag w/Drink", "224");

            GetPriceItemValue();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("1pc ChickenJoy", "85");

            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("1pc CJ w/CokeFloat", "134");

            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("1pc Cj w/Drink", "105");

            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Chicken Spag", "135");

            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Chicken Spag w/Drink", "172");

            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Chicken Palabok", "205");

            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Bacon Cheeseburger", "117");

            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Double CB, Fries w/Drink", "217");

            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("6pc CJ Bucket", "467");

            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("CJ Bucket with Spag", "697");

            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("CJ Bucket with Palabok", "927");

            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Family Pan", "745");

            GetPriceItemValue();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Bucket Fries", "191");

            GetPriceItemValue();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Spag, BS w/Drink", "161");

            GetPriceItemValue();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Spag, BS w/Drink", "143");

            GetPriceItemValue();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Aloha Champ Fries w/Drink", "221");

            GetPriceItemValue();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Bucket Nuggets", "119");

            GetPriceItemValue();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("2pcs Pancakes", "87");

            GetPriceItemValue();
        }

        private void seniorcitizenRBTN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //access the function with methods to convert string inputs to numeric values from the quantity and price textboxes
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;

                // access the function with methods for the computation formula of the program and display the computed output
                computation_Formula_and_DisplayData();

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
            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.10;

                computation_Formula_and_DisplayData();

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
            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.15;

                computation_Formula_and_DisplayData();

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
            try
            {
                quantity_price_Convert();

                variables.discount_amt = (variables.quantity * variables.price) * 0;

                computation_Formula_and_DisplayData();

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
    }
}
