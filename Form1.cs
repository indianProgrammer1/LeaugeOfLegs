using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Properties;
using WindowsFormsApp8.Properties.Backend.Model;
using WindowsFormsApp8.Properties.Model;
using System.Net.Http;
using System.Xml.Resolvers;
using System.Globalization;
using System.Reflection;
//using WindowsFormsApp8.Properties.Model;
using WMPLib;
using Newtonsoft.Json; 


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        WindowsMediaPlayer player = new WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Champions_manager.saveChampions);
        }

        private void cboxKind_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboxKind.Text = cboxKind.SelectedIndex.ToString();
            if (cboxKind.Text == "Assassin Ranged")
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                

            }
            else if (cboxKind.Text == "Assassin Melee")
            {
                Form_Melee_Assassin f3 = new Form_Melee_Assassin();
                f3.ShowDialog();
            }

            else if (cboxKind.Text == "Tank Melee")
            {
                Form_Tank_Melee f4 = new Form_Tank_Melee();
                f4.ShowDialog();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void cboxKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxKind.SelectedItem.ToString() == "Assassin Ranged")
            {
                BindingList<Ranged> rangeds = Champions_manager.GetSpecificChampion<Ranged>();
            }
        }


        private static BindingList<Champions> ChampionsList2 = new BindingList<Champions>();


        private void BtnList_Click(object sender, EventArgs e, BindingList<Champions> championsList2)
        {
            championsList2 = FileUtiles.LoadChampionsFromFile();
        }

        private void comboBoxSerialize_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingList<Champions> champs = Champions_manager.GetChamps();
            champs=FileUtiles.LoadChampionsFromFile();
            List list = new List();

            if (comboBoxSerialize.Text.ToString()=="Assassin ranged")
            {
                
                BindingList<Ranged> rangeds = Champions_manager.GetSpecificChampion<Ranged>();
                list.dataGridViewList.DataSource = rangeds;
                list.ShowDialog();
            }

            else if (comboBoxSerialize.Text.ToString() == "Assassin melee")
            {
                BindingList<Melee> melees = Champions_manager.GetSpecificChampion<Melee>();
                list.dataGridViewList.DataSource = melees;
                list.ShowDialog();
            }

            else if (comboBoxSerialize.Text.ToString() == "Tank melee")
            {
                BindingList<Melee_Tank> tanks = Champions_manager.GetSpecificChampion<Melee_Tank>();
                list.dataGridViewList.DataSource = tanks;
                list.ShowDialog();
            }
        }

        private void checkBoxMusic_CheckStateChanged(object sender, EventArgs e)
        {
            player.URL = "Arcane_Chill_LoFi_Hip_Hop_Mix_Enemy_Guns_for_Hire_Study_with_Jinx.mp3";
            if(checkBoxMusic.Checked){player.controls.play();} 
            else{player.controls.stop();}
        }

        private void button_Random_Fact_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText("C:\\Users\\yahav\\SOURCE\\repos\\WindowsFormsApp8\\league_facts.json");
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(json);
                string[] facts = jsonObject["facts"].ToObject<string[]>();

                Random random = new Random();
                int index = random.Next(facts.Length);
                string fact = facts[index];

                MessageBox.Show(fact, "League of Legends Fact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading facts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowTime_Click(object sender, EventArgs e)
        {
            IMAGEScs imageaes = new IMAGEScs();
            imageaes.Show();
     
        }

    }
}