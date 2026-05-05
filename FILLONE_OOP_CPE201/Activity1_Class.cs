using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Activity1_Class : Form
    {
        // Declare variables to store item details and transaction information
        private double amount_paid, price, cash_given, change;
        private int quantity;
        public Activity1_Class()
        {
            InitializeComponent();
        }

        // codes for accessing the class created
        Price_item_Value price_item_value = new Price_item_Value();
        Variables variables = new Variables();

        // function codes for getting the value of item name and price 
        private void GetPriceItemValue()
        {
            itemnameTxtbox.Text = (price_item_value.GetItemName());
            priceTxtbox.Text = (price_item_value.GetPrice());
        }

        // function codes for setting the text property value of the item and price textboxes
        private void displaytxtbox(string itemname, string price)
        {
            itemnameTxtbox.Text = itemname;
            priceTxtbox.Text = price;
        }

        // function codes for clearing and placing cursor inside the quantity textbox
        private void quantitytxtbox()
        {
            qntyTxtbox.Clear();
            qntyTxtbox.Focus();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            qntyTxtbox.Clear();
            amnt_paidTxtbox.Clear();
            cash_givenTxtbox.Clear();
            changeTxtbox.Clear();
        }

        private void Activity1_Class_Load(object sender, EventArgs e)
        {

            // Set the form to be borderless and maximized to fill the entire screen
            changeTxtbox.Enabled = false;

            // Set the form to be borderless and maximized to fill the entire screen
            this.Location = new Point(0, 0);

            // Set the form to be borderless and maximized to fill the entire screen
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Supermeal w/ Drink", "224");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("1 – pc. Chickenjoy Solo", "85");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("1-pc. Chickenjoy w/ Coke Float", "134");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("1 – pc. Chickenjoy With Drink", "105");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("1 – pc. Chickenjoy with Palabok Solo", "135");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("1 – pc. Chickenjoy W/ Jolly Spaghetti w/ Drink", "172");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("2 – pc. Pancakes with Drink", "87");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("6 – pc. Chickenjoy Bucket w/ Jolly Spaghetti", "697");
            GetPriceItemValue();
            quantitytxtbox();


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("6 – pc. Chickenjoy Solo", "467");
            GetPriceItemValue();
            quantitytxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("6 – pc. Chickenjoy with Palabok Family Pan", "927");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Amazing Aloha Champ Jr., Fries & Drink", "221");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Chickenjoy Bucket Family Meals", "745");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Jolly Crispy Fries Bucket", "191");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Double Cheesy Yumburger With Fries & Drink", "217");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("1 – pc. Burger Steak With Drink", "84");
            GetPriceItemValue();
            quantitytxtbox();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                variables.amount_paid = Convert.ToDouble(amnt_paidTxtbox.Text);
                variables.cash_given = Convert.ToDouble(cash_givenTxtbox.Text);
                variables.change = variables.cash_given - variables.amount_paid;
                changeTxtbox.Text = variables.change.ToString("n");
                amnt_paidTxtbox.Text = variables.amount_paid.ToString("c");
                cash_givenTxtbox.Text = variables.cash_given.ToString("c");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid!");
                cash_givenTxtbox.Focus();
                cash_givenTxtbox.Clear();
            }
            finally
            {
                MessageBox.Show("Transaction Completed!");
            }

        }

        private void qntyTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                variables.price = Convert.ToDouble(priceTxtbox.Text);
                variables.quantity = Convert.ToInt32(qntyTxtbox.Text);
                variables.amount_paid = variables.price * variables.quantity;

                amnt_paidTxtbox.Text = variables.amount_paid.ToString("n");
                cash_givenTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input");
                qntyTxtbox.Clear();
                qntyTxtbox.Show();
            }

        }
    }
}
