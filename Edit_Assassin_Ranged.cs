using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Properties.Backend.Model;
using WindowsFormsApp8.Properties.Model;

namespace WindowsFormsApp8
{
    public partial class Edit_Assassin_Ranged : Form
    {
        public Edit_Assassin_Ranged()
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
                MessageBox.Show("Enter Valid Level please!");
                textLevelEdit.Clear();
                return;
            }
            try
            {
                int level1 = Int32.Parse(textSpeedEdit.Text);
            }
            catch
            {
                MessageBox.Show("Enter Valid speed please!");
                textSpeedEdit.Clear();
                return;
            }
            try
            {
                int level1 = Int32.Parse(textRangeEdit.Text);
              
            }
            catch
            {
                MessageBox.Show("Enter Valid Range!");
                textRangeEdit.Clear();
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
                return;
            }
            if (textRangeEdit.Text == "" || Int32.Parse(textRangeEdit.Text) < 0)
            {
                MessageBox.Show("Enter Valid Range!");
                return;

            }
            if (!(radioMaleEdit.Checked) && !(radioFemaleEdit.Checked))
            {
                MessageBox.Show("Please Choose Gender!");
                return;
            }
            MessageBox.Show("Ranged Edited!");
            this.Close();
        }

        private void Edit_Assassin_Ranged_Load(object sender, EventArgs e)
        {

        }
    }
}
