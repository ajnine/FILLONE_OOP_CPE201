using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Lesson3Activity : Form
    {
        int lecture_fee = 1500;
        int laboratory_fee = 2500;
        int cisco_fee = 4500;
        int exam_fee = 450;
        int sap_fee = 1500;
        public Lesson3Activity()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Lesson3Activity_Load(object sender, EventArgs e)
        {
            progsCMBBOX.Items.Add("BS Information Technology");
            progsCMBBOX.Items.Add("BS Computer Engineering");
            progsCMBBOX.Items.Add("BS Electrical Engineering");
            progsCMBBOX.Items.Add("BS Computer Science");
            progsCMBBOX.Items.Add("BS Mechanical Engineering");
            progsCMBBOX.Items.Add("BS Industrial Engineering");

            cred_oneTXTBOX.Enabled = false;
            cred_twoTXTBOX.Enabled = false;
            cred_threeTXTBOX.Enabled = false;
            cred_fourTXTBOX.Enabled = false;
            cred_fiveTXTBOX.Enabled = false;
            cred_sixTXTBOX.Enabled = false;
            cred_sevenTXTBOX.Enabled = false;

            modeCMBBOX.Items.Add("Installment");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lec_oneTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
