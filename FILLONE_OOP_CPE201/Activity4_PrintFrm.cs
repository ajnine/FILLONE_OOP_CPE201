using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class Activity4_PrintFrm : Form
    {
        public Activity4_PrintFrm()
        {
            InitializeComponent();
            // to display all contents of the listbox from Activity4.cs to this current form
            printDisplayListBox.Items.AddRange(printDisplayListBox.Items);
        }
        
        private void Activity4_PrintFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
