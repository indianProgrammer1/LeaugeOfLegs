using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8.Properties.Backend.Model
{
    [Serializable]
    public class Melee : Assassins
    {
        public string Weapon { get; set; }
        public Melee(string weapon, string Name, int Level, int Speed, string Gender,string Type)
                : base(Name, Level, Speed, Gender, Type)
        {
            Weapon = weapon;
            Type = "Assassin Melee";
        }
        
        public override string MakeSound()
        {
            return "My name is: " + this.Name + ",  class : Melee (Assassins)";
        }
        public override string getWeapon()
        {
            return this.Weapon;
        }
        public override string getType()
        {
            return "Melee Assassin";
        }
    }
}
