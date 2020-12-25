using Models.FileWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Models.Services
{
    public class FileWorkService : IFileWorkService
    {
        IHumanCreationService HumanCreationService;
        ISystemParametersService systemParametersService;
        public FileWorkService(SystemData data)
        {
            HumanCreationService = new HumanCreationService(data);
            systemParametersService = new SystemParametersService(data);
        }
        public string getFilter()
        {
            return AText.Filter +"|"+ ABinary.Filter;
        }

        public void openGenerationTable(string filename)
        {
            string format = getFormat(filename);
            if (format.Equals(AText.Format))
            {
                TextLoadGenTable textLoader = new TextLoadGenTable();
                HumanCreationService.CreateHumanGenerationTable((DataTable)textLoader.Load(filename));
            }
            else if (format.Equals(ABinary.Format))
            {
                BinaryDeserializer binLoader = new BinaryDeserializer();
                HumanCreationService.CreateHumanGenerationTable((DataTable)binLoader.Load(filename));
            }
        }

        public void openLiftConfig(string filename)
        {
            string format = getFormat(filename);
            if (format.Equals(AText.Format))
            {
                TextLoadLiftConf textLoader = new TextLoadLiftConf();
                systemParametersService.SaveSystemParameters((SimulationParameters)textLoader.Load(filename));
            }
            else if (format.Equals(ABinary.Format))
            {
                BinaryDeserializer binLoader = new BinaryDeserializer();
                systemParametersService.SaveSystemParameters((SimulationParameters)binLoader.Load(filename));
            }
        }

        public void saveGenerationTable(string filename)
        {
            string format = getFormat(filename);
            if (format.Equals(AText.Format))
            {
                new TextSaveGenTable().Save(filename,HumanCreationService.GetHumanGenerationTable());
            }
            else if (format.Equals(ABinary.Format))
            {
                new BinarySerializer().Save(filename, HumanCreationService.GetHumanGenerationTable());
            }
        }

        public void saveLiftConfig(string filename)
        {
            string format = getFormat(filename);
            if (format.Equals(AText.Format))
            {
                new TextSaveLiftConf().Save(filename, systemParametersService.GetSystemParameters());
            }
            else if (format.Equals(ABinary.Format))
            {
                new BinarySerializer().Save(filename,systemParametersService.GetSystemParameters());
            }
        }

        private string getFormat(string filename)
        {
            string[] c = filename.Split('.');
            return c[c.Length - 1];
        }

    }
}
