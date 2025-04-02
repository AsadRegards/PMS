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
            SignupBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            inputPhoneNumber = new TextBox();
            inputFullName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputPassword = new TextBox();
            inputLoginName = new TextBox();
            loginLink = new LinkLabel();
            SuspendLayout();
            // 
            // SignupBtn
            // 
            SignupBtn.Location = new Point(339, 309);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(130, 64);
            SignupBtn.TabIndex = 11;
            SignupBtn.Text = "Signup";
            SignupBtn.UseVisualStyleBackColor = true;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 172);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 10;
            label3.Text = "Phone No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 124);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 9;
            label2.Text = "Full Name";
            // 
            // inputPhoneNumber
            // 
            inputPhoneNumber.Location = new Point(250, 170);
            inputPhoneNumber.Name = "inputPhoneNumber";
            inputPhoneNumber.Size = new Size(312, 27);
            inputPhoneNumber.TabIndex = 8;
            // 
            // inputFullName
            // 
            inputFullName.Location = new Point(250, 122);
            inputFullName.Name = "inputFullName";
            inputFullName.Size = new Size(312, 27);
            inputFullName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 54);
            label1.Name = "label1";
            label1.Size = new Size(90, 31);
            label1.TabIndex = 6;
            label1.Text = "Signup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(135, 265);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(135, 218);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 14;
            label5.Text = "Username";
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(250, 266);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(312, 27);
            inputPassword.TabIndex = 13;
            // 
            // inputLoginName
            // 
            inputLoginName.Location = new Point(250, 218);
            inputLoginName.Name = "inputLoginName";
            inputLoginName.Size = new Size(312, 27);
            inputLoginName.TabIndex = 12;
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.Location = new Point(339, 400);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(135, 20);
            loginLink.TabIndex = 16;
            loginLink.TabStop = true;
            loginLink.Text = "Click Here to Login";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignupBtn;
        private Label label3;
        private Label label2;
        private TextBox inputPhoneNumber;
        private TextBox inputFullName;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox inputPassword;
        private TextBox inputLoginName;
        private LinkLabel loginLink;
    }
}