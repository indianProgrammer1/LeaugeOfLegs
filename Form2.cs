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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        

        private BindingList<Ranged> rangeds = new BindingList<Ranged>();
        public Form2()
        {
            InitializeComponent();
        }

      
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                int level1 = Int32.Parse(textBoxLEVEL.Text);
            }
            catch
            {
                MessageBox.Show("Enter Valid Level please!");
                textBoxLEVEL.Clear();
                return;
            }
            try
            {
                int level1 = Int32.Parse(textBoxSPEED.Text);
            }
            catch
            {
                MessageBox.Show("Enter Valid speed please!");
                textBoxSPEED.Clear();
                return;
            }
            try
            {
                int level1 = Int32.Parse(textBoxRANGE.Text);
                
            }
            catch
            {
                MessageBox.Show("Enter Valid Range!");
                textBoxRANGE.Clear();
                return;
            }
            if (textBoxNAME.Text == "")
            {
                MessageBox.Show("Enter your name!");
                return;
            }
            if (textBoxLEVEL.Text == "" || Int32.Parse(textBoxLEVEL.Text) < 0)
            {
                MessageBox.Show("Enter Valid Level!");
                textBoxLEVEL.Clear();
                return;
            }
            if (comboBoxWEAPON.Text == "")
            {
                MessageBox.Show("Enter Weapon!");
                return;
            }
            if (textBoxSPEED.Text == "" || Int32.Parse(textBoxSPEED.Text) < 0)
            {
                MessageBox.Show("Enter Valid Speed!");
                textBoxSPEED.Clear();
                return;
            }
            if (textBoxRANGE.Text == "" || Int32.Parse(textBoxRANGE.Text) < 0)
            {
                MessageBox.Show("Enter Valid Range!");
                textBoxRANGE.Clear();
                return;

            }
            if (!(btnMale.Checked) && !(btnFemale.Checked))
            {
                MessageBox.Show("Please Choose Gender!");
                return;
            }

            string Name = textBoxNAME.Text.ToString();
            string Weapon = comboBoxWEAPON.Text.ToString();
            int Level = Int32.Parse(textBoxLEVEL.Text);
            int Speed = Int32.Parse(textBoxSPEED.Text);
            int Range = Int32.Parse(textBoxRANGE.Text);
            string Gender = "NULL";
            if (btnMale.Checked)
            {
                Gender = "Male";
            }
            else if (btnFemale.Checked)
            {
                Gender = "Female";
            }
            string Type = "Assassin Ranged";
            Ranged rng = new Ranged(Name, Weapon, Range, Level, Speed, Gender, Type);
            Champions_manager.AddChampion(rng);
            rangeds.Add(rng);
           
            MessageBox.Show("Ranged Added!");

            textBoxLEVEL.Clear();
            textBoxNAME.Clear();
            textBoxRANGE.Clear();
            textBoxSPEED.Clear();
            comboBoxWEAPON.ResetText();

         

            

            this.Close();



        }
    

    }
}
