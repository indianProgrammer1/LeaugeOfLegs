using WindowsFormsApp8.Properties.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8.Properties.Backend.Model
{
    public class FileUtiles
    {
            public static void SaveChampionsToFile(BindingList<Champions> champs)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo f1 = new System.IO.FileInfo("Champions.bin");
                using (var binaryFile = f1.Create())
                {
                    binaryFormatter.Serialize(binaryFile, champs);
                    binaryFile.Flush();
                }
            }

            public static BindingList<Champions> LoadChampionsFromFile()
            {
                BindingList<Champions> champs;
            
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileInfo f1 = new System.IO.FileInfo("Champions.bin");
                    using (var binaryFile = f1.OpenRead())
                    {
                        champs = (BindingList<Champions>)binaryFormatter.Deserialize(binaryFile);
                    }
                }

                catch (Exception ex)
                {
                    champs = new BindingList<Champions>();
                }
                return champs;
            }
    }
}





