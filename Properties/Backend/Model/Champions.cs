using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8.Properties
{
    [Serializable]
    public abstract class Champions
    {
        public string Name { set; get; }
        public string Gender { set; get; }
        public int Speed { set; get; }

        public int Level { get; set; }

        public int Hp { set; get; }

        public string Type { get; set; }

        protected Champions(string name, int speed, int level, string gender, string type)
        {
            Name = name;
            Speed = speed;
            Level = level;
            Gender = gender;
            Hp = 100 * level;
            Type = type;
        }

        public abstract string MakeSound();

        public abstract string getWeapon();

        public abstract string getType();
    }
    
}
