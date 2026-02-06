using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Lesson2Activity : Form
    {
        public Lesson2Activity()
        {
            InitializeComponent();
        }

        private void Lesson2Activity_Load(object sender, EventArgs e)
        {
            progsCMBBOX.Items.Add("BS in Computer Engineering");
            progsCMBBOX.Items.Add("BS in Electrical Engineering");
            progsCMBBOX.Items.Add("BS in Electronics Engineering");
            progsCMBBOX.Items.Add("BS in Civil Engineering");
            progsCMBBOX.Items.Add("BS in Mechanical Engineering");
            progsCMBBOX.Items.Add("BS in Industrial Engineering");
        }

        private void browseBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select Student Photo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    student_picsPCTBOX.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Loading image: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void progsCMBBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            numberlistBox.Items.Add(course_numberTXTBOX.Text);
            course_codelistBox.Items.Add(course_codeTXTBOX.Text);
            course_desclistBox.Items.Add(course_descTXTBOX.Text);
            unic_leclistBox.Items.Add(unit_lecTXTBOX.Text);
            unit_lablistBox.Items.Add(unit_labTXTBOX.Text);
            cred_unitslistBox.Items.Add(cred_unitsTXTBOX.Text);
            timelistBox.Items.Add(timeTXTBOX.Text);
            daylistBox.Items.Add(dayTXTBOX.Text);
        }

        private void new_cancelBTN_Click(object sender, EventArgs e)
        {
            stud_nameTXTBOX.Clear();
            stud_numberTXTBOX.Clear();
            yr_lvlTXTBOX.Clear();
            scholarTXTBOX.Clear();
            course_numberTXTBOX.Clear();
            course_codeTXTBOX.Clear();
            course_descTXTBOX.Clear();
            unit_lecTXTBOX.Clear();
            unit_labTXTBOX.Clear();
            timeTXTBOX.Clear();
            dayTXTBOX.Clear();
            cred_unitsTXTBOX.Clear();
            unitsnum_totalTXTBOX.Clear();
            labfeeTXTBOX.Clear();
            tuitionfee_totalTXTBOX.Clear();
            miscfee_totalTXTBOX.Clear();
            ciscofeeTXTBOX.Clear();
            bookletfeeTXTBOX.Clear();
            tuitionandfee_totalTXTBOX.Clear();
            totaltuition_andfeeTXTBOX.Clear();
            total_miscfeeTXTBOX.Clear();
            numunits_totalTXTBOX.Clear();
            tuitionandfees_totalTXTBOX.Clear();
            comlab_feeTXTBOX.Clear();
            CISCOlabfeeTXTBOX.Clear();
            exambookletTXTBOX.Clear();
            otherfeesTXTBOX.Clear();
        }
    }
}
