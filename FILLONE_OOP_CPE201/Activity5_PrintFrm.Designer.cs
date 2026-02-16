namespace FILLONE_OOP_CPE201
{
    partial class Activity5_PrintFrm
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
            priDisplayListbox = new ListBox();
            SuspendLayout();
            // 
            // priDisplayListbox
            // 
            priDisplayListbox.FormattingEnabled = true;
            priDisplayListbox.Location = new Point(12, 12);
            priDisplayListbox.Name = "priDisplayListbox";
            priDisplayListbox.Size = new Size(336, 424);
            priDisplayListbox.TabIndex = 0;
            priDisplayListbox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Activity5_PrintFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 450);
            Controls.Add(priDisplayListbox);
            Name = "Activity5_PrintFrm";
            Text = "Activity5_PrintFrm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox priDisplayListbox;
    }
}