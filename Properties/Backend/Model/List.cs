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
using WindowsFormsApp8.Properties;
using WindowsFormsApp8.Properties.Model;
using System.Reflection.Emit;

namespace WindowsFormsApp8
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        public void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingList<Champions> ChampionsList2 = new BindingList<Champions>();
            ChampionsList2 = FileUtiles.LoadChampionsFromFile();
            dataGridViewList.DataSource = ChampionsList2;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            BindingList<Champions> champs = Champions_manager.GetSpecificChampion<Champions>();

            DataGridViewRow selectedRow = dataGridViewList.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (selectedRow != null)
            {
                
                Champions objectToDelete = selectedRow.DataBoundItem as Champions;

                if (objectToDelete != null)
                {
                 
                    champs.Remove(objectToDelete);
                }

                dataGridViewList.Refresh();
            }

            FileUtiles.SaveChampionsToFile(champs);
            this.Close();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            BindingList<Champions> champs = Champions_manager.GetSpecificChampion<Champions>();

            DataGridViewRow selectedRow = dataGridViewList.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (selectedRow != null)
            {
                Champions objectToChange = selectedRow.DataBoundItem as Champions;

                if (objectToChange != null)
                {

                    if (objectToChange.Type == "Assassin Ranged")
                    {
                        BindingList<Ranged> rangeds = Champions_manager.GetSpecificChampion<Ranged>();
                        Ranged objectToChange2 = selectedRow.DataBoundItem as Ranged;

                        if (objectToChange2 != null)
                        {
                            Edit_Assassin_Ranged f2 = new Edit_Assassin_Ranged();

                            f2.textNameEdit.Text = objectToChange2.Name.ToString();
                            f2.textRangeEdit.Text = objectToChange2.Range.ToString();
                            f2.textLevelEdit.Text = objectToChange2.Level.ToString();
                            f2.textSpeedEdit.Text = objectToChange2.Speed.ToString();
                            f2.comboBoxWeaponEdit.Text = objectToChange2.Weapon.ToString();
                            if (objectToChange2.Gender == "Male")
                                f2.radioMaleEdit.Checked = true;
                            else if (objectToChange2.Gender == "Female")
                                f2.radioFemaleEdit.Checked = true;

                            f2.ShowDialog();
                            try
                            {
                                int level1 = objectToChange2.Level = Int32.Parse(f2.textLevelEdit.Text);
                            }
                            catch
                            {
                                return;
                            }
                            try
                            {
                                int level1 = objectToChange2.Speed = Int32.Parse(f2.textSpeedEdit.Text);
                            }
                            catch
                            {
                                return;
                            }
                            try
                            {
                                int level1 = objectToChange2.Speed = Int32.Parse(f2.textRangeEdit.Text);
                            }
                            catch
                            {
                                return;
                            }


                            objectToChange2.Name = f2.textNameEdit.Text;
                            objectToChange2.Range = Int32.Parse(f2.textRangeEdit.Text);
                            objectToChange2.Level = Int32.Parse(f2.textLevelEdit.Text);
                            objectToChange2.Weapon = f2.comboBoxWeaponEdit.Text;
                            objectToChange2.Speed = Int32.Parse(f2.textSpeedEdit.Text);
                            objectToChange2.Hp = 100 * objectToChange2.Level;
                            if (f2.radioMaleEdit.Checked)
                                objectToChange2.Gender = "Male";
                            else if (f2.radioFemaleEdit.Checked)
                                objectToChange2.Gender = "Female";

                        }
                    }

                    else if (objectToChange.Type == "Assassin Melee")
                    {
                        BindingList<Melee> melees = Champions_manager.GetSpecificChampion<Melee>();
                        Melee objectToChange2 = selectedRow.DataBoundItem as Melee;

                        if (objectToChange2 != null)
                        {
                            Edit_Melee_Assassin f3 = new Edit_Melee_Assassin();

                            if (f3.radioMaleEdit.Checked)
                                objectToChange2.Gender = "Male";
                            else if (f3.radioFemaleEdit.Checked)
                                objectToChange2.Gender = "Female";

                            f3.textNameEdit.Text = objectToChange2.Name.ToString();
                            f3.textSpeedEdit.Text = objectToChange2.Speed.ToString();
                            f3.textLevelEdit.Text = objectToChange2.Level.ToString();
                            f3.comboBoxWeaponEdit.Text = objectToChange2.Weapon.ToString();
                            if (objectToChange2.Gender == "Male")
                                f3.radioMaleEdit.Checked = true;
                            else if (objectToChange2.Gender == "Female")
                                f3.radioFemaleEdit.Checked = true;


                            f3.ShowDialog();

                            objectToChange2.Name = f3.textNameEdit.Text;
                            try
                            {
                                int level1 = objectToChange2.Level = Int32.Parse(f3.textLevelEdit.Text);
                            }
                            catch
                            {
                                return;
                            }
                            try
                            {
                                int level1 = objectToChange2.Speed = Int32.Parse(f3.textSpeedEdit.Text);
                            }
                            catch
                            {
                                return;
                            }

                            objectToChange2.Weapon = f3.comboBoxWeaponEdit.Text;
                            objectToChange2.Speed = Int32.Parse(f3.textSpeedEdit.Text);
                            objectToChange2.Hp = 100 * objectToChange2.Level;
                            if (f3.radioMaleEdit.Checked)
                                objectToChange2.Gender = "Male";
                            else if (f3.radioFemaleEdit.Checked)
                                objectToChange2.Gender = "Female";
                        }
                    }

                    else if (objectToChange.Type == "Melee Tank")
                    {
                        BindingList<Melee_Tank> tanks = Champions_manager.GetSpecificChampion<Melee_Tank>();
                        Melee_Tank objectToChange2 = selectedRow.DataBoundItem as Melee_Tank;

                        if (objectToChange2 != null)
                        {
                            Edit_Tank_Melee f4 = new Edit_Tank_Melee();
                            f4.textNameEdit.Text = objectToChange2.Name.ToString();
                            f4.textLevelEdit.Text = objectToChange2.Level.ToString();
                            f4.textSpeedEdit.Text = objectToChange2.Speed.ToString();
                            f4.comboBoxWeaponEdit.Text = objectToChange2.Weapon.ToString();
                            if (objectToChange2.Gender == "Male")
                                f4.radioMaleEdit.Checked = true;
                            else if (objectToChange2.Gender == "Female")
                                f4.radioFemaleEdit.Checked = true;


                            f4.ShowDialog();
                            try
                            {
                                int level1 = objectToChange2.Level = Int32.Parse(f4.textLevelEdit.Text);
                            }
                            catch
                            {
                                return;
                            }
                            try
                            {
                                int level1 = objectToChange2.Speed = Int32.Parse(f4.textSpeedEdit.Text);
                            }
                            catch
                            {
                                return;
                            }

                            objectToChange2.Name = f4.textNameEdit.Text;
                            objectToChange2.Level = Int32.Parse(f4.textLevelEdit.Text);
                            objectToChange2.Weapon = f4.comboBoxWeaponEdit.Text;
                            objectToChange2.Speed = Int32.Parse(f4.textSpeedEdit.Text);
                            objectToChange2.Hp = 200 * objectToChange2.Level;
                            if (f4.radioMaleEdit.Checked)
                                objectToChange2.Gender = "Male";
                            else if (f4.radioFemaleEdit.Checked)
                                objectToChange2.Gender = "Female";
                        }
                    }


                }

                dataGridViewList.Refresh();
             
            }

            FileUtiles.SaveChampionsToFile(champs);
        }

        private void buttonDelete_all_Click(object sender, EventArgs e)
        {
            BindingList<Champions> champs = Champions_manager.GetSpecificChampion<Champions>();
            DataGridViewRow selectedRow = dataGridViewList.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (selectedRow != null)
            {
                Champions objectToDelete = selectedRow.DataBoundItem as Champions;
                if (objectToDelete.Type == "Melee Tank" && objectToDelete != null)
                {
                    BindingList<Melee_Tank> tanks = Champions_manager.GetSpecificChampion<Melee_Tank>();
                    for (int i = 0; i < tanks.Count; i++)
                    {
                        Champions_manager.RemoveChampion(tanks[i]);
                    }
                }

                else if (objectToDelete.Type == "Assassin Melee" && objectToDelete != null)
                {
                    BindingList<Melee> melees = Champions_manager.GetSpecificChampion<Melee>();
                    for (int i = 0; i < melees.Count; i++)
                    {
                        Champions_manager.RemoveChampion(melees[i]);
                    }
                }

                else if (objectToDelete.Type == "Assassin Ranged" && objectToDelete != null)
                {
                    BindingList<Ranged> rangeds = Champions_manager.GetSpecificChampion<Ranged>();
                    for (int i = 0; i < rangeds.Count; i++)
                    {
                        Champions_manager.RemoveChampion(rangeds[i]);
                    }
                }

                dataGridViewList.Refresh();
            }
            this.Close();
        }
    

        private void buttonMakeSound_Click(object sender, EventArgs e)
        {
            BindingList<Champions> champs = Champions_manager.GetSpecificChampion<Champions>();
            DataGridViewRow selectedRow = dataGridViewList.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (selectedRow != null)
            {
                Champions objectToDelete = selectedRow.DataBoundItem as Champions;
                if (objectToDelete.Type == "Melee Tank" && objectToDelete != null)
                {
                    MessageBox.Show(objectToDelete.MakeSound());
                    
                }

                else if (objectToDelete.Type == "Assassin Melee" && objectToDelete != null)
                {
                    MessageBox.Show(objectToDelete.MakeSound());
                }

                else if (objectToDelete.Type == "Assassin Ranged" && objectToDelete != null)
                {
                    MessageBox.Show(objectToDelete.MakeSound());
                }
            }
        }
    }



}

