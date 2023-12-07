namespace FF_Project
{
    partial class Form_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Management));
            label1 = new Label();
            textBoxSeachItem = new TextBox();
            label2 = new Label();
            buttonSearchItem = new Button();
            panel1 = new Panel();
            textBoxBrand = new TextBox();
            textBoxModel = new TextBox();
            textBoxColor = new TextBox();
            textBoxYear = new TextBox();
            buttonInsert = new Button();
            comboBoxEngine = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonShowAll = new Button();
            buttonDelete = new Button();
            label8 = new Label();
            textBoxDeleteItem = new TextBox();
            buttonUpdate = new Button();
            label9 = new Label();
            comboBoxUpdate = new ComboBox();
            label10 = new Label();
            textBoxUpdateID = new TextBox();
            textBoxNewName = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(40, 65);
            label1.Name = "label1";
            label1.Size = new Size(467, 57);
            label1.TabIndex = 1;
            label1.Text = "Car Menagement Menu";
            // 
            // textBoxSeachItem
            // 
            textBoxSeachItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSeachItem.BackColor = SystemColors.GradientActiveCaption;
            textBoxSeachItem.Font = new Font("Segoe UI", 14F);
            textBoxSeachItem.Location = new Point(880, 81);
            textBoxSeachItem.Name = "textBoxSeachItem";
            textBoxSeachItem.Size = new Size(154, 39);
            textBoxSeachItem.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(912, 41);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 3;
            label2.Text = "Search anything";
            // 
            // buttonSearchItem
            // 
            buttonSearchItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearchItem.AutoSize = true;
            buttonSearchItem.Image = (Image)resources.GetObject("buttonSearchItem.Image");
            buttonSearchItem.Location = new Point(1040, 81);
            buttonSearchItem.Name = "buttonSearchItem";
            buttonSearchItem.Size = new Size(39, 39);
            buttonSearchItem.TabIndex = 4;
            buttonSearchItem.UseVisualStyleBackColor = true;
            buttonSearchItem.Click += buttonSearchItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(buttonSearchItem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxSeachItem);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 178);
            panel1.TabIndex = 0;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Font = new Font("Segoe UI", 14F);
            textBoxBrand.Location = new Point(22, 200);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(162, 39);
            textBoxBrand.TabIndex = 1;
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Segoe UI", 14F);
            textBoxModel.Location = new Point(22, 287);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(162, 39);
            textBoxModel.TabIndex = 2;
            // 
            // textBoxColor
            // 
            textBoxColor.Font = new Font("Segoe UI", 14F);
            textBoxColor.Location = new Point(22, 378);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(162, 39);
            textBoxColor.TabIndex = 3;
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Segoe UI", 14F);
            textBoxYear.Location = new Point(220, 287);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(162, 39);
            textBoxYear.TabIndex = 4;
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = SystemColors.GradientActiveCaption;
            buttonInsert.Location = new Point(220, 356);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(162, 61);
            buttonInsert.TabIndex = 6;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = false;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // comboBoxEngine
            // 
            comboBoxEngine.Font = new Font("Segoe UI", 14F);
            comboBoxEngine.FormattingEnabled = true;
            comboBoxEngine.Items.AddRange(new object[] { "Gasoline", "Diesel", "Hybrid", "Electric" });
            comboBoxEngine.Location = new Point(220, 200);
            comboBoxEngine.Name = "comboBoxEngine";
            comboBoxEngine.Size = new Size(159, 39);
            comboBoxEngine.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.5F);
            label3.Location = new Point(62, 166);
            label3.Name = "label3";
            label3.Size = new Size(74, 31);
            label3.TabIndex = 8;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.5F);
            label4.Location = new Point(257, 166);
            label4.Name = "label4";
            label4.Size = new Size(84, 31);
            label4.TabIndex = 9;
            label4.Text = "Engine";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.5F);
            label5.Location = new Point(271, 253);
            label5.Name = "label5";
            label5.Size = new Size(57, 31);
            label5.TabIndex = 10;
            label5.Text = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.5F);
            label6.Location = new Point(68, 344);
            label6.Name = "label6";
            label6.Size = new Size(68, 31);
            label6.TabIndex = 11;
            label6.Text = "Color";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.5F);
            label7.Location = new Point(62, 253);
            label7.Name = "label7";
            label7.Size = new Size(80, 31);
            label7.TabIndex = 12;
            label7.Text = "Model";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Location = new Point(677, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 282);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Location = new Point(417, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(19, 281);
            panel3.TabIndex = 14;
            // 
            // buttonShowAll
            // 
            buttonShowAll.BackColor = SystemColors.GradientActiveCaption;
            buttonShowAll.Location = new Point(484, 356);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(162, 61);
            buttonShowAll.TabIndex = 15;
            buttonShowAll.Text = "Show All";
            buttonShowAll.UseVisualStyleBackColor = false;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.GradientActiveCaption;
            buttonDelete.Location = new Point(484, 265);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(162, 61);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.5F);
            label8.Location = new Point(498, 166);
            label8.Name = "label8";
            label8.Size = new Size(139, 31);
            label8.TabIndex = 18;
            label8.Text = "Delete by ID";
            // 
            // textBoxDeleteItem
            // 
            textBoxDeleteItem.Font = new Font("Segoe UI", 14F);
            textBoxDeleteItem.Location = new Point(484, 210);
            textBoxDeleteItem.Name = "textBoxDeleteItem";
            textBoxDeleteItem.PlaceholderText = " ID of Car";
            textBoxDeleteItem.Size = new Size(162, 39);
            textBoxDeleteItem.TabIndex = 17;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdate.AutoSize = true;
            buttonUpdate.BackColor = SystemColors.GradientActiveCaption;
            buttonUpdate.Location = new Point(796, 356);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(162, 61);
            buttonUpdate.TabIndex = 19;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(720, 169);
            label9.Name = "label9";
            label9.Size = new Size(353, 28);
            label9.TabIndex = 20;
            label9.Text = "Which parameter do you want change?";
            // 
            // comboBoxUpdate
            // 
            comboBoxUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxUpdate.Font = new Font("Segoe UI", 14F);
            comboBoxUpdate.FormattingEnabled = true;
            comboBoxUpdate.Items.AddRange(new object[] { "Brand", "Model", "Color", "Engine", "Year" });
            comboBoxUpdate.Location = new Point(799, 210);
            comboBoxUpdate.Name = "comboBoxUpdate";
            comboBoxUpdate.Size = new Size(159, 39);
            comboBoxUpdate.TabIndex = 21;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(740, 256);
            label10.Name = "label10";
            label10.Size = new Size(280, 28);
            label10.TabIndex = 22;
            label10.Text = "ID and new name of parameter";
            // 
            // textBoxUpdateID
            // 
            textBoxUpdateID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxUpdateID.Font = new Font("Segoe UI", 14F);
            textBoxUpdateID.Location = new Point(719, 301);
            textBoxUpdateID.Name = "textBoxUpdateID";
            textBoxUpdateID.PlaceholderText = " ID of Car";
            textBoxUpdateID.Size = new Size(138, 39);
            textBoxUpdateID.TabIndex = 23;
            // 
            // textBoxNewName
            // 
            textBoxNewName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNewName.Font = new Font("Segoe UI", 14F);
            textBoxNewName.Location = new Point(890, 301);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(162, 39);
            textBoxNewName.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.GradientActiveCaption;
            dataGridView1.Location = new Point(17, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1056, 232);
            dataGridView1.TabIndex = 25;
            // 
            // Form_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 690);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxNewName);
            Controls.Add(textBoxUpdateID);
            Controls.Add(label10);
            Controls.Add(comboBoxUpdate);
            Controls.Add(label9);
            Controls.Add(buttonUpdate);
            Controls.Add(label8);
            Controls.Add(textBoxDeleteItem);
            Controls.Add(buttonDelete);
            Controls.Add(buttonShowAll);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxEngine);
            Controls.Add(buttonInsert);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxBrand);
            Controls.Add(panel1);
            MinimumSize = new Size(1105, 692);
            Name = "Form_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSeachItem;
        private Label label2;
        private Button buttonSearchItem;
        private Panel panel1;
        private TextBox textBoxBrand;
        private TextBox textBoxModel;
        private TextBox textBoxColor;
        private TextBox textBoxYear;
        private Button buttonInsert;
        private ComboBox comboBoxEngine;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private Button buttonShowAll;
        private Button buttonDelete;
        private Label label8;
        private TextBox textBoxDeleteItem;
        private Button buttonUpdate;
        private Label label9;
        private ComboBox comboBoxUpdate;
        private Label label10;
        private TextBox textBoxUpdateID;
        private TextBox textBoxNewName;
        private DataGridView dataGridView1;
    }
}