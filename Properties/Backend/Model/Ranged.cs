using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8.Properties.Backend.Model
{
    [Serializable]
    public class Ranged : Assassins
    {
        DataTable dt_List = new DataTable();

        public int Range { get; set; }

        public string Weapon { get; set; }


        public Ranged(string Name, string weapon, int range, int Level, int Speed, string Gender, string Type)
            : base(Name, Level,Speed, Gender,Type)
        {
            Range = range;
            Weapon = weapon;
            Type = "Assassin Ranged";
        }
        public override string MakeSound()
        {
            return "My name is: " + this.Name + ",  class : Ranged (Assassins)";
        }
        public override string getWeapon()
        {
            return this.Weapon;
        }
        public override string getType()
        {
            return "Assassin Ranged";
        }
    }
}
