using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FILLONE_OOP_CPE201
{
    public partial class Lesson3Activity : Form
    {
        public Lesson3Activity()
        {
            InitializeComponent();
        }

        double ComLabFee = 0;
        double SAPFee = 2000;
        double CISCOLabFee = 4500;
        double ExamBookletFee = 450;

        double installmentCharge = 8000;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Lesson3Activity_Load(object sender, EventArgs e)
        {

            // question 2a
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

            // letter m
            modeCMBBOX.Items.Add("Installment");
            mode_paymentTXTBOX.Text = "Installment"; 
            
            installmaent_changeTXTBOX.Text = installmentCharge.ToString();

           


            //  other school fees
            comlab_feeTXTBOX.Text = ComLabFee.ToString();
            SAP_feeTXTBOX.Text = SAPFee.ToString();
            CISCOlabfeeTXTBOX.Text = CISCOLabFee.ToString();
            exambookletTXTBOX.Text = ExamBookletFee.ToString();

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
            if (cred_sevenTXTBOX.Text != "" && cred_sixTXTBOX.Text != "" && cred_fiveTXTBOX.Text != "" && cred_fourTXTBOX.Text != "" && cred_threeTXTBOX.Text != "" && cred_twoTXTBOX.Text != "" && cred_oneTXTBOX.Text != "")
            {
                double temp_cred1 = Convert.ToInt32(cred_oneTXTBOX.Text);
                double temp_cred2 = Convert.ToInt32(cred_twoTXTBOX.Text);
                double temp_cred3 = Convert.ToInt32(cred_threeTXTBOX.Text);
                double temp_cred4 = Convert.ToInt32(cred_fourTXTBOX.Text);
                double temp_cred5 = Convert.ToInt32(cred_fiveTXTBOX.Text);
                double temp_cred6 = Convert.ToInt32(cred_sixTXTBOX.Text);
                double temp_cred7 = Convert.ToInt32(cred_sevenTXTBOX.Text);
                double temp_credtotal = temp_cred1 + temp_cred2 + temp_cred3 + temp_cred4 + temp_cred5 + temp_cred6 + temp_cred7;
                totalcredTXTBOX.Text = temp_credtotal.ToString();
                //totalcredTXTBOX.Text = (Convert.ToInt32(cred_oneTXTBOX.Text) + Convert.ToInt32(cred_twoTXTBOX.Text) + Convert.ToInt32(cred_threeTXTBOX.Text) + Convert.ToInt32(cred_fourTXTBOX.Text) + Convert.ToInt32(cred_fiveTXTBOX.Text) + Convert.ToInt32(cred_sixTXTBOX.Text) + Convert.ToInt32(cred_sevenTXTBOX.Text)).ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // question 2b
        private void lec_oneTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_oneTXTBOX.Text != "" && lab_oneTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_oneTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_oneTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_oneTXTBOX.Text =temp_credunit.ToString();
                //cred_oneTXTBOX.Text = (Convert.ToInt32(lec_oneTXTBOX.Text) + Convert.ToInt32(lab_oneTXTBOX.Text)).ToString();
            }
        }


        private void clearstud_infoBTN_Click(object sender, EventArgs e)
        {
            stud_nameTXTBOX.Clear();
            student_noTXTBOX.Clear();
        }


        private void computeBTN_Click(object sender, EventArgs e)
        {
            // letter i = total tuition
            double total_lecunits = Convert.ToInt32(lec_oneTXTBOX.Text) + Convert.ToInt32(lec_twoTXTBOX.Text) + Convert.ToInt32(lec_threeTXTBOX.Text) + Convert.ToInt32(lec_fourTXTBOX.Text) + Convert.ToInt32(lec_fiveTXTBOX.Text) + Convert.ToInt32(lec_sixTXTBOX.Text) + Convert.ToInt32(lec_sevenTXTBOX.Text);
            double totalTuition = Convert.ToInt32(totalcredTXTBOX.Text) * 1500;
            totaltuitionfeeTXTBOX.Text = totalTuition.ToString();

            // letter j = total misc
            double totallabunits = (Convert.ToDouble(lab_oneTXTBOX.Text) + Convert.ToDouble(lab_twoTXTBOX.Text) + Convert.ToDouble(lab_threeTXTBOX.Text) + Convert.ToDouble(lab_fourTXTBOX.Text) + Convert.ToDouble(lab_fiveTXTBOX.Text) + Convert.ToDouble(lab_sixTXTBOX.Text) + Convert.ToDouble(lab_sevenTXTBOX.Text));
            ComLabFee = totallabunits * 2500;
            comlab_feeTXTBOX.Text=ComLabFee.ToString();
            double totalMisc = ComLabFee + SAPFee + CISCOLabFee + ExamBookletFee;

            // same as total others fee
            otherfeesTXTBOX.Text = totalMisc.ToString();
            total_miscfeeTXTBOX.Text = totalMisc.ToString();

            // letter k = computer laboratory fee
            ComLabFee = (Convert.ToDouble(lab_oneTXTBOX.Text) + Convert.ToDouble(lab_twoTXTBOX.Text) + Convert.ToDouble(lab_threeTXTBOX.Text) + Convert.ToDouble(lab_fourTXTBOX.Text) + Convert.ToDouble(lab_fiveTXTBOX.Text) + Convert.ToDouble(lab_sixTXTBOX.Text) + Convert.ToDouble(lab_sevenTXTBOX.Text)) * 2500;

            double total_tuition_and_fees = totalTuition + totalMisc;
            tuitionandfees_totalTXTBOX.Text = total_tuition_and_fees.ToString();

            double installment_fee = (total_tuition_and_fees - 8000) / 3;
            first_installTXTBOX.Text = installment_fee.ToString("C");
            second_installTXTBOX.Text = installment_fee.ToString("C");
            third_installTXTBOX.Text = installment_fee.ToString("C");
        }

        private void clearsched_coursesBTN_Click(object sender, EventArgs e)
        {
            // question 2d

            // clear all course code
            codeoneTXTBOX.Clear();
            codetwoTXTBOX.Clear();
            codethreeTXTBOX.Clear();
            codefourTXTBOX.Clear();
            codefiveTXTBOX.Clear();
            codesixTXTBOX.Clear();
            codesevenTXTBOX.Clear();

            // clear all section
            sec_oneTXTBOX.Clear();
            sec_twoTXTBOX.Clear();
            sec_threeTXTBOX.Clear();
            sec_fourTXTBOX.Clear();
            sec_fiveTXTBOX.Clear();
            sec_sixTXTBOX.Clear();
            sec_sevenTXTBOX.Clear();

            // clear all description
            desc_oneTXTBOX.Clear();
            desc_twoTXTBOX.Clear();
            desc_threeTXTBOX.Clear();
            desc_fourTXTBOX.Clear();
            desc_fiveTXTBOX.Clear();
            desc_sixTXTBOX.Clear();
            desc_sevenTXTBOX.Clear();

            // clear all lec units
            lec_oneTXTBOX.Clear();
            lec_twoTXTBOX.Clear();
            lec_threeTXTBOX.Clear();
            lec_fourTXTBOX.Clear();
            lec_fiveTXTBOX.Clear();
            lec_sixTXTBOX.Clear();
            lec_sevenTXTBOX.Clear();

            // clear all lab units
            lab_oneTXTBOX.Clear();
            lab_twoTXTBOX.Clear();
            lab_threeTXTBOX.Clear();
            lab_fourTXTBOX.Clear();
            lab_fiveTXTBOX.Clear();
            lab_sixTXTBOX.Clear();
            lab_sevenTXTBOX.Clear();

            // clear all credit units
            cred_oneTXTBOX.Clear();
            cred_twoTXTBOX.Clear();
            cred_threeTXTBOX.Clear();
            cred_fourTXTBOX.Clear();
            cred_fiveTXTBOX.Clear();
            cred_sixTXTBOX.Clear();
            cred_sevenTXTBOX.Clear();

            // clear all time
            time_oneTXTBOX.Clear();
            time_twoTXTBOX.Clear();
            time_threeTXTBOX.Clear();
            time_fourTXTBOX.Clear();
            time_fiveTXTBOX.Clear();
            time_sixTXTBOX.Clear();
            time_sevenTXTBOX.Clear();

            // clear all day
            day_oneTXTBOX.Clear();
            day_twoTXTBOX.Clear();
            day_threeTXTBOX.Clear();
            day_fourTXTBOX.Clear();
            day_fiveTXTBOX.Clear();
            day_sixTXTBOX.Clear();
            day_sevenTXTBOX.Clear();

            // clear all room
            rm_oneTXTBOX.Clear();
            rm_twoTXTBOX.Clear();
            rm_threeTXTBOX.Clear();
            rm_fourTXTBOX.Clear();
            rm_fiveTXTBOX.Clear();
            rm_sixTXTBOX.Clear();
            rm_sevenTXTBOX.Clear();
        }

        private void lab_oneTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_oneTXTBOX.Text != "" && lab_oneTXTBOX.Text != "")
            {
                
                double temp_labunit = Convert.ToInt32(lab_oneTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_oneTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_oneTXTBOX.Text = temp_credunit.ToString();
                //cred_oneTXTBOX.Text = (Convert.ToInt32(lec_oneTXTBOX.Text) + Convert.ToInt32(lab_oneTXTBOX.Text)).ToString();
            }
        }

        private void lec_twoTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_twoTXTBOX.Text != "" && lab_twoTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_twoTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_twoTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_twoTXTBOX.Text = temp_credunit.ToString();
                //cred_twoTXTBOX.Text = (Convert.ToInt32(lec_twoTXTBOX.Text) + Convert.ToInt32(lab_twoTXTBOX.Text)).ToString();
            }
        }

        private void lab_twoTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_twoTXTBOX.Text != "" && lab_twoTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_twoTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_twoTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_twoTXTBOX.Text = temp_credunit.ToString();
                //cred_twoTXTBOX.Text = (Convert.ToInt32(lec_twoTXTBOX.Text) + Convert.ToInt32(lab_twoTXTBOX.Text)).ToString();
            }
        }

        private void lec_threeTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_threeTXTBOX.Text != "" && lab_threeTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_threeTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_threeTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_threeTXTBOX.Text = temp_credunit.ToString();
                //cred_threeTXTBOX.Text = (Convert.ToInt32(lec_threeTXTBOX.Text) + Convert.ToInt32(lab_threeTXTBOX.Text)).ToString();
            }
        }

        private void lab_threeTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_threeTXTBOX.Text != "" && lab_threeTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_threeTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_threeTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_threeTXTBOX.Text = temp_credunit.ToString();
                //cred_threeTXTBOX.Text = (Convert.ToInt32(lec_threeTXTBOX.Text) + Convert.ToInt32(lab_threeTXTBOX.Text)).ToString();
            }
        }

        private void lec_fourTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_fourTXTBOX.Text != "" && lab_fourTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_fourTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_fourTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_fourTXTBOX.Text = temp_credunit.ToString();
                //cred_fourTXTBOX.Text = (Convert.ToInt32(lec_fourTXTBOX.Text) + Convert.ToInt32(lab_fourTXTBOX.Text)).ToString();
            }
        }

        private void lab_fourTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_fourTXTBOX.Text != "" && lab_fourTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_fourTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_fourTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_fourTXTBOX.Text = temp_credunit.ToString();
                //cred_fourTXTBOX.Text = (Convert.ToInt32(lec_fourTXTBOX.Text) + Convert.ToInt32(lab_fourTXTBOX.Text)).ToString();
            }
        }

        private void lec_fiveTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_fiveTXTBOX.Text != "" && lab_fiveTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_fiveTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_fiveTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_fiveTXTBOX.Text = temp_credunit.ToString();
                //cred_fiveTXTBOX.Text = (Convert.ToInt32(lec_fiveTXTBOX.Text) + Convert.ToInt32(lab_fiveTXTBOX.Text)).ToString();
            }
        }

        private void lab_fiveTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_fiveTXTBOX.Text != "" && lab_fiveTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_fiveTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_fiveTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_fiveTXTBOX.Text = temp_credunit.ToString();
                //cred_fiveTXTBOX.Text = (Convert.ToInt32(lec_fiveTXTBOX.Text) + Convert.ToInt32(lab_fiveTXTBOX.Text)).ToString();
            }
        }

        private void lec_sixTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_sixTXTBOX.Text != "" && lab_sixTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_sixTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_sixTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_sixTXTBOX.Text = temp_credunit.ToString();
                //cred_sixTXTBOX.Text = (Convert.ToInt32(lec_sixTXTBOX.Text) + Convert.ToInt32(lab_sixTXTBOX.Text)).ToString();
            }
        }

        private void lab_sixTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_sixTXTBOX.Text != "" && lab_sixTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_sixTXTBOX.Text) ;
                double temp_lecunit = Convert.ToInt32(lec_sixTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_sixTXTBOX.Text = temp_credunit.ToString();
                //cred_sixTXTBOX.Text = (Convert.ToInt32(lec_sixTXTBOX.Text) + Convert.ToInt32(lab_sixTXTBOX.Text)).ToString();
            }
        }

        private void lec_sevenTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_sevenTXTBOX.Text != "" && lab_sevenTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_sevenTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_sevenTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_sevenTXTBOX.Text = temp_credunit.ToString();
                //cred_sevenTXTBOX.Text = (Convert.ToInt32(lec_sevenTXTBOX.Text) + Convert.ToInt32(lab_sevenTXTBOX.Text)).ToString();
            }
        }

        private void cred_sevenTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (cred_sevenTXTBOX.Text != "" && cred_sixTXTBOX.Text != "" && cred_fiveTXTBOX.Text != "" && cred_fourTXTBOX.Text != "" && cred_threeTXTBOX.Text != "" && cred_twoTXTBOX.Text != "" && cred_oneTXTBOX.Text != "")
            {
                double temp_cred1 = Convert.ToInt32(cred_oneTXTBOX.Text);
                double temp_cred2 = Convert.ToInt32(cred_twoTXTBOX.Text);
                double temp_cred3 = Convert.ToInt32(cred_threeTXTBOX.Text);
                double temp_cred4 = Convert.ToInt32(cred_fourTXTBOX.Text);
                double temp_cred5 = Convert.ToInt32(cred_fiveTXTBOX.Text);
                double temp_cred6 = Convert.ToInt32(cred_sixTXTBOX.Text);
                double temp_cred7 = Convert.ToInt32(cred_sevenTXTBOX.Text);
                double temp_credtotal = temp_cred1 + temp_cred2 + temp_cred3 + temp_cred4 + temp_cred5 + temp_cred6 + temp_cred7;
                totalcredTXTBOX.Text= temp_credtotal.ToString();
                //totalcredTXTBOX.Text = (Convert.ToInt32(cred_oneTXTBOX.Text) + Convert.ToInt32(cred_twoTXTBOX.Text) + Convert.ToInt32(cred_threeTXTBOX.Text) + Convert.ToInt32(cred_fourTXTBOX.Text) + Convert.ToInt32(cred_fiveTXTBOX.Text) + Convert.ToInt32(cred_sixTXTBOX.Text) + Convert.ToInt32(cred_sevenTXTBOX.Text)).ToString();
            }
        }

        private void cred_sixTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (cred_sevenTXTBOX.Text != "" && cred_sixTXTBOX.Text != "" && cred_fiveTXTBOX.Text != "" && cred_fourTXTBOX.Text != "" && cred_threeTXTBOX.Text != "" && cred_twoTXTBOX.Text != "" && cred_oneTXTBOX.Text != "")
            {
                double temp_cred1 = Convert.ToInt32(cred_oneTXTBOX.Text);
                double temp_cred2 = Convert.ToInt32(cred_twoTXTBOX.Text);
                double temp_cred3 = Convert.ToInt32(cred_threeTXTBOX.Text);
                double temp_cred4 = Convert.ToInt32(cred_fourTXTBOX.Text);
                double temp_cred5 = Convert.ToInt32(cred_fiveTXTBOX.Text);
                double temp_cred6 = Convert.ToInt32(cred_sixTXTBOX.Text);
                double temp_cred7 = Convert.ToInt32(cred_sevenTXTBOX.Text);
                double temp_credtotal = temp_cred1 + temp_cred2 + temp_cred3 + temp_cred4 + temp_cred5 + temp_cred6 + temp_cred7;
                totalcredTXTBOX.Text = temp_credtotal.ToString();
                //totalcredTXTBOX.Text = (Convert.ToInt32(cred_oneTXTBOX.Text) + Convert.ToInt32(cred_twoTXTBOX.Text) + Convert.ToInt32(cred_threeTXTBOX.Text) + Convert.ToInt32(cred_fourTXTBOX.Text) + Convert.ToInt32(cred_fiveTXTBOX.Text) + Convert.ToInt32(cred_sixTXTBOX.Text) + Convert.ToInt32(cred_sevenTXTBOX.Text)).ToString();
            }
        }

        private void cred_fiveTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (cred_sevenTXTBOX.Text != "" && cred_sixTXTBOX.Text != "" && cred_fiveTXTBOX.Text != "" && cred_fourTXTBOX.Text != "" && cred_threeTXTBOX.Text != "" && cred_twoTXTBOX.Text != "" && cred_oneTXTBOX.Text != "")
            {
                double temp_cred1 = Convert.ToInt32(cred_oneTXTBOX.Text);
                double temp_cred2 = Convert.ToInt32(cred_twoTXTBOX.Text);
                double temp_cred3 = Convert.ToInt32(cred_threeTXTBOX.Text);
                double temp_cred4 = Convert.ToInt32(cred_fourTXTBOX.Text);
                double temp_cred5 = Convert.ToInt32(cred_fiveTXTBOX.Text);
                double temp_cred6 = Convert.ToInt32(cred_sixTXTBOX.Text);
                double temp_cred7 = Convert.ToInt32(cred_sevenTXTBOX.Text);
                double temp_credtotal = temp_cred1 + temp_cred2 + temp_cred3 + temp_cred4 + temp_cred5 + temp_cred6 + temp_cred7;
                totalcredTXTBOX.Text = temp_credtotal.ToString();
                //totalcredTXTBOX.Text = (Convert.ToInt32(cred_oneTXTBOX.Text) + Convert.ToInt32(cred_twoTXTBOX.Text) + Convert.ToInt32(cred_threeTXTBOX.Text) + Convert.ToInt32(cred_fourTXTBOX.Text) + Convert.ToInt32(cred_fiveTXTBOX.Text) + Convert.ToInt32(cred_sixTXTBOX.Text) + Convert.ToInt32(cred_sevenTXTBOX.Text)).ToString();
            }
        }

        private void cred_fourTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (cred_sevenTXTBOX.Text != "" && cred_sixTXTBOX.Text != "" && cred_fiveTXTBOX.Text != "" && cred_fourTXTBOX.Text != "" && cred_threeTXTBOX.Text != "" && cred_twoTXTBOX.Text != "" && cred_oneTXTBOX.Text != "")
            {
                double temp_cred1 = Convert.ToInt32(cred_oneTXTBOX.Text);
                double temp_cred2 = Convert.ToInt32(cred_twoTXTBOX.Text);
                double temp_cred3 = Convert.ToInt32(cred_threeTXTBOX.Text);
                double temp_cred4 = Convert.ToInt32(cred_fourTXTBOX.Text);
                double temp_cred5 = Convert.ToInt32(cred_fiveTXTBOX.Text);
                double temp_cred6 = Convert.ToInt32(cred_sixTXTBOX.Text);
                double temp_cred7 = Convert.ToInt32(cred_sevenTXTBOX.Text);
                double temp_credtotal = temp_cred1 + temp_cred2 + temp_cred3 + temp_cred4 + temp_cred5 + temp_cred6 + temp_cred7;
                totalcredTXTBOX.Text = temp_credtotal.ToString();
                //totalcredTXTBOX.Text = (Convert.ToInt32(cred_oneTXTBOX.Text) + Convert.ToInt32(cred_twoTXTBOX.Text) + Convert.ToInt32(cred_threeTXTBOX.Text) + Convert.ToInt32(cred_fourTXTBOX.Text) + Convert.ToInt32(cred_fiveTXTBOX.Text) + Convert.ToInt32(cred_sixTXTBOX.Text) + Convert.ToInt32(cred_sevenTXTBOX.Text)).ToString();
            }
        }

        private void cred_threeTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (cred_sevenTXTBOX.Text != "" && cred_sixTXTBOX.Text != "" && cred_fiveTXTBOX.Text != "" && cred_fourTXTBOX.Text != "" && cred_threeTXTBOX.Text != "" && cred_twoTXTBOX.Text != "" && cred_oneTXTBOX.Text != "")
            {
                double temp_cred1 = Convert.ToInt32(cred_oneTXTBOX.Text);
                double temp_cred2 = Convert.ToInt32(cred_twoTXTBOX.Text);
                double temp_cred3 = Convert.ToInt32(cred_threeTXTBOX.Text);
                double temp_cred4 = Convert.ToInt32(cred_fourTXTBOX.Text);
                double temp_cred5 = Convert.ToInt32(cred_fiveTXTBOX.Text);
                double temp_cred6 = Convert.ToInt32(cred_sixTXTBOX.Text);
                double temp_cred7 = Convert.ToInt32(cred_sevenTXTBOX.Text);
                double temp_credtotal = temp_cred1 + temp_cred2 + temp_cred3 + temp_cred4 + temp_cred5 + temp_cred6 + temp_cred7;
                totalcredTXTBOX.Text = temp_credtotal.ToString();
                //totalcredTXTBOX.Text = (Convert.ToInt32(cred_oneTXTBOX.Text) + Convert.ToInt32(cred_twoTXTBOX.Text) + Convert.ToInt32(cred_threeTXTBOX.Text) + Convert.ToInt32(cred_fourTXTBOX.Text) + Convert.ToInt32(cred_fiveTXTBOX.Text) + Convert.ToInt32(cred_sixTXTBOX.Text) + Convert.ToInt32(cred_sevenTXTBOX.Text)).ToString();
            }
        }

        private void cred_twoTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (cred_sevenTXTBOX.Text != "" && cred_sixTXTBOX.Text != "" && cred_fiveTXTBOX.Text != "" && cred_fourTXTBOX.Text != "" && cred_threeTXTBOX.Text != "" && cred_twoTXTBOX.Text != "" && cred_oneTXTBOX.Text != "")
            {
                double temp_cred1 = Convert.ToInt32(cred_oneTXTBOX.Text);
                double temp_cred2 = Convert.ToInt32(cred_twoTXTBOX.Text);
                double temp_cred3 = Convert.ToInt32(cred_threeTXTBOX.Text);
                double temp_cred4 = Convert.ToInt32(cred_fourTXTBOX.Text);
                double temp_cred5 = Convert.ToInt32(cred_fiveTXTBOX.Text);
                double temp_cred6 = Convert.ToInt32(cred_sixTXTBOX.Text);
                double temp_cred7 = Convert.ToInt32(cred_sevenTXTBOX.Text);
                double temp_credtotal = temp_cred1 + temp_cred2 + temp_cred3 + temp_cred4 + temp_cred5 + temp_cred6 + temp_cred7;
                totalcredTXTBOX.Text = temp_credtotal.ToString();
                //totalcredTXTBOX.Text = (Convert.ToInt32(cred_oneTXTBOX.Text) + Convert.ToInt32(cred_twoTXTBOX.Text) + Convert.ToInt32(cred_threeTXTBOX.Text) + Convert.ToInt32(cred_fourTXTBOX.Text) + Convert.ToInt32(cred_fiveTXTBOX.Text) + Convert.ToInt32(cred_sixTXTBOX.Text) + Convert.ToInt32(cred_sevenTXTBOX.Text)).ToString();
            }
        }

        private void lab_sevenTXTBOX_TextChanged(object sender, EventArgs e)
        {
            if (lec_sevenTXTBOX.Text != "" && lab_sevenTXTBOX.Text != "")
            {
                double temp_labunit = Convert.ToInt32(lab_sevenTXTBOX.Text);
                double temp_lecunit = Convert.ToInt32(lec_sevenTXTBOX.Text);
                double temp_credunit = temp_labunit + temp_lecunit;
                cred_sevenTXTBOX.Text = temp_credunit.ToString();
                //cred_sevenTXTBOX.Text = (Convert.ToInt32(lec_sevenTXTBOX.Text) + Convert.ToInt32(lab_sevenTXTBOX.Text)).ToString();
            }
        }

        private void total_miscfeeTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
