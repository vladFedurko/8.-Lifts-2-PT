using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class StatisticsPresenter
    {
        private ISimulationStatisticsView _veiw;
        private IStatisticsService _statisticsService;

        public StatisticsPresenter(ISimulationStatisticsView veiw, IStatisticsService statisticsService)
        {
            _veiw = veiw;
            _statisticsService = statisticsService;
            _veiw.LoadStatistics(statisticsService.GetStatistics());
            _veiw.ExportToFile += this.ExportToFile;
        }

        public void ExportToFile(string path)
        {
            _statisticsService.ExportToFile(path);
        }
    }
}
