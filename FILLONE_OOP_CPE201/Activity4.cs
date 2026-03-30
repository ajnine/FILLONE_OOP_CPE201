using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Activity3 : Form
    {
        // global variables
        private double total_amount = 0;
        private int total_qty = 0;

        // to check if the user can change the value of the textboxes
        bool can_change = true;
        public Activity3()
        {
            InitializeComponent();
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            // disabling textboxes
            pricetxtbox.Enabled = false;
            discounted_amttxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            total_billstxtbox.Enabled = false;
            disc_amttxtbox.Enabled = false;
            total_qntytxtbox.Enabled = false;

            // inserting pizza pictures
            pizza6.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\all meat.jpg");
            pizza7.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\cheesy burger.jpg");
            pizza8.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\tropical hawaiian.jpg");
            pizza9.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\combo and cheese.jpg");
            pizza10.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\combo and pepperoni.jpg");
            pizza11.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\beef & mushroom.jpg");
            pizza12.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\cheese mania.jpg");
            pizza13.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\ham & cheese.jpg");
            pizza14.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\spinach & peta.jpg");
            pizza15.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\5 cheese.jpg");
            pizza16.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\meatzza.jpg");
            pizza17.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\carbo pizza.jpg");
            pizza18.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\ult pepperoni.jpg");
            pizza19.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\pacific veggie.jpg");
            pizza20.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\pizza pictures\\aloha pizza.jpg");

            // disabling checkboxes
            A_cokeCheckbox.Checked = false;
            A_friedchickenCheckbox.Checked = false;
            A_friesCheckbox.Checked = false;
            A_pizzaCheckbox.Checked = false;
            A_sidedishesCheckbox.Checked = false;
            B_CarbonaraCheckbox.Checked = false;
            B_friedchickenCheckbox.Checked = false;
            B_friesCheckbox.Checked = false;
            B_halohaloCheckbox.Checked = false;
            B_pizzaCheckbox.Checked = false;

            // insert default picture
            orderpicturebox.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\food bundles pictures\\default.jpg");

        }

        private void bundleA_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            // setting local variable
            double price;

            // changing background color
            this.BackColor = Color.Thistle;

            // to disable bundle B
            bundleB_Rbtn.Checked = false;

            //inserting image
            orderpicturebox.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\food bundles pictures\\bundle A.png");

            // to check textboxes
            A_cokeCheckbox.Checked = true;
            A_friedchickenCheckbox.Checked = true;
            A_friesCheckbox.Checked = true;
            A_pizzaCheckbox.Checked = true;
            A_sidedishesCheckbox.Checked = true;

            // to uncheck textboxes
            B_CarbonaraCheckbox.Checked = false;
            B_friedchickenCheckbox.Checked = false;
            B_friesCheckbox.Checked = false;
            B_halohaloCheckbox.Checked = false;
            B_pizzaCheckbox.Checked = false;

            // to display data inside textboxes
            pricetxtbox.Text = "1,000.00";
            disc_amttxtbox.Text = "200.00";
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert data inside listbox
            dsplayListbox.Items.Add(bundleA_Rbtn.Text + "                   " + pricetxtbox.Text);
            dsplayListbox.Items.Add("           Discount Amount: " + "       " + disc_amttxtbox.Text);
            qntytxtbox.Text = "0";
            qntytxtbox.Focus();
        }

        private void bundleB_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            // setting local variable
            double price;

            // changing background color
            this.BackColor = Color.AliceBlue;

            // for bundle A not to be selected
            bundleA_Rbtn.Checked = false;

            // inserting pictures
            orderpicturebox.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\food bundles pictures\\bundle B.png");

            // to uncheck bundle A
            A_cokeCheckbox.Checked = false;
            A_friedchickenCheckbox.Checked = false;
            A_friesCheckbox.Checked = false;
            A_pizzaCheckbox.Checked = false;
            A_sidedishesCheckbox.Checked = false;

            // to check bundle B
            B_CarbonaraCheckbox.Checked = true;
            B_friedchickenCheckbox.Checked = true;
            B_friesCheckbox.Checked = true;
            B_halohaloCheckbox.Checked = true;
            B_pizzaCheckbox.Checked = true;

            // to display data inside textboxes
            pricetxtbox.Text = "1,299.00";
            disc_amttxtbox.Text = "194.85";
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert data inside listbox
            dsplayListbox.Items.Add(bundleB_Rbtn.Text + "                   " + pricetxtbox.Text);
            dsplayListbox.Items.Add("           Discount Amount: " + "       " + disc_amttxtbox.Text);
            qntytxtbox.Text = "0";
            qntytxtbox.Focus();
        }

        private void calcbillsBTN_Click(object sender, EventArgs e)
        {
            // setting variables
            double cash_given, change, total_amountPaid;

            // to convert string data inside the textbox to numeric data to store inside the variable
            try
            { 
                cash_given = Convert.ToDouble(cash_gvntxtbox.Text);
                total_amountPaid = Convert.ToDouble(total_billstxtbox.Text);

                change = cash_given - total_amountPaid;
                changetxtbox.Text = change.ToString("n");

                dsplayListbox.Items.Add("Total Bills: " + "          " + total_billstxtbox.Text);
                dsplayListbox.Items.Add("Cash Given: " + "          " + cash_gvntxtbox.Text);
                dsplayListbox.Items.Add("Change: " + "          " + changetxtbox.Text);
                dsplayListbox.Items.Add("Total No. of Items: " + "          " + total_qntytxtbox.Text);
            } 
            catch (Exception)
            { 
                MessageBox.Show("Enter valid data in cash given textbox!");
                cash_gvntxtbox.Clear();
                cash_gvntxtbox.Focus();
            }
        }

        private void prnt_transBTN_Click(object sender, EventArgs e)
        {
            // to call other form connected to the current form
            Activity4_PrintFrm print = new Activity4_PrintFrm();

            // to display data of listbox from other form to current form
            print.printDisplayListBox.Items.AddRange(this.dsplayListbox.Items);

            //to display the other form
            print.Show();
        }

        private void rem_orderBTN_Click(object sender, EventArgs e)
        {
            // to remove selected data inside the listbox
            dsplayListbox.Items.RemoveAt(dsplayListbox.SelectedIndex);
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            // to prevent the user from changing the value of the textboxes while the event of the object is triggered
            can_change = false;

            // to uncheck all given checkboxes
            bundleA_Rbtn.Checked = false;
            bundleB_Rbtn.Checked = false;

            // to insert default image in the picturebox
            orderpicturebox.Image = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\food bundles pictures\\default.jpg");

            // to uncheck food bundles
            A_cokeCheckbox.Enabled = false;
            A_friedchickenCheckbox.Enabled = false;
            A_friesCheckbox.Enabled = false;
            A_pizzaCheckbox.Enabled = false;
            A_sidedishesCheckbox.Enabled = false;

            B_CarbonaraCheckbox.Enabled = false;
            B_friedchickenCheckbox.Enabled = false;
            B_friesCheckbox.Enabled = false;
            B_halohaloCheckbox.Enabled = false;
            B_pizzaCheckbox.Enabled = false;

            // to clear textboxes
            pricetxtbox.Clear();
            qntytxtbox.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;

            // to remove contents of listbox
            dsplayListbox.Items.Clear();

            can_change = true;
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qntytxtbox_TextChanged(object sender, EventArgs e)
        {
         // set variables
         double price, discounted_amount, discount_amount;
         int qty;

        // to convert string data inside the textbox to numeric data to store inside the variable
        try 
            { 
                price = Convert.ToDouble(pricetxtbox.Text);
                qty = Convert.ToInt32(qntytxtbox.Text);

                discount_amount = Convert.ToDouble(disc_amttxtbox.Text);
                discounted_amount = (price * qty) - discount_amount;

                total_qty += qty;
                total_qntytxtbox.Text = total_qty.ToString();
                total_amount += discounted_amount;
                total_billstxtbox.Text = total_amount.ToString("n");
                discounted_amttxtbox.Text = discounted_amount.ToString("n");
            } 
            catch (Exception)
            { 
                MessageBox.Show("Choose an order");
                qntytxtbox.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "500.99";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox1.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "550.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox2.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "600.99";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox3.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "700.50";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox4.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "500.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox5.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "750.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox10.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "700.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox9.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "850.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox8.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "450.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox7.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "650.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox6.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox15.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox14.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox13.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox12.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox11.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox20.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox19.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox18.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox17.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            // set variable
            double price;

            // to put text property value of textbox
            disc_amttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";

            // to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(pricetxtbox.Text);

            // to insert text property value of checkbox inside the listbox
            dsplayListbox.Items.Add(checkBox16.Text + "         " + pricetxtbox.Text);

            // to put text property value of textbox
            qntytxtbox.Text = "0";

            // for the cursor inside the textbox once the event of the object triggered
            qntytxtbox.Focus();
        }

        private void pizza1_Click(object sender, EventArgs e)
        {

        }
    }
}
