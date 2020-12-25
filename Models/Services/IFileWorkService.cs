using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IFileWorkService
    {
        string getFilter();
        void saveLiftConfig(string filename);
        void saveGenerationTable(string filename);
        void openLiftConfig(string filename);
        void openGenerationTable(string filename);
        public void saveStatistics(string filename);
    }
}
