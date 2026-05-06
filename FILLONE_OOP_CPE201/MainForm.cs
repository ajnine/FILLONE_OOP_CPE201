using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void alisFranchiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2New franchise = new Activity2New();
            franchise.MdiParent = this;
            franchise.Show();
        }

        private void pizzaNiAliyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity3 pizza = new Activity3();
            pizza.MdiParent = this;
            pizza.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 simple = new Activity1();
            simple.MdiParent = this;
            simple.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activity4PrintFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4_PrintFrm print = new Activity4_PrintFrm();
            print.MdiParent = this;
            print.Show();
        }

        private void payrolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void activity5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity5 payrol = new Activity5();
            payrol.MdiParent = this;
            payrol.Show();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity5_PrintFrm print = new Activity5_PrintFrm();
            print.MdiParent = this;
            print.Show();
        }

        private void fORLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for_loop2 loop2 = new for_loop2();
            loop2.MdiParent = this;
            loop2.Show();
        }

        private void wHILELoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while_loop loop = new while_loop();
            loop.MdiParent = this;
            loop.Show();
        }

        private void lesson2ActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson2Activity quiz = new Lesson2Activity();
            quiz.MdiParent = this;
            quiz.Show();
        }

        private void lesson3ActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson3Activity quiz = new Lesson3Activity();
            quiz.MdiParent = this;
            quiz.Show();
        }

        private void lesson5ActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5_Activity quiz = new Lesson5_Activity();
            quiz.MdiParent = this;
            quiz.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loopsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void activity1FunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1_Functions act1 = new Activity1_Functions();
            act1.MdiParent = this;
            act1.Show();
        }

        private void activity2NewFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2New_Function act2 = new Activity2New_Function();
            act2.MdiParent = this;
            act2.Show();
        }

        private void activity4FunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4_Function act4 = new Activity4_Function();
            act4.MdiParent = this;
            act4.Show();
        }

        private void activity1ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1_Class act1 = new Activity1_Class();
            act1.MdiParent = this;
            act1.Show();
        }

        private void activity2NewClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2New_Class act2 = new Activity2New_Class();
            act2.MdiParent = this;
            act2.Show();
        }

        private void activity4ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4_Class act4 = new Activity4_Class();
            act4.MdiParent = this;
            act4.Show();
        }
    }
}
