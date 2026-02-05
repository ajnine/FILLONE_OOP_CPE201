using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Activity2New : Form
    {
        public Activity2New()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Activity2New_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

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
        }

        private void seniorcitizenRBTN_CheckedChanged(object sender, EventArgs e)
        {
            // declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
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

        private void withdiscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(qtytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            seniorcitizenRBTN.Checked = false;
            employeediscRBTN.Checked = false;
            nodiscountRBTN.Checked = false;
        }

        private void employeediscRBTN_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(qtytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            seniorcitizenRBTN.Checked = false;
            withdiscRBTN.Checked = false;
            nodiscountRBTN.Checked = false;
        }

        private void nodiscountRBTN_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(qtytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;

            seniorcitizenRBTN.Checked = false;
            withdiscRBTN.Checked = false;
            employeediscRBTN.Checked = false;
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

        private void cancelBTN_Click(object sender, EventArgs e)
        {

        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            
            qty = Convert.ToInt32(qtytxtbox.Text);
            discount_amt=Convert.ToDouble(discounttxtbox.Text);
            discounted_amt=Convert.ToDouble(discounttxtbox.Text);
            cash_rendered=Convert.ToDouble(cash_renderedtxtbox.Text);

            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_totaltxtbox += discounted_amt;
            change = cash_rendered - discounted_amt;

            qty_totaltxtbox.Text = qty_totaltxtbox.ToString();
            discount_totaltxtbox.Text=discount_totalgiven.ToString("n");
            discounted_totaltxtbox.Text=discounted_total.ToString("n");
            changetxtbox.Text=change.ToString("n");
            cash_renderedtxtbox.Text=cash_rendered.ToString("n");
        }
    }
}
