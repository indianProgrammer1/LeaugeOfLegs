using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8.Properties.Backend.Model
{
    [Serializable]
    public abstract class Assassins : Champions
    {

        protected Assassins(string Name, int Level, int Speed, string Gender, string type)
            : base(Name, Speed, Level, Gender, type)
        {

        }
    }
}
