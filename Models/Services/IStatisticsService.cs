using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IStatisticsService : IService
    {
        public void ExportToFile(string path);

        public IEnumerable<string> GetStatistics();
    }
}
