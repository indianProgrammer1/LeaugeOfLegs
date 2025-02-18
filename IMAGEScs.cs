using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Properties;
using WindowsFormsApp8.Properties.Backend.Model;

namespace WindowsFormsApp8
{
    public partial class IMAGEScs : Form
    {
        public static IMAGEScs instance;
        private bool isDragging = false;
        private Point lastCursorPosition;
        public IMAGEScs()
        {

            InitializeComponent();
            add();


        }

        private void add()
        {
            BindingList<Champions> champs = FileUtiles.LoadChampionsFromFile();
            int count = champs.Count;
            int b = 20;
            int t = 25;
            string IM="";
            for (int i = 0; i < count; i++)
            {
                
                if (champs[i].getType() == "Melee Tank")
                {
                    if (champs[i].getWeapon()=="Sword")
                    {
                        IM = "C:\\Users\\yahav\\SOURCE\\repos\\WindowsFormsApp8\\Resources\\meletankSword.png";
                    }
                    else if (champs[i].getWeapon() == "Hammer")
                    {
                        IM = "C:\\Users\\yahav\\SOURCE\\repos\\WindowsFormsApp8\\Resources\\meleTankHameer.png";
                    }
                    else  IM = "C:\\Users\\yahav\\SOURCE\\repos\\WindowsFormsApp8\\Resources\\meletankAXE.png";

                }
                else if (champs[i].getType() == "Assassin Ranged")
                {
                    if (champs[i].getWeapon() == "Bow")
                    {
                        IM = "C:\\Users\\yahav\\SOURCE\\repos\\WindowsFormsApp8\\Resources\\AssasinRangeBow.png";
                    }
                    else IM = "C:\\Users\\yahav\\SOURCE\\repos\\WindowsFormsApp8\\Resources\\AssasinRangeGun.png";
                }
                else
                {
                    if (champs[i].getWeapon() == "Scythe")
                    {
                        IM = "C:\\Users\\yahav\\SOURCE\\repos\\WindowsFormsApp8\\Resources\\AssasinMELEEscythe.png";
                    }
                    else IM = "C:\\Users\\yahav\\SOURCE\\repos\\WindowsFormsApp8\\Resources\\AssasinMelleSpear.png";
                }

              

                PictureBox p = new PictureBox()
                {
                    Name = "picture",
                    Size = new Size(150, 150),
                    Location = new Point(b, t),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = Image.FromFile(IM)
                };
                p.BackColor = Color.Transparent;
                p.MouseDown += PictureBox_MouseDown;
                p.MouseMove += PictureBox_MouseMove;
                p.MouseUp += PictureBox_MouseUp;

                b += 150;
                if (b > 900)
                {
                    b = 20;
                    t += 160;
                }
                this.Controls.Add(p);
            }
        }


        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPosition = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = (PictureBox)sender;
                int deltaX = e.X - lastCursorPosition.X;
                int deltaY = e.Y - lastCursorPosition.Y;
                pictureBox.Location = new Point(pictureBox.Left + deltaX, pictureBox.Top + deltaY);
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IMAGEScs_MouseDown(object sender, MouseEventArgs e)
        {




        }

        private void IMAGEScs_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void IMAGEScs_MouseMove(object sender, MouseEventArgs e)
        {

        }




        private void IMAGEScs_Load(object sender, EventArgs e)
        {

        }

    }
}