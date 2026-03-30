using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Lesson5_Activity : Form
    {
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
            gross_income = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 200.00,
            philhealth_contrib = 0.00,
            incometax_contrib = 0.00;
        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            facsev_loan = 0.00,
            salary_loan = 0.00,
            other_loan = 0.00;
        private Double total_deduction = 0.00;




        private void SaveBtn_Click(object sender, EventArgs e)
        {

            //Payslip = new Payslip();
            // print listBox1.Items.AddRange(this.listbox)
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            // code for clearing the textbox
            NohrsTxtBox.Clear();
            Nohrs2TxtBox.Clear();
            Nohrs3TxtBox.Clear();
            IncCutTxtBox.Clear();
            IncCut2TxtBox.Clear();
            IncCut3TxtBox.Clear();
            RateHrTxtBox.Clear();
            RateHr2TxtBox.Clear();
            RateHr3TxtBox.Clear();
            GrossTxtBox.Clear();
            NetTxtBox.Clear();
            PhilHealthConTxtBox.Clear();
            SSSLoanTxtBox.Clear();
            PagibigLoanTxtBox.Clear();
            FacSevTxtBox.Clear();
            SalaryLoanTxtBox.Clear();
            OthLoanTxtBox.Clear();
            TotDecTxtBox.Clear();
            SSSConTxtBox.Clear();
            PagibigConTxtBox.Clear();
            IncTaxTxtBox.Clear();


        }

        private void NetIncBtn_Click(object sender, EventArgs e)
        {
            // to compute net income
            // for computing the regular deductions
            double sss_contrib, pagibig_contrib, philhealth_contrib, incometax_contrib;
            sss_contrib = Convert.ToDouble(SSSConTxtBox.Text);
            pagibig_contrib = Convert.ToDouble(PagibigConTxtBox.Text);
            philhealth_contrib = Convert.ToDouble(PhilHealthConTxtBox.Text);
            incometax_contrib = Convert.ToDouble(IncTaxTxtBox.Text);

            // for computing the other deductions
            double sss_loan, pagibig_loan, facsev_loan, salary_loan, other_loan;
            sss_loan = Convert.ToDouble(SSSLoanTxtBox.Text);
            pagibig_loan = Convert.ToDouble(PagibigLoanTxtBox.Text);
            facsev_loan = Convert.ToDouble(FacSevTxtBox.Text);
            salary_loan = Convert.ToDouble(SalaryLoanTxtBox.Text);
            other_loan = Convert.ToDouble(OthLoanTxtBox.Text);
            total_deduction = sss_contrib + pagibig_contrib + philhealth_contrib + incometax_contrib + sss_loan + pagibig_loan + facsev_loan + salary_loan + other_loan;
            TotDecTxtBox.Text = total_deduction.ToString("n");

            // for computing the net income
            basic_netincome = gross_income - total_deduction;
            NetTxtBox.Text = basic_netincome.ToString("n");
        }


        public Lesson5_Activity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // to disable text box
            FnameTxtBox.Enabled = false;
            MnameTxtBox.Enabled = false;
            SnameTxtBox.Enabled = false;
            CivStatTxtBox.Enabled = false;
            EmpStatTxtBox.Enabled = false;
            DesigTxtBox.Enabled = false;
            DepTxtBox.Enabled = false;
            IncCutTxtBox.Enabled = false;
            IncCut2TxtBox.Enabled = false;
            IncCut3TxtBox.Enabled = false;
            NetTxtBox.Enabled = false;
            TotDecTxtBox.Enabled = false;
            SSSConTxtBox.Enabled = false;
            PhilHealthConTxtBox.Enabled = false;
            PagibigConTxtBox.Enabled = false;
            IncTaxTxtBox.Enabled = false;
            //listBox1.Hide();
        }

        private void GrossIncBtn_Click(object sender, EventArgs e)
        {
            // to compute gross income
            // for computing the basic income
            basic_numhrs = Double.Parse(NohrsTxtBox.Text);
            basic_rate = Convert.ToDouble(RateHrTxtBox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            IncCutTxtBox.Text = basic_netincome.ToString("n");

            // for computing the honorarium income
            hono_numhrs = Convert.ToDouble(Nohrs2TxtBox.Text);
            hono_rate = Convert.ToDouble(RateHr2TxtBox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            IncCut2TxtBox.Text = hono_netincome.ToString("n");

            // for computing the other income
            other_numhrs = Convert.ToDouble(Nohrs3TxtBox.Text);
            other_rate = Convert.ToDouble(RateHr3TxtBox.Text);
            other_netincome = other_numhrs * other_rate;
            gross_income = basic_netincome + hono_netincome + other_netincome;
            GrossTxtBox.Text = gross_income.ToString("n");

            // for regular deductions textboxes
            if (gross_income <= 10000)
            {
                sss_contrib = 147.56;
                philhealth_contrib = 150.00;
                pagibig_contrib = 200.00;
                incometax_contrib = 5.00;
            }
            else if (gross_income <= 20000)
            {
                sss_contrib = 367.56;
                philhealth_contrib = 300.00;
                pagibig_contrib = 200.00;
                incometax_contrib = 10.00;
            }
            else if (gross_income <= 30000)
            {
                sss_contrib = 587.56;
                philhealth_contrib = 450.00;
                pagibig_contrib = 200.00;
                incometax_contrib = 15.00;
            }
            else if (gross_income <= 40000)
            {
                sss_contrib = 807.56;
                philhealth_contrib = 600.00;
                pagibig_contrib = 200.00;
                incometax_contrib = 20.00;
            }
            else if (gross_income <= 50000)
            {
                sss_contrib = 1027.56;
                philhealth_contrib = 750.00;
                pagibig_contrib = 200.00;
                incometax_contrib = 25.00;
            }
            else if (gross_income <= 60000)
            {
                sss_contrib = 1247.56;
                philhealth_contrib = 900.00;
                pagibig_contrib = 200.00;
                incometax_contrib = 30.00;
            }
            else
            {
                sss_contrib = 1569.89;
                philhealth_contrib = 1200.00;
                pagibig_contrib = 200.00;
                incometax_contrib = 35.00;
            }

            SSSConTxtBox.Text = sss_contrib.ToString("n");
            PhilHealthConTxtBox.Text = philhealth_contrib.ToString("n");
            PagibigConTxtBox.Text = pagibig_contrib.ToString("n");
            IncTaxTxtBox.Text = incometax_contrib.ToString("n");
        }

    }
}
