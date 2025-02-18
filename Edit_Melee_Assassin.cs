using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Edit_Melee_Assassin : Form
    {
        public Edit_Melee_Assassin()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int level1 = Int32.Parse(textLevelEdit.Text);
            }
            catch
            {
                MessageBox.Show("Enter valid Level please!");
                textLevelEdit.Clear();
                return;
            }
            try
            {
                int level1 = Int32.Parse(textSpeedEdit.Text);
            }
            catch
            {
                MessageBox.Show("Enter valid speed please!");
                textSpeedEdit.Clear();
                return;
            }
            if (textNameEdit.Text == "")
            {
                MessageBox.Show("Enter your name!");
                return;
            }
            if (textLevelEdit.Text == "" || Int32.Parse(textLevelEdit.Text) < 0)
            {
                MessageBox.Show("Enter Valid Level!");
                textLevelEdit.Clear();
                return;
            }
            if (comboBoxWeaponEdit.Text == "")
            {
                MessageBox.Show("Enter Weapon!");

                return;
            }
            if (textSpeedEdit.Text == "" || Int32.Parse(textSpeedEdit.Text) < 0)
            {
                MessageBox.Show("Enter Valid Speed!");
                textSpeedEdit.Clear();
                return;
            }
            if (!radioMaleEdit.Checked && !radioFemaleEdit.Checked)
            {
                MessageBox.Show("Please choose Gender!");
                return;
            }
            MessageBox.Show("Melee Assassin Edited!");
            this.Close();
        }

        private void Edit_Melee_Assassin_Load(object sender, EventArgs e)
        {

        }
    }
}
