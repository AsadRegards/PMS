namespace PMS
{
    partial class Login
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
            inputLoginName = new TextBox();
            inputPasword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginBtn = new Button();
            SignupLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 72);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // inputLoginName
            // 
            inputLoginName.Location = new Point(275, 139);
            inputLoginName.Name = "inputLoginName";
            inputLoginName.Size = new Size(312, 27);
            inputLoginName.TabIndex = 1;
            // 
            // inputPasword
            // 
            inputPasword.Location = new Point(275, 200);
            inputPasword.Name = "inputPasword";
            inputPasword.Size = new Size(312, 27);
            inputPasword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 141);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 200);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(351, 253);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(130, 64);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignupLink
            // 
            SignupLink.AutoSize = true;
            SignupLink.Location = new Point(304, 349);
            SignupLink.Name = "SignupLink";
            SignupLink.Size = new Size(233, 20);
            SignupLink.TabIndex = 6;
            SignupLink.TabStop = true;
            SignupLink.Text = "Click Here to Create New Account";
            SignupLink.LinkClicked += SignupLink_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignupLink);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputPasword);
            Controls.Add(inputLoginName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputLoginName;
        private TextBox inputPasword;
        private Label label2;
        private Label label3;
        private Button LoginBtn;
        private LinkLabel SignupLink;
    }
}