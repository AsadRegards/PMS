namespace PMS
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            SignupBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            inputPhoneNumber = new TextBox();
            inputFullName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            inputPassword = new TextBox();
            inputLoginName = new TextBox();
            loginLink = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = Color.FromArgb(254, 94, 0);
            SignupBtn.FlatStyle = FlatStyle.Flat;
            SignupBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.Location = new Point(333, 242);
            SignupBtn.Margin = new Padding(3, 2, 3, 2);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(114, 33);
            SignupBtn.TabIndex = 11;
            SignupBtn.Text = "Signup";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(16, 22, 59);
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 136);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 10;
            label3.Text = "Phone No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(16, 22, 59);
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 106);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 9;
            label2.Text = "Full Name";
            // 
            // inputPhoneNumber
            // 
            inputPhoneNumber.BackColor = Color.FromArgb(246, 246, 246);
            inputPhoneNumber.Location = new Point(182, 139);
            inputPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            inputPhoneNumber.Name = "inputPhoneNumber";
            inputPhoneNumber.Size = new Size(252, 23);
            inputPhoneNumber.TabIndex = 8;
            // 
            // inputFullName
            // 
            inputFullName.BackColor = Color.FromArgb(246, 246, 246);
            inputFullName.Location = new Point(181, 107);
            inputFullName.Margin = new Padding(3, 2, 3, 2);
            inputFullName.Name = "inputFullName";
            inputFullName.Size = new Size(252, 23);
            inputFullName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(16, 22, 59);
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(79, 201);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(16, 22, 59);
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(79, 166);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 14;
            label5.Text = "Username";
            // 
            // inputPassword
            // 
            inputPassword.BackColor = Color.FromArgb(246, 246, 246);
            inputPassword.Location = new Point(182, 211);
            inputPassword.Margin = new Padding(3, 2, 3, 2);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(252, 23);
            inputPassword.TabIndex = 13;
            // 
            // inputLoginName
            // 
            inputLoginName.BackColor = Color.FromArgb(246, 246, 246);
            inputLoginName.Location = new Point(182, 175);
            inputLoginName.Margin = new Padding(3, 2, 3, 2);
            inputLoginName.Name = "inputLoginName";
            inputLoginName.Size = new Size(252, 23);
            inputLoginName.TabIndex = 12;
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.Location = new Point(335, 282);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(108, 15);
            loginLink.TabIndex = 16;
            loginLink.TabStop = true;
            loginLink.Text = "Click Here to Login";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-38, -53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(168, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(471, 73);
            panel2.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(432, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(16, 22, 59);
            label6.Location = new Point(197, 27);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 0;
            label6.Text = "SIGNUP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 22, 59);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 338);
            panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(165, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(462, 351);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 338);
            Controls.Add(panel2);
            Controls.Add(loginLink);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(inputPassword);
            Controls.Add(inputLoginName);
            Controls.Add(SignupBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputPhoneNumber);
            Controls.Add(inputFullName);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignupBtn;
        private Label label3;
        private Label label2;
        private TextBox inputPhoneNumber;
        private TextBox inputFullName;
        private Label label4;
        private Label label5;
        private TextBox inputPassword;
        private TextBox inputLoginName;
        private LinkLabel loginLink;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label6;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}