using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8.Properties.Backend.Model
{
    [Serializable]
    public class Melee_Tank : Tanks
    {
        public string Weapon { get; set; }

        public Melee_Tank(string weapon, string _name, int _level, int _speed, string Gender,string type)
            : base(_name, _level, _speed, Gender,type)
        {
            Weapon = weapon;
            type = "Melee Tank";
        }

        public override string MakeSound() 
        {
            return "My name is: " + this.Name + ",  class : Melee_Tank";
        }
        public override string getWeapon()
        {
            return this.Weapon;
        }
        public override string getType()
        {
            return "Melee Tank";
        }
    }
}

