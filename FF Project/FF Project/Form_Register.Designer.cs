namespace Desktop_App
{
    partial class Form_Register
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxFullName = new TextBox();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxAgainPassword = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            maskedTextBoxPhoneNumber = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(283, 39);
            label1.Name = "label1";
            label1.Size = new Size(260, 47);
            label1.TabIndex = 0;
            label1.Text = "REGISTER HERE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(229, 120);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(227, 168);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 2;
            label3.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(227, 211);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(227, 256);
            label5.Name = "label5";
            label5.Size = new Size(179, 32);
            label5.TabIndex = 4;
            label5.Text = "Again Password";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(459, 124);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(164, 27);
            textBoxFullName.TabIndex = 5;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(459, 173);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(164, 27);
            textBoxUserName.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(459, 216);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(164, 27);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxAgainPassword
            // 
            textBoxAgainPassword.Location = new Point(459, 261);
            textBoxAgainPassword.Name = "textBoxAgainPassword";
            textBoxAgainPassword.Size = new Size(164, 27);
            textBoxAgainPassword.TabIndex = 8;
            textBoxAgainPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = SystemColors.InfoText;
            label7.Location = new Point(229, 299);
            label7.Name = "label7";
            label7.Size = new Size(231, 30);
            label7.TabIndex = 10;
            label7.Text = "Phone Number (+944)";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(229, 362);
            button1.Name = "button1";
            button1.Size = new Size(174, 60);
            button1.TabIndex = 12;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Location = new Point(449, 362);
            button2.Name = "button2";
            button2.Size = new Size(174, 60);
            button2.TabIndex = 13;
            button2.Text = "MAIN MENU";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // maskedTextBoxPhoneNumber
            // 
            maskedTextBoxPhoneNumber.Culture = new System.Globalization.CultureInfo("az-Latn-AZ");
            maskedTextBoxPhoneNumber.InsertKeyMode = InsertKeyMode.Insert;
            maskedTextBoxPhoneNumber.Location = new Point(459, 302);
            maskedTextBoxPhoneNumber.Mask = "(00)-000-00-00";
            maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            maskedTextBoxPhoneNumber.Size = new Size(164, 27);
            maskedTextBoxPhoneNumber.TabIndex = 14;
            // 
            // Form_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBoxPhoneNumber);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBoxAgainPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxFullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxFullName;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private TextBox textBoxAgainPassword;
        private Label label7;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBoxPhoneNumber;
    }
}