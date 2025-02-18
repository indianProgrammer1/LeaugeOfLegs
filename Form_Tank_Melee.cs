using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Properties.Backend.Model;
using WindowsFormsApp8.Properties.Model;

namespace WindowsFormsApp8
{
    public partial class Form_Tank_Melee : Form
    {
        private static BindingList<Tanks> TanksList = new BindingList<Tanks>();
        public Form_Tank_Melee()
        {
            InitializeComponent();
        }

        private void buttonAdd_Tank_Click(object sender, EventArgs e)
        {
            try
            {
                int level1 = Int32.Parse(textBoxLevel_Tank.Text);
            }
            catch
            {
                MessageBox.Show("Enter valid Level please!");
                textBoxLevel_Tank.Clear();
                return;
            }
            try
            {
                int level1 = Int32.Parse(textBoxSpeed_Tank.Text);
            }
            catch
            {
                MessageBox.Show("Enter Valid speed please!");
                textBoxSpeed_Tank.Clear();
                return;
            }

            if (txtBoxName_Tank.Text == "")
            {
                MessageBox.Show("Enter your name!");
                return;
            }
            if (textBoxLevel_Tank.Text == "" ||  Int32.Parse(textBoxLevel_Tank.Text) < 0)
            {

                MessageBox.Show("Enter Valid Level!");
                textBoxLevel_Tank.Clear();
                return;

            }

            if (comboBoxWeapon_Tank.Text == "")
            {
                MessageBox.Show("Enter Weapon!");
                return;
            }
            if (textBoxSpeed_Tank.Text == "" || Int32.Parse(textBoxSpeed_Tank.Text) < 0)
            {
                MessageBox.Show("Enter Valid Speed!");
                return;
            }

            if (!radioButtonFemale_Tank.Checked && !radioButtonMale_Tank.Checked)
            {
                MessageBox.Show("Please Choose Gender!");
                return;
            }


            string name = txtBoxName_Tank.Text.ToString();
            string weapon = comboBoxWeapon_Tank.Text.ToString();
            int level = Int32.Parse(textBoxLevel_Tank.Text);
            int speed = Int32.Parse(textBoxSpeed_Tank.Text);
            string Gender = "NULL";
            if (radioButtonFemale_Tank.Checked)
            {
                Gender = "Female";
            }
            else if (radioButtonMale_Tank.Checked)
            {
                Gender = "Male";
            }
            string Type = "Melee Tank";
            Melee_Tank melee_Tank = new Melee_Tank(weapon, name, level, speed, Gender,Type);
            Champions_manager.AddChampion(melee_Tank);
            TanksList.Add(melee_Tank);

            MessageBox.Show("Melee Tank Added!");
            txtBoxName_Tank.Clear();
            textBoxLevel_Tank.Clear();
            textBoxSpeed_Tank.Clear();
            comboBoxWeapon_Tank.ResetText();

            this.Close();
        }

        private void textBoxSpeed_Tank_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
