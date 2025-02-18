using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8.Properties.Backend.Model
{
    public class add_Assassin_Ranged : UserControl
    {
        private BindingList<Ranged> Rangeds;
        public add_Assassin_Ranged(BindingList<Ranged> rangeds)
        {
            //InitializeComponent();
            //comboBoxFurColor.DataSource = Enum.GetValues(typeof(eColors));
            //comboBoxBreed.DataSource = Enum.GetValues(typeof(eBreeds));
            


            this.Rangeds = rangeds;
        }




    }

}
