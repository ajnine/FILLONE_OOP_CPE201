using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class while_loop : Form
    {
        public while_loop()
        {
            InitializeComponent();
        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            int InitialValue = 0;
            int numTimesDisplay;
            numTimesDisplay = Convert.ToInt32(numberTXTBOX.Text);
            do
            {
                dsplaylistbox.Items.Add(countryCMBBOX.Text);
                InitialValue++;

            }
            while (InitialValue <= numTimesDisplay);
        }

        private void while_loop_Load(object sender, EventArgs e)
        {
            countryCMBBOX.Items.Add("South Korea");
            countryCMBBOX.Items.Add("Thailand");
            countryCMBBOX.Items.Add("Hawaii");
            countryCMBBOX.Items.Add("Hongkong");
            countryCMBBOX.Items.Add("Canada");
            countryCMBBOX.Items.Add("Japan");
        }
    }
}
