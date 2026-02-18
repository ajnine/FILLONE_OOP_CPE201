namespace FILLONE_OOP_CPE201
{
    partial class Activity4_PrintFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            printDisplayListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(465, 28);
            label1.TabIndex = 1;
            label1.Text = "Ali's Food Ordering Application";
            // 
            // printDisplayListBox
            // 
            printDisplayListBox.FormattingEnabled = true;
            printDisplayListBox.Location = new Point(45, 75);
            printDisplayListBox.Name = "printDisplayListBox";
            printDisplayListBox.Size = new Size(397, 344);
            printDisplayListBox.TabIndex = 2;
            // 
            // Activity4_PrintFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(515, 450);
            Controls.Add(printDisplayListBox);
            Controls.Add(label1);
            Name = "Activity4_PrintFrm";
            Text = "Activity4_PrintFrm";
            Load += Activity4_PrintFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public ListBox printDisplayListBox;
    }
}