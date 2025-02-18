namespace WindowsFormsApp8
{
    partial class Edit_Tank_Melee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Tank_Melee));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textSpeedEdit = new System.Windows.Forms.TextBox();
            this.textNameEdit = new System.Windows.Forms.TextBox();
            this.textLevelEdit = new System.Windows.Forms.TextBox();
            this.radioFemaleEdit = new System.Windows.Forms.RadioButton();
            this.radioMaleEdit = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelSpeedEdit = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWeapon = new System.Windows.Forms.Label();
            this.comboBoxWeaponEdit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(281, 218);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 49;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textSpeedEdit
            // 
            this.textSpeedEdit.Location = new System.Drawing.Point(116, 90);
            this.textSpeedEdit.Name = "textSpeedEdit";
            this.textSpeedEdit.Size = new System.Drawing.Size(121, 22);
            this.textSpeedEdit.TabIndex = 48;
            // 
            // textNameEdit
            // 
            this.textNameEdit.Location = new System.Drawing.Point(116, 22);
            this.textNameEdit.Name = "textNameEdit";
            this.textNameEdit.Size = new System.Drawing.Size(121, 22);
            this.textNameEdit.TabIndex = 47;
            // 
            // textLevelEdit
            // 
            this.textLevelEdit.Location = new System.Drawing.Point(116, 61);
            this.textLevelEdit.Name = "textLevelEdit";
            this.textLevelEdit.Size = new System.Drawing.Size(121, 22);
            this.textLevelEdit.TabIndex = 46;
            // 
            // radioFemaleEdit
            // 
            this.radioFemaleEdit.AutoSize = true;
            this.radioFemaleEdit.Location = new System.Drawing.Point(190, 163);
            this.radioFemaleEdit.Name = "radioFemaleEdit";
            this.radioFemaleEdit.Size = new System.Drawing.Size(75, 21);
            this.radioFemaleEdit.TabIndex = 45;
            this.radioFemaleEdit.TabStop = true;
            this.radioFemaleEdit.Text = "Female";
            this.radioFemaleEdit.UseVisualStyleBackColor = true;
            // 
            // radioMaleEdit
            // 
            this.radioMaleEdit.AutoSize = true;
            this.radioMaleEdit.Location = new System.Drawing.Point(116, 163);
            this.radioMaleEdit.Name = "radioMaleEdit";
            this.radioMaleEdit.Size = new System.Drawing.Size(59, 21);
            this.radioMaleEdit.TabIndex = 44;
            this.radioMaleEdit.TabStop = true;
            this.radioMaleEdit.Text = "Male";
            this.radioMaleEdit.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(31, 163);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(56, 17);
            this.labelGender.TabIndex = 43;
            this.labelGender.Text = "Gender";
            // 
            // labelSpeedEdit
            // 
            this.labelSpeedEdit.AutoSize = true;
            this.labelSpeedEdit.Location = new System.Drawing.Point(31, 90);
            this.labelSpeedEdit.Name = "labelSpeedEdit";
            this.labelSpeedEdit.Size = new System.Drawing.Size(49, 17);
            this.labelSpeedEdit.TabIndex = 42;
            this.labelSpeedEdit.Text = "Speed";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(31, 61);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(42, 17);
            this.labelLevel.TabIndex = 41;
            this.labelLevel.Text = "Level";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 40;
            this.labelName.Text = "Name";
            // 
            // labelWeapon
            // 
            this.labelWeapon.AutoSize = true;
            this.labelWeapon.Location = new System.Drawing.Point(31, 126);
            this.labelWeapon.Name = "labelWeapon";
            this.labelWeapon.Size = new System.Drawing.Size(61, 17);
            this.labelWeapon.TabIndex = 39;
            this.labelWeapon.Text = "Weapon";
            // 
            // comboBoxWeaponEdit
            // 
            this.comboBoxWeaponEdit.FormattingEnabled = true;
            this.comboBoxWeaponEdit.Items.AddRange(new object[] {
            "Sword",
            "Hammer",
            "Mace"});
            this.comboBoxWeaponEdit.Location = new System.Drawing.Point(116, 126);
            this.comboBoxWeaponEdit.Name = "comboBoxWeaponEdit";
            this.comboBoxWeaponEdit.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWeaponEdit.TabIndex = 38;
            // 
            // Edit_Tank_Melee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textSpeedEdit);
            this.Controls.Add(this.textNameEdit);
            this.Controls.Add(this.textLevelEdit);
            this.Controls.Add(this.radioFemaleEdit);
            this.Controls.Add(this.radioMaleEdit);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelSpeedEdit);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelWeapon);
            this.Controls.Add(this.comboBoxWeaponEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Tank_Melee";
            this.Text = "Edit_Tank_Melee";
     //       this.Load += new System.EventHandler(this.Edit_Tank_Melee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.TextBox textSpeedEdit;
        public System.Windows.Forms.TextBox textNameEdit;
        public System.Windows.Forms.TextBox textLevelEdit;
        public System.Windows.Forms.RadioButton radioFemaleEdit;
        public System.Windows.Forms.RadioButton radioMaleEdit;
        public System.Windows.Forms.Label labelGender;
        public System.Windows.Forms.Label labelSpeedEdit;
        public System.Windows.Forms.Label labelLevel;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelWeapon;
        public System.Windows.Forms.ComboBox comboBoxWeaponEdit;
    }
}