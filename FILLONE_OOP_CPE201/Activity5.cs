using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Activity5 : Form
    {
        bool can_change = true;

        // setting global variables
        private string picpath;
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;
        private Double netincome = 0.00,
            grossincome = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;
        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salary_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;
        public Activity5()
        {
            InitializeComponent();
        }

        private void Activity5_Load(object sender, EventArgs e)
        {
            // to disable textboxes
            basic_netincomeTXTBOX.Enabled = false;
            honor_netincomeTXTBOX.Enabled = false;
            other_netincomeTXTBOX.Enabled = false;

            netincomeTXTBOX.Enabled = false;
            grossincomeTXTBOX.Enabled = false;

            total_deductTXTBOX.Enabled = false;

            // set default value of textboxes
            SSS_contribTXTBOX.Text = "0.00";
            pagibig_contribTXTBOX.Text = "0.00";
            philhealth_contribTXTBOX.Text = "0.00";
            taxTXTBOX.Text = "0.00";

            SSS_loanTXTBOX.Text = "0.00";
            pagibig_loanTXTBOX.Text = "0.00";
            fcltysavings_depoTXTBOX.Text = "0.00";
            fcltysavings_loanTXTBOX.Text = "0.00";
            salary_loanTXTBOX.Text = "0.00";
            othersTXTBOX.Text = "0.00";

            // to add items inside the combo box
            othersCMBBOX.Text = "Select other deduction";
            othersCMBBOX.Items.Add("Other 1");
            othersCMBBOX.Items.Add("Other 2");
            othersCMBBOX.Items.Add("Other 3");
            othersCMBBOX.Items.Add("Other 4");
            picpathTXTBOX.Hide();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            // to convert input data from textboxes as string to numeric
            // to put data from textboxes to variables
            sss_contrib = Convert.ToDouble(SSS_contribTXTBOX.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribTXTBOX.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribTXTBOX.Text);
            tax_contrib = Convert.ToDouble(taxTXTBOX.Text);
            sss_loan = Convert.ToDouble(SSS_loanTXTBOX.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loanTXTBOX.Text);
            salary_loan = Convert.ToDouble(salary_loanTXTBOX.Text);
            faculty_sav_loan = Convert.ToDouble(fcltysavings_loanTXTBOX.Text);
            salary_savings = Convert.ToDouble(fcltysavings_depoTXTBOX.Text);
            other_deduction = Convert.ToDouble(othersTXTBOX.Text);

            // to compute the desired data to be computed
            /*basic_numhrs = Convert.ToDouble(basicpay_cutoffTXTBOX.Text);
            basic_rate = Convert.ToDouble(basic_ratehourTXTBOX.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_netincomeTXTBOX.Text = basic_netincome.ToString("n");
            hono_numhrs = Convert.ToDouble(honor_cutoffTXTBOX.Text);
            hono_rate = Convert.ToDouble(honor_ratehourTXTBOX.Text);
            hono_netincome = hono_numhrs * hono_rate;
            honor_netincomeTXTBOX.Text = hono_netincome.ToString("n");
            other_numhrs = Convert.ToDouble(other_cutoffTXTBOX.Text);
            other_rate = Convert.ToDouble(other_ratehourTXTBOX.Text);
            other_netincome = other_numhrs * other_rate;
            other_netincomeTXTBOX.Text = other_netincome.ToString("n"); */

            grossincome = basic_netincome + hono_netincome + other_netincome;
            grossincomeTXTBOX.Text = grossincome.ToString("n");

            // formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            // to convert numeric data to string and displayed it inside the textboxes
            total_deductTXTBOX.Text = total_deduction.ToString();
            netincome = grossincome - total_deduction;
            netincomeTXTBOX.Text = netincome.ToString("n");


        }

        private void prev_payslipdetsBTN_Click(object sender, EventArgs e)
        {
            // payslip_viewListBox.Items.add("");
            payslip_viewListBox.Items.Add("Employee Number:  " + "             " + emp_noTXTBOX.Text);
            payslip_viewListBox.Items.Add("Firstname:     " + "             " + firstnameTXTBOX.Text);
            payslip_viewListBox.Items.Add("Middlename:     " + "             " + middlenameTXTBOX.Text);
            payslip_viewListBox.Items.Add("Surname:     " + "             " + surnameTXTBOX.Text);
            payslip_viewListBox.Items.Add("Designation:     " + "             " + designationTXTBOX.Text);
            payslip_viewListBox.Items.Add("Employee Status:     " + "             " + emp_statTXTBOX.Text);
            payslip_viewListBox.Items.Add("Department:     " + "             " + deptTXTBOX.Text);
            payslip_viewListBox.Items.Add("Pay Date:     " + "        " + paydateDatePicker.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------------------------------");

            payslip_viewListBox.Items.Add("BP Num. of Hrs:   " + "P" + basicpay_cutoffTXTBOX.Text);
            payslip_viewListBox.Items.Add("BP Rate / Hr:   " + "P" + basic_ratehourTXTBOX.Text);
            payslip_viewListBox.Items.Add("Basic Pay Income:   " + "P" + basic_netincomeTXTBOX.Text);
            payslip_viewListBox.Items.Add("");

            payslip_viewListBox.Items.Add("HI Num. of Hrs:   " + "P" + honor_cutoffTXTBOX.Text);
            payslip_viewListBox.Items.Add("HI Rate / Hr:   " + "P" + honor_ratehourTXTBOX.Text);
            payslip_viewListBox.Items.Add("Honorarium Income:   " + "P" + honor_netincomeTXTBOX.Text);
            payslip_viewListBox.Items.Add("");

            payslip_viewListBox.Items.Add("OTI Num. of Hrs.:   " + "P" + other_cutoffTXTBOX.Text);
            payslip_viewListBox.Items.Add("OTI Rate / Hr:   " + "P" + other_ratehourTXTBOX.Text);
            payslip_viewListBox.Items.Add("Other Income:   " + "P" + other_netincomeTXTBOX.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------------------------------");

            payslip_viewListBox.Items.Add("SSS Contribution:   " + "P" + SSS_contribTXTBOX.Text);
            payslip_viewListBox.Items.Add("PhilHealth Contribution:   " + "P" + philhealth_contribTXTBOX.Text);
            payslip_viewListBox.Items.Add("Pagibig Contribution:   " + "P" + pagibig_contribTXTBOX.Text);
            payslip_viewListBox.Items.Add("Tax Contribution:   " + "P" + taxTXTBOX.Text);

            payslip_viewListBox.Items.Add("SSS Loan:   " + "P" + SSS_loanTXTBOX.Text);
            payslip_viewListBox.Items.Add("Pagibig Loan:   " + "P" + pagibig_loanTXTBOX.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Deposit:   " + "P" + fcltysavings_depoTXTBOX.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Loan:   " + "P" + fcltysavings_loanTXTBOX.Text);
            payslip_viewListBox.Items.Add("Salary Loan:   " + "P" + salary_loanTXTBOX.Text);
            payslip_viewListBox.Items.Add("Other Loan:   " + "P" + othersTXTBOX.Text);
            payslip_viewListBox.Items.Add("------------------------------------------------------------------------------------");

            payslip_viewListBox.Items.Add("Total Deduction:   " + "P" + total_deductTXTBOX.Text);
            payslip_viewListBox.Items.Add("Gross Income:   " + "P" + grossincomeTXTBOX.Text);
            payslip_viewListBox.Items.Add("Net Income:   " + "P" + netincomeTXTBOX.Text);

        }

        private void prnt_payslipBTN_Click(object sender, EventArgs e)
        {
            // for calling connected to the current form
            Activity5_PrintFrm print1 = new Activity5_PrintFrm();

            // for displaying the contents of the listbox from other form to the current form
            print1.priDisplayListbox.Items.AddRange(this.payslip_viewListBox.Items);

            // to display the other form
            print1.Show();
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            can_change = false;
            // to clear all textboxes
            emp_noTXTBOX.Clear();
            firstnameTXTBOX.Clear();
            middlenameTXTBOX.Clear();
            surnameTXTBOX.Clear();
            civilstatTXTBOX.Clear();
            designationTXTBOX.Clear();
            no_ofdependentsTXTBOX.Clear();
            emp_statTXTBOX.Clear();
            deptTXTBOX.Clear();
            basic_netincomeTXTBOX.Clear();
            basicpay_cutoffTXTBOX.Clear();
            basic_ratehourTXTBOX.Clear();
            honor_netincomeTXTBOX.Clear();
            honor_cutoffTXTBOX.Clear();
            honor_ratehourTXTBOX.Clear();
            other_netincomeTXTBOX.Clear();
            other_cutoffTXTBOX.Clear();
            other_ratehourTXTBOX.Clear();
            grossincomeTXTBOX.Clear();
            netincomeTXTBOX.Clear();
            SSS_contribTXTBOX.Clear();
            pagibig_contribTXTBOX.Clear();
            philhealth_contribTXTBOX.Clear();
            taxTXTBOX.Clear();
            SSS_loanTXTBOX.Clear();
            pagibig_loanTXTBOX.Clear();
            fcltysavings_depoTXTBOX.Clear();
            fcltysavings_loanTXTBOX.Clear();
            salary_loanTXTBOX.Clear();
            othersTXTBOX.Clear();

            // to reset the combo box and textboxes to default value
            othersCMBBOX.SelectedIndex = -1;
            othersCMBBOX.Text = "Select other deduction";
            SSS_contribTXTBOX.Text = "0.00";
            pagibig_contribTXTBOX.Text = "0.00";
            philhealth_contribTXTBOX.Text = "0.00";
            taxTXTBOX.Text = "0.00";

            SSS_loanTXTBOX.Text = "0.00";
            pagibig_loanTXTBOX.Text = "0.00";
            fcltysavings_depoTXTBOX.Text = "0.00";
            fcltysavings_loanTXTBOX.Text = "0.00";
            salary_loanTXTBOX.Text = "0.00";
            othersTXTBOX.Text = "0.00";
            total_deductTXTBOX.Clear();

            can_change = true;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            can_change = false;
            // to clear all textboxes
            emp_noTXTBOX.Clear();
            firstnameTXTBOX.Clear();
            middlenameTXTBOX.Clear();
            surnameTXTBOX.Clear();
            civilstatTXTBOX.Clear();
            designationTXTBOX.Clear();
            no_ofdependentsTXTBOX.Clear();
            emp_statTXTBOX.Clear();
            deptTXTBOX.Clear();
            basic_netincomeTXTBOX.Clear();
            basicpay_cutoffTXTBOX.Clear();
            basic_ratehourTXTBOX.Clear();
            honor_netincomeTXTBOX.Clear();
            honor_cutoffTXTBOX.Clear();
            honor_ratehourTXTBOX.Clear();
            other_netincomeTXTBOX.Clear();
            other_cutoffTXTBOX.Clear();
            other_ratehourTXTBOX.Clear();
            grossincomeTXTBOX.Clear();
            netincomeTXTBOX.Clear();
            SSS_contribTXTBOX.Clear();
            pagibig_contribTXTBOX.Clear();
            philhealth_contribTXTBOX.Clear();
            taxTXTBOX.Clear();
            SSS_loanTXTBOX.Clear();
            pagibig_loanTXTBOX.Clear();
            fcltysavings_depoTXTBOX.Clear();
            fcltysavings_loanTXTBOX.Clear();
            salary_loanTXTBOX.Clear();
            othersTXTBOX.Clear();

            // to reset the combo box and textboxes to default value
            othersCMBBOX.SelectedIndex = -1;
            othersCMBBOX.Text = "Select other deduction";
            SSS_contribTXTBOX.Text = "0.00";
            pagibig_contribTXTBOX.Text = "0.00";
            philhealth_contribTXTBOX.Text = "0.00";
            taxTXTBOX.Text = "0.00";

            SSS_loanTXTBOX.Text = "0.00";
            pagibig_loanTXTBOX.Text = "0.00";
            fcltysavings_depoTXTBOX.Text = "0.00";
            fcltysavings_loanTXTBOX.Text = "0.00";
            salary_loanTXTBOX.Text = "0.00";
            othersTXTBOX.Text = "0.00";
            total_deductTXTBOX.Clear();

            can_change = true;
        }

        private void browseBTN_Click(object sender, EventArgs e)
        {
            try 
            {
                // to open file dialog and to filter the file type to be selected
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
                openFileDialog.Title = "Select Employee Picture";
                openFileDialog.ShowDialog();
                picpath = openFileDialog.FileName;
                picpathTXTBOX.Text = picpath;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            } 
            catch 
            {
                MessageBox.Show("No file selected.");
                
            }
            
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            // to close the form
            this.Close();
        }

        private void basicpay_cutoffTXTBOX_TextChanged(object sender, EventArgs e)
        {

            // to convert input data from textboxes as string to numeric
            try
            {
                basic_numhrs = Convert.ToDouble(basicpay_cutoffTXTBOX.Text);
                basic_rate = Convert.ToDouble(basic_ratehourTXTBOX.Text);
                basic_netincome = basic_numhrs * basic_rate;
                basic_netincomeTXTBOX.Text = basic_netincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Please input numeric value only.");
                basicpay_cutoffTXTBOX.Clear();
                basicpay_cutoffTXTBOX.Focus();
            }


        }

        private void honor_cutoffTXTBOX_TextChanged(object sender, EventArgs e)
        {

            try
            {
                hono_numhrs = Convert.ToDouble(honor_cutoffTXTBOX.Text);
                hono_rate = Convert.ToDouble(honor_ratehourTXTBOX.Text);
                hono_netincome = hono_numhrs * hono_rate;
                honor_netincomeTXTBOX.Text = hono_netincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Please input numeric value only.");
                honor_cutoffTXTBOX.Clear();
                honor_cutoffTXTBOX.Focus();
            }


        }

        private void other_cutoffTXTBOX_TextChanged(object sender, EventArgs e)
        {

            try
            {
                other_numhrs = Convert.ToDouble(other_cutoffTXTBOX.Text);
                other_rate = Convert.ToDouble(other_ratehourTXTBOX.Text);
                other_netincome = other_numhrs * other_rate;
                other_netincomeTXTBOX.Text = other_netincome.ToString("n");

                grossincome = basic_netincome + hono_netincome + other_netincome;
                grossincomeTXTBOX.Text = grossincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Please input numeric value only.");
                other_cutoffTXTBOX.Focus();
                other_cutoffTXTBOX.Clear();
            }
        }
    }
}
