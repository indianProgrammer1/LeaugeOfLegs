namespace WindowsFormsApp8
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelHp_Tanks = new System.Windows.Forms.Label();
            this.labelHp_None_tanks = new System.Windows.Forms.Label();
            this.buttonDelete_all = new System.Windows.Forms.Button();
            this.buttonMakeSound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToOrderColumns = true;
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowHeadersWidth = 51;
            this.dataGridViewList.RowTemplate.Height = 24;
            this.dataGridViewList.Size = new System.Drawing.Size(995, 505);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(729, 523);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(819, 523);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelHp_Tanks
            // 
            this.labelHp_Tanks.AutoSize = true;
            this.labelHp_Tanks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHp_Tanks.Location = new System.Drawing.Point(12, 525);
            this.labelHp_Tanks.Name = "labelHp_Tanks";
            this.labelHp_Tanks.Size = new System.Drawing.Size(340, 25);
            this.labelHp_Tanks.TabIndex = 4;
            this.labelHp_Tanks.Text = "*Tanks Hp(health points) =  200 * Level.";
            // 
            // labelHp_None_tanks
            // 
            this.labelHp_None_tanks.AutoSize = true;
            this.labelHp_None_tanks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHp_None_tanks.Location = new System.Drawing.Point(12, 561);
            this.labelHp_None_tanks.Name = "labelHp_None_tanks";
            this.labelHp_None_tanks.Size = new System.Drawing.Size(405, 25);
            this.labelHp_None_tanks.TabIndex = 5;
            this.labelHp_None_tanks.Text = "*None - Tanks Hp(health points) =  100 *  level.";
            // 
            // buttonDelete_all
            // 
            this.buttonDelete_all.Location = new System.Drawing.Point(900, 523);
            this.buttonDelete_all.Name = "buttonDelete_all";
            this.buttonDelete_all.Size = new System.Drawing.Size(107, 23);
            this.buttonDelete_all.TabIndex = 6;
            this.buttonDelete_all.Text = "Delete All";
            this.buttonDelete_all.UseVisualStyleBackColor = true;
            this.buttonDelete_all.Click += new System.EventHandler(this.buttonDelete_all_Click);
            // 
            // buttonMakeSound
            // 
            this.buttonMakeSound.Location = new System.Drawing.Point(592, 523);
            this.buttonMakeSound.Name = "buttonMakeSound";
            this.buttonMakeSound.Size = new System.Drawing.Size(115, 23);
            this.buttonMakeSound.TabIndex = 7;
            this.buttonMakeSound.Text = "MakeSound";
            this.buttonMakeSound.UseVisualStyleBackColor = true;
            this.buttonMakeSound.Click += new System.EventHandler(this.buttonMakeSound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(918, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "*For the whole champions list, click twice on one of the champs//UNABLE EDITING F" +
    "ROM THE WHOLE LIST//";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMakeSound);
            this.Controls.Add(this.buttonDelete_all);
            this.Controls.Add(this.labelHp_None_tanks);
            this.Controls.Add(this.labelHp_Tanks);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List";
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewList;
        public System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelHp_Tanks;
        private System.Windows.Forms.Label labelHp_None_tanks;
        private System.Windows.Forms.Button buttonDelete_all;
        private System.Windows.Forms.Button buttonMakeSound;
        private System.Windows.Forms.Label label1;
    }
}