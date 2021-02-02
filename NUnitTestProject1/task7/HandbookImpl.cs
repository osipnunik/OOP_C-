using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NUnitTestProject1.task7
{
    class HandbookImpl : Handbook
    {
        private const string fileName = "Automobile.dat";
        List<Auto> autos = new List<Auto>();
        public void AddAuto(Auto auto)
        {
            autos.Add(auto);
        }
        public void DeleteAuto(Auto auto)
        {
            autos.Remove(auto);
        }

        public List<Auto> ExtractFromFile()
        {
            Stream str = File.Open(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Auto> autos = (List<Auto>)bf.Deserialize(str);
            str.Close();
            return autos;
        }

        public void SaveToFile()
        {
            Stream str = File.Open(fileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(str, autos);
            str.Close();
        }

        public Auto SearchAuto(string name)
        {
            foreach(Auto auto in autos)
            {
                if (auto.getName().Equals(name))
                {
                    return auto;
                }
            }
            return null;
        }

        public void UpdateAuto(Auto auto, string name)
        {
            for(int i = 0; i < autos.Count; i++)
            {
                if (autos[i].getName().Equals(name))
                {
                    autos[i] = auto;
                }
            }
        }
    }

}
