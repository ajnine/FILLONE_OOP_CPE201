using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class for_loop2 : Form
    {
        // Declare global variables for the form
        private Double basic_netincome = 0.00,
                basic_numhrs = 0.00,
                basic_rate = 0.00,
                hono_netincome = 0.00,
                hono_numhrs = 0.00,
                hono_rate = 0.00,
                other_netincome = 0.00,
                other_numhrs = 0.00,
                other_rate = 0.00,
                gross_income = 0.00,
                tax = 0.00;
        private double sss_contrib, pagibig_contrib, philhealth_contrib, total_deductions, net_income;
        public for_loop2()
        {
            InitializeComponent();
        }

        private void for_loop2_Load(object sender, EventArgs e)
        {
            basic_inccutoffTXTBOX.Enabled = false;
            honor_tothonorpayTXTBOX.Enabled = false;
            other_totincomepayTXTBOX.Enabled = false;
            netincTXTBOX.Enabled = false;
            grossincTXTBOX.Enabled = false;
            totdeductTXTBOX.Enabled = false;
            ssscontribTXTBOX.Enabled = false;
            pagibigcontribTXTBOX.Enabled = false;
            philhealthcontribTXTBOX.Enabled = false;
            taxcontribTXTBOX.Enabled = false;
        }
        private void other_hoursTXTBOX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                other_numhrs = Convert.ToDouble(other_hoursTXTBOX.Text);
                other_rate = Convert.ToDouble(other_rateTXTBOX.Text);
                other_netincome = other_numhrs * other_rate;
                other_totincomepayTXTBOX.Text = other_netincome.ToString("n");

                gross_income = basic_netincome + hono_netincome + other_netincome;
                grossincTXTBOX.Text = gross_income.ToString("n");

                double philhealth_value = 0;
                if (gross_income < 10000)
                {
                    philhealth_value = 137.50;
                }
                else
                {
                    double philhealth_employshare = 137.50;
                    for (int x = 10000; x <= 40000; x += 1000)
                    {
                        if (gross_income >= x && gross_income < x + 1000 || gross_income > x + 1000)
                        {
                            philhealth_value = philhealth_employshare;
                        }
                        philhealth_employshare += 13.75;
                    }
                }
                philhealthcontribTXTBOX.Text = philhealth_value.ToString("N");

                double sss_value = 0;
                if (gross_income <= 1000)
                {
                    sss_value = 36.30;
                }
                else
                {
                    double sss_employshare = 36.30;
                    for (int x = 1000; x <= 15750; x += 500)
                    {
                        if (gross_income >= x && gross_income < x + 500 || gross_income > x + 500)
                        {
                            sss_value = sss_employshare;
                        }
                        sss_employshare += 18.15;
                    }
                }
                ssscontribTXTBOX.Text = sss_value.ToString("N");

                if (gross_income < (250000 / 24))
                {
                    taxcontribTXTBOX.Text = "0.00";
                }
                else if (gross_income > 10416.67 && gross_income <= 16666.67)
                {
                    tax = ((((gross_income * 24) - 250000) * 0.20) / 24);
                    taxcontribTXTBOX.Text = tax.ToString("n");
                }
                else if (gross_income > 16666.67 && gross_income <= 33333.33)
                {
                    tax = (((((gross_income * 24) - 400000) * 0.25) + 30000) / 24);
                    taxcontribTXTBOX.Text = tax.ToString("n");
                }
                else if (gross_income > 33333.33 && gross_income <= 83333.33)
                {
                    tax = (((((gross_income * 24) - 800000) * 0.30) + 130000) / 24);
                    taxcontribTXTBOX.Text = tax.ToString("n");
                }
                else if (gross_income > 83333.33 && gross_income <= 333333.33)
                {
                    tax = (((((gross_income * 24) - 2000000) * 0.32) + 490000) / 24);
                    taxcontribTXTBOX.Text = tax.ToString("n");
                }
                else
                {
                    tax = (((((gross_income * 24) - 8000000) * 0.35) + 2410000) / 24);
                    taxcontribTXTBOX.Text = tax.ToString("n");
                }
                pagibigcontribTXTBOX.Text = "100";
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void calcBTN_Click(object sender, EventArgs e)
        {
            try
            {
                sss_contrib = Convert.ToDouble(ssscontribTXTBOX.Text);
                pagibig_contrib = Convert.ToDouble(pagibigcontribTXTBOX.Text);
                philhealth_contrib = Convert.ToDouble(philhealthcontribTXTBOX.Text);
                tax = Convert.ToDouble(taxcontribTXTBOX.Text);
                total_deductions = sss_contrib + pagibig_contrib + philhealth_contrib + tax;
                net_income = gross_income - total_deductions;
                netincTXTBOX.Text = net_income.ToString("C");
                totdeductTXTBOX.Text = total_deductions.ToString("C");
                grossincTXTBOX.Text = gross_income.ToString("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void basic_hoursTXTBOX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                basic_numhrs = Convert.ToDouble(basic_hoursTXTBOX.Text);
                basic_rate = Convert.ToDouble(basic_rateTXTBOX.Text);
                basic_netincome = basic_numhrs * basic_rate;
                basic_inccutoffTXTBOX.Text = basic_netincome.ToString("n");

                gross_income = basic_netincome + hono_netincome + other_netincome;
                grossincTXTBOX.Text = gross_income.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void honor_hoursTXTBOX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(honor_hoursTXTBOX.Text);
                hono_rate = Convert.ToDouble(honor_rateTXTBOX.Text);
                hono_netincome = hono_numhrs * hono_rate;
                honor_tothonorpayTXTBOX.Text = hono_netincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
