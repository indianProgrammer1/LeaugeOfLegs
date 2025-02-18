using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8.Properties.Backend.Model
{
    [Serializable]
    public abstract class Tanks : Champions
    {
        public bool Shield;


        protected Tanks(string Name, int Level, int Speed, string Gender, string Type)
            : base(Name, Speed, Level, Gender, Type)
        {
            Shield = true;
            Hp *= 2;
        }
    }

}
