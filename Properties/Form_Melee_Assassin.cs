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

namespace WindowsFormsApp8.Properties
{
    public partial class Form_Melee_Assassin : Form
    {
        private static BindingList<Melee> melees = new BindingList<Melee>();

        public Form_Melee_Assassin()
        {
            InitializeComponent();
        }

      

        private void btnADD_Click(object sender, EventArgs e)
        {


            try
            {
                int level1 = Int32.Parse(textBoxLevel_Melee.Text);
            }
            catch
            {
                MessageBox.Show("Enter valid Level please!");
                textBoxLevel_Melee.Clear();
                return;
            }
            try
            {
                int level1 = Int32.Parse(textBoxSpeed_Melee.Text);
            }
            catch
            {
                MessageBox.Show("Enter valid speed please!");
                textBoxSpeed_Melee.Clear();
                return;
            }
            if (textBoxName_Melee.Text == "")
            {
                MessageBox.Show("Enter your name!");
                return;
            }
            if (textBoxLevel_Melee.Text == "" || Int32.Parse(textBoxLevel_Melee.Text) < 0)
            {
                MessageBox.Show("Enter Valid Level!");
                textBoxLevel_Melee.Clear();
                return;
            }
            if (comboBoxWEAPON_Melee.Text == "")
            {
                MessageBox.Show("Enter Weapon!");

                return;
            }
            if (textBoxSpeed_Melee.Text == "" || Int32.Parse(textBoxSpeed_Melee.Text) < 0)
            {
                MessageBox.Show("Enter Valid Speed!");
                textBoxSpeed_Melee.Clear();
                return;
            }
            if (!btnMale2.Checked && !btnFemale2.Checked)
            {
                MessageBox.Show("Please choose Gender!");
                return;
            }

            string name = textBoxName_Melee.Text.ToString();
            string weapon = comboBoxWEAPON_Melee.Text.ToString();
            int level = Int32.Parse(textBoxLevel_Melee.Text);
            int speed = Int32.Parse(textBoxSpeed_Melee.Text);
            string Gender = "NULL";
            if (btnMale2.Checked)
            {
                Gender = "Male";
            }
            else if (btnFemale2.Checked)
            {
                Gender = "Female";
            }
            string Type = "Assassin Melee";
            Melee Melee_Assassin = new Melee(weapon, name, level, speed, Gender,Type);
            Champions_manager.AddChampion(Melee_Assassin);
            melees.Add(Melee_Assassin);


            MessageBox.Show("Melee Assassin Added!");
            textBoxLevel_Melee.Clear();
            textBoxName_Melee.Clear();
            textBoxSpeed_Melee.Clear();
            comboBoxWEAPON_Melee.ResetText();

            this.Close();

        }

    }
}
