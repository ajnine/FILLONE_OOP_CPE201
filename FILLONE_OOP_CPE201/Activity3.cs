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
        public Activity3()
        {
            InitializeComponent();
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
        }

        private void bundleA_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            bundleA_Rbtn.Checked = false;
            //   orderpicturebox.Image = Image.FromFile("C:\Users\Ali\Desktop\OOP\FILLONE_OOP_CPE201\FILLONE_OOP_CPE201\food bundles pictures\Baked-mac.-Chicken-Teriyaki.-Pinakbet.-Bistek-Tagalog.-Lumpia-Shanghai--1024x683.jpeg");

            A_cokeCheckbox.Checked = true;
            A_friedchickenCheckbox.Checked = true;
            A_friesCheckbox.Checked = true;
            A_pizzaCheckbox.Checked = true;
            A_sidedishesCheckbox.Checked = true;

            B_CarbonaraCheckbox.Checked = false;
            B_friedchickenCheckbox.Checked = false;
            B_friesCheckbox.Checked = false;
            B_halohaloCheckbox.Checked = false;
            B_pizzaCheckbox.Checked = false;

            pricetxtbox.Text = "P1,000.00";
            discounttxtbox.Text = "(20% of the Price) P200.00";
        }

        private void bundleB_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            bundleA_Rbtn.Checked = false;
            //  orderpicturebox.Image = Image.FromFile(C:\\Users\Ali\Desktop\OOP\FILLONE_OOP_CPE201\FILLONE_OOP_CPE201\food bundles pictures.jpeg);
            A_cokeCheckbox.Checked = false;
            A_friedchickenCheckbox.Checked = false;
            A_friesCheckbox.Checked = false;
            A_pizzaCheckbox.Checked = false;
            A_sidedishesCheckbox.Checked = false;

            B_CarbonaraCheckbox.Checked = true;
            B_friedchickenCheckbox.Checked = true;
            B_friesCheckbox.Checked = true;
            B_halohaloCheckbox.Checked = true;
            B_pizzaCheckbox.Checked = true;

            pricetxtbox.Text = "P1,299.00";
            discounttxtbox.Text = "(15% of the Price) P194.85";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            bundleA_Rbtn.Checked = false;
            bundleB_Rbtn.Checked = false;
        }

        private void A_friedchickenCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pricetxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
