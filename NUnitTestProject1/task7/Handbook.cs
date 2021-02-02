using System.Collections.Generic;

namespace NUnitTestProject1.task7
{
    interface Handbook
    {
        public void AddAuto(Auto auto);
        public void DeleteAuto(Auto auto);
        public void UpdateAuto(Auto auto, string name);
        public Auto SearchAuto(string name);
        public void SaveToFile();
        public List<Auto> ExtractFromFile();
    }
}
