using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface ISimulationStatisticsView : IView
    {
        event Action<string> ExportToFile;

        void LoadStatistics(IEnumerable<string> stats);
        public void setFilter(string filter);
    }
}
