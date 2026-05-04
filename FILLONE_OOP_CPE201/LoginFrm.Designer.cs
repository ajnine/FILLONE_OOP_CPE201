namespace FILLONE_OOP_CPE201
{
    partial class LoginFrm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            usernameTXTBOX = new TextBox();
            passwordTXTBX = new TextBox();
            loginBTN = new Button();
            cancelBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(150, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 131);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 201);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 249);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // usernameTXTBOX
            // 
            usernameTXTBOX.Location = new Point(150, 198);
            usernameTXTBOX.Name = "usernameTXTBOX";
            usernameTXTBOX.Size = new Size(183, 27);
            usernameTXTBOX.TabIndex = 3;
            // 
            // passwordTXTBX
            // 
            passwordTXTBX.Location = new Point(150, 246);
            passwordTXTBX.Name = "passwordTXTBX";
            passwordTXTBX.Size = new Size(183, 27);
            passwordTXTBX.TabIndex = 4;
            // 
            // loginBTN
            // 
            loginBTN.Location = new Point(124, 295);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(94, 29);
            loginBTN.TabIndex = 5;
            loginBTN.Text = "Login";
            loginBTN.UseVisualStyleBackColor = true;
            loginBTN.Click += loginBTN_Click;
            // 
            // cancelBTN
            // 
            cancelBTN.Location = new Point(224, 295);
            cancelBTN.Name = "cancelBTN";
            cancelBTN.Size = new Size(94, 29);
            cancelBTN.TabIndex = 6;
            cancelBTN.Text = "Cancel";
            cancelBTN.UseVisualStyleBackColor = true;
            cancelBTN.Click += cancelBTN_Click;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 384);
            Controls.Add(cancelBTN);
            Controls.Add(loginBTN);
            Controls.Add(passwordTXTBX);
            Controls.Add(usernameTXTBOX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginFrm";
            Text = "LoginFrm";
            Load += LoginFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox usernameTXTBOX;
        private TextBox passwordTXTBX;
        private Button loginBTN;
        private Button cancelBTN;
    }
}