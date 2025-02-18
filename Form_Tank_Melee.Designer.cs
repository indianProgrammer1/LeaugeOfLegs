namespace WindowsFormsApp8
{
    partial class Form_Tank_Melee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tank_Melee));
            this.txtBoxName_Tank = new System.Windows.Forms.TextBox();
            this.textBoxLevel_Tank = new System.Windows.Forms.TextBox();
            this.textBoxSpeed_Tank = new System.Windows.Forms.TextBox();
            this.radioButtonMale_Tank = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale_Tank = new System.Windows.Forms.RadioButton();
            this.label_Shield_Tank = new System.Windows.Forms.Label();
            this.buttonAdd_Tank = new System.Windows.Forms.Button();
            this.comboBoxWeapon_Tank = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxName_Tank
            // 
            this.txtBoxName_Tank.Location = new System.Drawing.Point(98, 7);
            this.txtBoxName_Tank.Name = "txtBoxName_Tank";
            this.txtBoxName_Tank.Size = new System.Drawing.Size(124, 22);
            this.txtBoxName_Tank.TabIndex = 13;
            // 
            // textBoxLevel_Tank
            // 
            this.textBoxLevel_Tank.Location = new System.Drawing.Point(101, 7);
            this.textBoxLevel_Tank.Name = "textBoxLevel_Tank";
            this.textBoxLevel_Tank.Size = new System.Drawing.Size(121, 22);
            this.textBoxLevel_Tank.TabIndex = 14;
            // 
            // textBoxSpeed_Tank
            // 
            this.textBoxSpeed_Tank.Location = new System.Drawing.Point(106, 4);
            this.textBoxSpeed_Tank.Name = "textBoxSpeed_Tank";
            this.textBoxSpeed_Tank.Size = new System.Drawing.Size(116, 22);
            this.textBoxSpeed_Tank.TabIndex = 15;
            this.textBoxSpeed_Tank.TextChanged += new System.EventHandler(this.textBoxSpeed_Tank_TextChanged);
            // 
            // radioButtonMale_Tank
            // 
            this.radioButtonMale_Tank.AutoSize = true;
            this.radioButtonMale_Tank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonMale_Tank.ForeColor = System.Drawing.Color.White;
            this.radioButtonMale_Tank.Location = new System.Drawing.Point(65, 31);
            this.radioButtonMale_Tank.Name = "radioButtonMale_Tank";
            this.radioButtonMale_Tank.Size = new System.Drawing.Size(63, 24);
            this.radioButtonMale_Tank.TabIndex = 17;
            this.radioButtonMale_Tank.TabStop = true;
            this.radioButtonMale_Tank.Text = "Male";
            this.radioButtonMale_Tank.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale_Tank
            // 
            this.radioButtonFemale_Tank.AutoSize = true;
            this.radioButtonFemale_Tank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonFemale_Tank.ForeColor = System.Drawing.Color.White;
            this.radioButtonFemale_Tank.Location = new System.Drawing.Point(144, 31);
            this.radioButtonFemale_Tank.Name = "radioButtonFemale_Tank";
            this.radioButtonFemale_Tank.Size = new System.Drawing.Size(78, 24);
            this.radioButtonFemale_Tank.TabIndex = 18;
            this.radioButtonFemale_Tank.TabStop = true;
            this.radioButtonFemale_Tank.Text = "Female";
            this.radioButtonFemale_Tank.UseVisualStyleBackColor = true;
            // 
            // label_Shield_Tank
            // 
            this.label_Shield_Tank.AutoSize = true;
            this.label_Shield_Tank.BackColor = System.Drawing.Color.Black;
            this.label_Shield_Tank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Shield_Tank.ForeColor = System.Drawing.Color.White;
            this.label_Shield_Tank.Location = new System.Drawing.Point(3, 278);
            this.label_Shield_Tank.Name = "label_Shield_Tank";
            this.label_Shield_Tank.Size = new System.Drawing.Size(165, 28);
            this.label_Shield_Tank.TabIndex = 19;
            this.label_Shield_Tank.Text = "Tanks have shield.";
            this.label_Shield_Tank.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // buttonAdd_Tank
            // 
            this.buttonAdd_Tank.BackColor = System.Drawing.Color.Black;
            this.buttonAdd_Tank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd_Tank.ForeColor = System.Drawing.Color.White;
            this.buttonAdd_Tank.Location = new System.Drawing.Point(3, 309);
            this.buttonAdd_Tank.Name = "buttonAdd_Tank";
            this.buttonAdd_Tank.Size = new System.Drawing.Size(75, 37);
            this.buttonAdd_Tank.TabIndex = 20;
            this.buttonAdd_Tank.Text = "Add!";
            this.buttonAdd_Tank.UseVisualStyleBackColor = false;
            this.buttonAdd_Tank.Click += new System.EventHandler(this.buttonAdd_Tank_Click);
            // 
            // comboBoxWeapon_Tank
            // 
            this.comboBoxWeapon_Tank.FormattingEnabled = true;
            this.comboBoxWeapon_Tank.Items.AddRange(new object[] {
            "Sword",
            "Hammer",
            "AXE"});
            this.comboBoxWeapon_Tank.Location = new System.Drawing.Point(113, 7);
            this.comboBoxWeapon_Tank.Name = "comboBoxWeapon_Tank";
            this.comboBoxWeapon_Tank.Size = new System.Drawing.Size(109, 24);
            this.comboBoxWeapon_Tank.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxName_Tank);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 42);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.label_Shield_Tank);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdd_Tank);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(688, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 540);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxLevel_Tank);
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 44);
            this.panel2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Level:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxSpeed_Tank);
            this.panel3.Location = new System.Drawing.Point(3, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 42);
            this.panel3.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Speed:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxWeapon_Tank);
            this.panel4.Controls.Add(this.label5);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(3, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 46);
            this.panel4.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Weapon:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButtonFemale_Tank);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.radioButtonMale_Tank);
            this.panel5.Location = new System.Drawing.Point(3, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 74);
            this.panel5.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Gender:";
            // 
            // Form_Tank_Melee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp8.Properties.Resources.MelleTank2;
            this.ClientSize = new System.Drawing.Size(919, 514);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Tank_Melee";
            this.Text = "Form_Tank_Melee";
  //          this.Load += new System.EventHandler(this.Form_Tank_Melee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Shield_Tank;
        private System.Windows.Forms.Button buttonAdd_Tank;
        public System.Windows.Forms.TextBox txtBoxName_Tank;
        public System.Windows.Forms.TextBox textBoxLevel_Tank;
        public System.Windows.Forms.TextBox textBoxSpeed_Tank;
        public System.Windows.Forms.RadioButton radioButtonMale_Tank;
        public System.Windows.Forms.RadioButton radioButtonFemale_Tank;
        public System.Windows.Forms.ComboBox comboBoxWeapon_Tank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
    }
}