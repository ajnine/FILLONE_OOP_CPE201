using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // codes for disabling the textboxes
            itemnametxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

            // codes for inserting picture or image inside the picturebox tool
            pictureBox10.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\Jolly-Spaghetti-With-1-pc.-Burger-Steak-With-Drink.png");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\Yumburger-Half-Jolly-Spaghetti-Reg.-Fries-Super-Meal-With-Drink.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\6-pc.-Chicken-Nuggets.png");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\Bacon-Cheesy-Yumburger-Solo.png");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\jollibee menu\\1-pc.-Chickenjoy-With-Palabok-Solo.png");

            // codes for inserting name of the image inside the label tool
            name1lbl.Text = "Burger Steak w/drink";
            name2lbl.Text = "CSBS w/drink";
            name3lbl.Text = "1 pc ChickenJoy";
            name4lbl.Text = "1 pc CJ w/Cokefloat";
            name5lbl.Text = "1 pc CJ w/drink";
            name6lbl.Text = "CJ n Spaghetti";
            name7lbl.Text = "CJ, Spaghetti w/Drink";
            name8lbl.Text = "Pancakes";
            name9lbl.Text = "CJ n Spag Bucket";
            name10lbl.Text = "6pc ChickenJoy";
            name11lbl.Text = "CJ n Palabok Bucket";
            name12lbl.Text = "Aloha B, Fries, Drinks";
            name13lbl.Text = "Family Meal";
            name14lbl.Text = "D.P.C.B., Fries, Drinks";
            name15lbl.Text = "Bucket Fries";
            name16lbl.Text = "S.B.D";
            name17lbl.Text = "S.B.F.D";
            name18lbl.Text = "Nuggets";
            name19lbl.Text = "Bacon CB";
            name20lbl.Text = "CJ n Palabok";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Burger Steak w/drink";
            pricetxtbox.Text = "84";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CSBS w/drink";
            pricetxtbox.Text = "224";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "1pc ChickenJoy";
            pricetxtbox.Text = "95";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "1 pc CJ w/Cokefloat";
            pricetxtbox.Text = "115";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "1 pc CJ w/drink";
            pricetxtbox.Text = "98";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CJ n Spaghetti";
            pricetxtbox.Text = "86";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CJ Spaghetti w/Drink";
            pricetxtbox.Text = "97";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Pancakes";
            pricetxtbox.Text = "76";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CJ n Spag Bucket";
            pricetxtbox.Text = "559";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "6pc ChickenJoy";
            pricetxtbox.Text = "357";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CJ n Palabok Bucket";
            pricetxtbox.Text = "678";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Aloha B, Fries, Drinks";
            pricetxtbox.Text = "215";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Family Meal";
            pricetxtbox.Text = "963";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "DPCB, Fries, Drinks";
            pricetxtbox.Text = "256";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Bucket Fries";
            pricetxtbox.Text = "125";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "SBD";
            pricetxtbox.Text = "99";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "SBFD";
            pricetxtbox.Text = "110";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Nuggets";
            pricetxtbox.Text = "100";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Bacon CB";
            pricetxtbox.Text = "135";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "CJ n Palabok";
            pricetxtbox.Text = "87";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cash_renderedtxtbox.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            // converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // codes for unchecking the other radio buttons in the interface once the senior citizen method executed
            wdisccardRbtn.Checked = false;
            employeediscRbtn.Checked = false;
            nodiscountRbtn.Checked = false;
        }

        private void wdisccardRbtn_CheckedChanged(object sender, EventArgs e)
        {
            // declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            // converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // codes for unchecking the other radio buttons in the interface once with disc. card  method executed
            seniorcitizenRbtn.Checked = false;
            employeediscRbtn.Checked = false;
            nodiscountRbtn.Checked = false;
        }

        private void employeediscRbtn_CheckedChanged(object sender, EventArgs e)
        {
            // declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            // converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // codes for unchecking the other radio buttons in the interface once employee disc method executed
            seniorcitizenRbtn.Checked = false;
            wdisccardRbtn.Checked = false;
            nodiscountRbtn.Checked = false;
        }

        private void nodiscountRbtn_CheckedChanged(object sender, EventArgs e)
        {
            // declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;

            // converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // codes for unchecking the other radio buttons in the interface once no method executed
            seniorcitizenRbtn.Checked = false;
            wdisccardRbtn.Checked = false;
            employeediscRbtn.Checked = false;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int qty_total = 0;
            double discount_totalgiven = 0;
            double discounted_total = 0;
            // declaration of variables with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discounttxtbox.Text);
            discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered=Convert.ToDouble(cash_renderedtxtbox.Text);

            //codes to accumulate the value of the quantity, discount given and discounted amount from one trsanction to another
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            // convert string data form textboses to numeric and place it as value of the variable
            qty_totaltxtbox.Text = qty_total.ToString();
            discount_totaltxtbox.Text= discount_totalgiven.ToString("n");
            discounted_totaltxtbox.Text = discounted_total.ToString("n");
            changetxtbox.Text=change.ToString("n");
            cash_renderedtxtbox.Text=cash_rendered.ToString("n");
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
