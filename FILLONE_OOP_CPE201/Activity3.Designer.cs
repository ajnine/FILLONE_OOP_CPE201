namespace FILLONE_OOP_CPE201
{
    partial class Activity3
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
            groupBox1 = new GroupBox();
            bundleB_Rbtn = new RadioButton();
            bundleA_Rbtn = new RadioButton();
            groupBox2 = new GroupBox();
            exitbtn = new Button();
            clearbtn = new Button();
            label4 = new Label();
            orderpicturebox = new PictureBox();
            discounttxtbox = new TextBox();
            pricetxtbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            A_pizzaCheckbox = new CheckBox();
            A_sidedishesCheckbox = new CheckBox();
            A_cokeCheckbox = new CheckBox();
            A_friesCheckbox = new CheckBox();
            A_friedchickenCheckbox = new CheckBox();
            groupBox4 = new GroupBox();
            B_pizzaCheckbox = new CheckBox();
            B_friesCheckbox = new CheckBox();
            B_CarbonaraCheckbox = new CheckBox();
            B_halohaloCheckbox = new CheckBox();
            B_friedchickenCheckbox = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderpicturebox).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 38);
            label1.Name = "label1";
            label1.Size = new Size(458, 28);
            label1.TabIndex = 0;
            label1.Text = "4JEE Food Ordering Application";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bundleB_Rbtn);
            groupBox1.Controls.Add(bundleA_Rbtn);
            groupBox1.Location = new Point(26, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 138);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food Order Choices";
            // 
            // bundleB_Rbtn
            // 
            bundleB_Rbtn.AutoSize = true;
            bundleB_Rbtn.Location = new Point(42, 93);
            bundleB_Rbtn.Name = "bundleB_Rbtn";
            bundleB_Rbtn.Size = new Size(127, 24);
            bundleB_Rbtn.TabIndex = 1;
            bundleB_Rbtn.TabStop = true;
            bundleB_Rbtn.Text = "Food Bundle B";
            bundleB_Rbtn.UseVisualStyleBackColor = true;
            bundleB_Rbtn.CheckedChanged += bundleB_Rbtn_CheckedChanged;
            // 
            // bundleA_Rbtn
            // 
            bundleA_Rbtn.AutoSize = true;
            bundleA_Rbtn.Location = new Point(42, 44);
            bundleA_Rbtn.Name = "bundleA_Rbtn";
            bundleA_Rbtn.Size = new Size(128, 24);
            bundleA_Rbtn.TabIndex = 0;
            bundleA_Rbtn.TabStop = true;
            bundleA_Rbtn.Text = "Food Bundle A";
            bundleA_Rbtn.UseVisualStyleBackColor = true;
            bundleA_Rbtn.CheckedChanged += bundleA_Rbtn_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(exitbtn);
            groupBox2.Controls.Add(clearbtn);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(orderpicturebox);
            groupBox2.Controls.Add(discounttxtbox);
            groupBox2.Controls.Add(pricetxtbox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(26, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 423);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food Order Choices";
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(204, 340);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(136, 63);
            exitbtn.TabIndex = 7;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(51, 340);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(136, 63);
            clearbtn.TabIndex = 6;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 216);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 5;
            label4.Text = "Order Image:";
            // 
            // orderpicturebox
            // 
            orderpicturebox.BorderStyle = BorderStyle.Fixed3D;
            orderpicturebox.Location = new Point(132, 146);
            orderpicturebox.Name = "orderpicturebox";
            orderpicturebox.Size = new Size(212, 172);
            orderpicturebox.TabIndex = 4;
            orderpicturebox.TabStop = false;
            // 
            // discounttxtbox
            // 
            discounttxtbox.Location = new Point(132, 81);
            discounttxtbox.Name = "discounttxtbox";
            discounttxtbox.Size = new Size(212, 27);
            discounttxtbox.TabIndex = 3;
            // 
            // pricetxtbox
            // 
            pricetxtbox.Location = new Point(132, 39);
            pricetxtbox.Name = "pricetxtbox";
            pricetxtbox.Size = new Size(212, 27);
            pricetxtbox.TabIndex = 2;
            pricetxtbox.TextChanged += pricetxtbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 84);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 39);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Price:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(A_pizzaCheckbox);
            groupBox3.Controls.Add(A_sidedishesCheckbox);
            groupBox3.Controls.Add(A_cokeCheckbox);
            groupBox3.Controls.Add(A_friesCheckbox);
            groupBox3.Controls.Add(A_friedchickenCheckbox);
            groupBox3.Location = new Point(440, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(385, 275);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Food Bundles A";
            // 
            // A_pizzaCheckbox
            // 
            A_pizzaCheckbox.AutoSize = true;
            A_pizzaCheckbox.Location = new Point(68, 226);
            A_pizzaCheckbox.Name = "A_pizzaCheckbox";
            A_pizzaCheckbox.Size = new Size(170, 24);
            A_pizzaCheckbox.TabIndex = 4;
            A_pizzaCheckbox.Text = "Special Pizza Delight";
            A_pizzaCheckbox.UseVisualStyleBackColor = true;
            // 
            // A_sidedishesCheckbox
            // 
            A_sidedishesCheckbox.AutoSize = true;
            A_sidedishesCheckbox.Location = new Point(68, 176);
            A_sidedishesCheckbox.Name = "A_sidedishesCheckbox";
            A_sidedishesCheckbox.Size = new Size(119, 24);
            A_sidedishesCheckbox.TabIndex = 3;
            A_sidedishesCheckbox.Text = "4 Side Dishes";
            A_sidedishesCheckbox.UseVisualStyleBackColor = true;
            // 
            // A_cokeCheckbox
            // 
            A_cokeCheckbox.AutoSize = true;
            A_cokeCheckbox.Location = new Point(69, 128);
            A_cokeCheckbox.Name = "A_cokeCheckbox";
            A_cokeCheckbox.Size = new Size(87, 24);
            A_cokeCheckbox.TabIndex = 2;
            A_cokeCheckbox.Text = "1.5 Coke";
            A_cokeCheckbox.UseVisualStyleBackColor = true;
            // 
            // A_friesCheckbox
            // 
            A_friesCheckbox.AutoSize = true;
            A_friesCheckbox.Location = new Point(68, 78);
            A_friesCheckbox.Name = "A_friesCheckbox";
            A_friesCheckbox.Size = new Size(113, 24);
            A_friesCheckbox.TabIndex = 1;
            A_friesCheckbox.Text = "2 Large Files";
            A_friesCheckbox.UseVisualStyleBackColor = true;
            // 
            // A_friedchickenCheckbox
            // 
            A_friedchickenCheckbox.AutoSize = true;
            A_friedchickenCheckbox.Location = new Point(68, 35);
            A_friedchickenCheckbox.Name = "A_friedchickenCheckbox";
            A_friedchickenCheckbox.Size = new Size(233, 24);
            A_friedchickenCheckbox.TabIndex = 0;
            A_friedchickenCheckbox.Text = "10 pcs. Delicious Fried Chicken";
            A_friedchickenCheckbox.UseVisualStyleBackColor = true;
            A_friedchickenCheckbox.CheckedChanged += A_friedchickenCheckbox_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(B_pizzaCheckbox);
            groupBox4.Controls.Add(B_friesCheckbox);
            groupBox4.Controls.Add(B_CarbonaraCheckbox);
            groupBox4.Controls.Add(B_halohaloCheckbox);
            groupBox4.Controls.Add(B_friedchickenCheckbox);
            groupBox4.Location = new Point(440, 379);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(385, 298);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Food Bundles B";
            // 
            // B_pizzaCheckbox
            // 
            B_pizzaCheckbox.AutoSize = true;
            B_pizzaCheckbox.Location = new Point(68, 240);
            B_pizzaCheckbox.Name = "B_pizzaCheckbox";
            B_pizzaCheckbox.Size = new Size(202, 24);
            B_pizzaCheckbox.TabIndex = 9;
            B_pizzaCheckbox.Text = "1 Medium Hawaiian Pizza";
            B_pizzaCheckbox.UseVisualStyleBackColor = true;
            // 
            // B_friesCheckbox
            // 
            B_friesCheckbox.AutoSize = true;
            B_friesCheckbox.Location = new Point(68, 190);
            B_friesCheckbox.Name = "B_friesCheckbox";
            B_friesCheckbox.Size = new Size(152, 24);
            B_friesCheckbox.TabIndex = 8;
            B_friesCheckbox.Text = "1 Family Pack Fries";
            B_friesCheckbox.UseVisualStyleBackColor = true;
            // 
            // B_CarbonaraCheckbox
            // 
            B_CarbonaraCheckbox.AutoSize = true;
            B_CarbonaraCheckbox.Location = new Point(69, 142);
            B_CarbonaraCheckbox.Name = "B_CarbonaraCheckbox";
            B_CarbonaraCheckbox.Size = new Size(191, 24);
            B_CarbonaraCheckbox.TabIndex = 7;
            B_CarbonaraCheckbox.Text = "1 Family Pack Carbonara";
            B_CarbonaraCheckbox.UseVisualStyleBackColor = true;
            // 
            // B_halohaloCheckbox
            // 
            B_halohaloCheckbox.AutoSize = true;
            B_halohaloCheckbox.Location = new Point(68, 49);
            B_halohaloCheckbox.Name = "B_halohaloCheckbox";
            B_halohaloCheckbox.Size = new Size(252, 24);
            B_halohaloCheckbox.TabIndex = 5;
            B_halohaloCheckbox.Text = "4 cups Special Halo Halo Regular";
            B_halohaloCheckbox.UseVisualStyleBackColor = true;
            // 
            // B_friedchickenCheckbox
            // 
            B_friedchickenCheckbox.AutoSize = true;
            B_friedchickenCheckbox.Location = new Point(68, 92);
            B_friedchickenCheckbox.Name = "B_friedchickenCheckbox";
            B_friedchickenCheckbox.Size = new Size(225, 24);
            B_friedchickenCheckbox.TabIndex = 6;
            B_friedchickenCheckbox.Text = "6 pcs. Delicious Fried Chicken";
            B_friedchickenCheckbox.UseVisualStyleBackColor = true;
            // 
            // Activity3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 689);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Activity3";
            Text = "Form2";
            Load += Activity3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderpicturebox).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton bundleB_Rbtn;
        private RadioButton bundleA_Rbtn;
        private GroupBox groupBox2;
        private TextBox pricetxtbox;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox orderpicturebox;
        private TextBox discounttxtbox;
        private Button exitbtn;
        private Button clearbtn;
        private GroupBox groupBox3;
        private CheckBox A_pizzaCheckbox;
        private CheckBox A_sidedishesCheckbox;
        private CheckBox A_cokeCheckbox;
        private CheckBox A_friesCheckbox;
        private CheckBox A_friedchickenCheckbox;
        private GroupBox groupBox4;
        private CheckBox B_pizzaCheckbox;
        private CheckBox B_friesCheckbox;
        private CheckBox B_CarbonaraCheckbox;
        private CheckBox B_halohaloCheckbox;
        private CheckBox B_friedchickenCheckbox;
    }
}