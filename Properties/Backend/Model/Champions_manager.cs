using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Properties.Backend.Model;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp8.Properties.Model
{
    public class Champions_manager : Form 
    {
       

        private static BindingList<Champions> ChampionsList = new BindingList<Champions>();

        static Champions_manager()
        {
            ChampionsList = FileUtiles.LoadChampionsFromFile();
        }

        public static void saveChampions(object sender, FormClosingEventArgs e)
        {
            FileUtiles.SaveChampionsToFile(ChampionsList);
        }

        public static BindingList<Champions> GetChamps()
        {
            ChampionsList=FileUtiles.LoadChampionsFromFile();
            return ChampionsList;
        }

        public static void AddChampion(Champions champ)
        {
            ChampionsList = FileUtiles.LoadChampionsFromFile();
            ChampionsList.Add(champ);
            FileUtiles.SaveChampionsToFile(ChampionsList);
        }

        public static void RemoveChampion(Champions champ)
        {
            ChampionsList.Remove(champ);
            FileUtiles.SaveChampionsToFile(ChampionsList);
        }

        public static BindingList<T> GetSpecificChampion<T>() where T : Champions
        {
            BindingList<T> specificChampion = new BindingList<T>();

            foreach (Champions champ in ChampionsList)
            {
                if (champ is T)
                {
                    specificChampion.Add(champ as T);
                }
            }
            return specificChampion;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Champions_manager));
            this.SuspendLayout();
            // 
            // Champions_manager
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Champions_manager";
            this.Load += new System.EventHandler(this.Champions_manager_Load);
            this.ResumeLayout(false);

        }

        private void Champions_manager_Load(object sender, EventArgs e)
        {

        }
    }
}

