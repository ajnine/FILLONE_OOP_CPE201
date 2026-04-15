namespace FILLONE_OOP_CPE201
{
    partial class while_loop
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
            numberTXTBOX = new TextBox();
            showBTN = new Button();
            label2 = new Label();
            countryCMBBOX = new ComboBox();
            dsplaylistbox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 72);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter a number:";
            // 
            // numberTXTBOX
            // 
            numberTXTBOX.Location = new Point(188, 69);
            numberTXTBOX.Name = "numberTXTBOX";
            numberTXTBOX.Size = new Size(171, 27);
            numberTXTBOX.TabIndex = 1;
            // 
            // showBTN
            // 
            showBTN.Location = new Point(365, 68);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(104, 29);
            showBTN.TabIndex = 2;
            showBTN.Text = "SHOW";
            showBTN.UseVisualStyleBackColor = true;
            showBTN.Click += showBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 127);
            label2.Name = "label2";
            label2.Size = new Size(320, 20);
            label2.TabIndex = 3;
            label2.Text = "SELECT COUNTRY TO DISPLAY AT THE LISTBOX";
            // 
            // countryCMBBOX
            // 
            countryCMBBOX.FormattingEnabled = true;
            countryCMBBOX.Location = new Point(74, 156);
            countryCMBBOX.Name = "countryCMBBOX";
            countryCMBBOX.Size = new Size(365, 28);
            countryCMBBOX.TabIndex = 4;
            countryCMBBOX.SelectedIndexChanged += countryCMBBOX_SelectedIndexChanged;
            // 
            // dsplaylistbox
            // 
            dsplaylistbox.FormattingEnabled = true;
            dsplaylistbox.Location = new Point(74, 202);
            dsplaylistbox.Name = "dsplaylistbox";
            dsplaylistbox.Size = new Size(365, 204);
            dsplaylistbox.TabIndex = 5;
            // 
            // while_loop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 497);
            Controls.Add(dsplaylistbox);
            Controls.Add(countryCMBBOX);
            Controls.Add(label2);
            Controls.Add(showBTN);
            Controls.Add(numberTXTBOX);
            Controls.Add(label1);
            Name = "while_loop";
            Text = "Do While Loop";
            Load += while_loop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numberTXTBOX;
        private Button showBTN;
        private Label label2;
        private ComboBox countryCMBBOX;
        private ListBox dsplaylistbox;
    }
}