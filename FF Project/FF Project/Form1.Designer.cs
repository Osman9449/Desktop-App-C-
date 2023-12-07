namespace Desktop_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button_register = new Button();
            button_login = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(76, 80);
            label1.Name = "label1";
            label1.Size = new Size(630, 47);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO CAR MANAGEMENT APP";
            // 
            // button_register
            // 
            button_register.BackColor = SystemColors.MenuHighlight;
            button_register.Location = new Point(67, 226);
            button_register.Name = "button_register";
            button_register.Size = new Size(195, 77);
            button_register.TabIndex = 1;
            button_register.Text = "REGISTER";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_register_Click;
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.MenuHighlight;
            button_login.Location = new Point(288, 226);
            button_login.Name = "button_login";
            button_login.Size = new Size(195, 77);
            button_login.TabIndex = 2;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = SystemColors.MenuHighlight;
            button_exit.Location = new Point(511, 226);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(195, 77);
            button_exit.TabIndex = 3;
            button_exit.Text = "EXIT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(button_exit);
            Controls.Add(button_login);
            Controls.Add(button_register);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_register;
        private Button button_login;
        private Button button_exit;
    }
}
