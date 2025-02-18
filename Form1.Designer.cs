namespace WindowsFormsApp8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboxKind = new System.Windows.Forms.ComboBox();
            this.button_Random_Fact = new System.Windows.Forms.Button();
            this.comboBoxSerialize = new System.Windows.Forms.ComboBox();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.labelAddChampions = new System.Windows.Forms.Label();
            this.labelLists = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnShowTime = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxKind
            // 
            this.cboxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKind.FormattingEnabled = true;
            this.cboxKind.Items.AddRange(new object[] {
            "Assassin Ranged",
            "Assassin Melee",
            "Tank Melee"});
            this.cboxKind.Location = new System.Drawing.Point(5, 49);
            this.cboxKind.Name = "cboxKind";
            this.cboxKind.Size = new System.Drawing.Size(118, 24);
            this.cboxKind.TabIndex = 1;
            this.cboxKind.SelectedIndexChanged += new System.EventHandler(this.cboxKind_SelectedIndexChanged_1);
            // 
            // button_Random_Fact
            // 
            this.button_Random_Fact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button_Random_Fact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Random_Fact.ForeColor = System.Drawing.Color.White;
            this.button_Random_Fact.Location = new System.Drawing.Point(5, 0);
            this.button_Random_Fact.Name = "button_Random_Fact";
            this.button_Random_Fact.Size = new System.Drawing.Size(152, 39);
            this.button_Random_Fact.TabIndex = 2;
            this.button_Random_Fact.Text = "Random Fact!";
            this.button_Random_Fact.UseVisualStyleBackColor = false;
            this.button_Random_Fact.Click += new System.EventHandler(this.button_Random_Fact_Click);
            // 
            // comboBoxSerialize
            // 
            this.comboBoxSerialize.FormattingEnabled = true;
            this.comboBoxSerialize.Items.AddRange(new object[] {
            "Assassin ranged",
            "Assassin melee",
            "Tank melee"});
            this.comboBoxSerialize.Location = new System.Drawing.Point(5, 28);
            this.comboBoxSerialize.Name = "comboBoxSerialize";
            this.comboBoxSerialize.Size = new System.Drawing.Size(118, 24);
            this.comboBoxSerialize.TabIndex = 5;
            this.comboBoxSerialize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialize_SelectedIndexChanged);
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.AutoSize = true;
            this.checkBoxMusic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxMusic.ForeColor = System.Drawing.Color.White;
            this.checkBoxMusic.Location = new System.Drawing.Point(10, 3);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(85, 32);
            this.checkBoxMusic.TabIndex = 7;
            this.checkBoxMusic.Text = "Music";
            this.checkBoxMusic.UseVisualStyleBackColor = true;
            this.checkBoxMusic.CheckStateChanged += new System.EventHandler(this.checkBoxMusic_CheckStateChanged);
            // 
            // labelAddChampions
            // 
            this.labelAddChampions.AutoSize = true;
            this.labelAddChampions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAddChampions.ForeColor = System.Drawing.Color.White;
            this.labelAddChampions.Location = new System.Drawing.Point(1, 23);
            this.labelAddChampions.Name = "labelAddChampions";
            this.labelAddChampions.Size = new System.Drawing.Size(166, 23);
            this.labelAddChampions.TabIndex = 9;
            this.labelAddChampions.Text = "Add Champion kind:";
            // 
            // labelLists
            // 
            this.labelLists.AutoSize = true;
            this.labelLists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLists.ForeColor = System.Drawing.Color.White;
            this.labelLists.Location = new System.Drawing.Point(0, -3);
            this.labelLists.Name = "labelLists";
            this.labelLists.Size = new System.Drawing.Size(162, 28);
            this.labelLists.TabIndex = 11;
            this.labelLists.Text = "Champions lists : ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(172, 545);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelAddChampions);
            this.panel2.Controls.Add(this.cboxKind);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 84);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelLists);
            this.panel3.Controls.Add(this.comboBoxSerialize);
            this.panel3.Location = new System.Drawing.Point(3, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 72);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxMusic);
            this.panel1.Location = new System.Drawing.Point(3, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 44);
            this.panel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_Random_Fact);
            this.panel4.Location = new System.Drawing.Point(3, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 53);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnShowTime);
            this.panel5.Location = new System.Drawing.Point(3, 280);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 91);
            this.panel5.TabIndex = 13;
            // 
            // btnShowTime
            // 
            this.btnShowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnShowTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowTime.ForeColor = System.Drawing.Color.White;
            this.btnShowTime.Location = new System.Drawing.Point(3, 26);
            this.btnShowTime.Name = "btnShowTime";
            this.btnShowTime.Size = new System.Drawing.Size(119, 38);
            this.btnShowTime.TabIndex = 14;
            this.btnShowTime.Text = "ShowTime!";
            this.btnShowTime.UseVisualStyleBackColor = false;
            this.btnShowTime.Click += new System.EventHandler(this.btnShowTime_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = global::WindowsFormsApp8.Properties.Resources.LOL3;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
     //       this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tboxKind;
        private System.Windows.Forms.ComboBox cboxKindOptions;
        private System.Windows.Forms.ComboBox cboxKind;
        private System.Windows.Forms.Button button_Random_Fact;
        public System.Windows.Forms.ComboBox comboBoxSerialize;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.Label labelAddChampions;
        private System.Windows.Forms.Label labelLists;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnShowTime;
    }
}

