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
        private IFileWorkService _fileWorkService;

        public StatisticsPresenter(ISimulationStatisticsView veiw, IStatisticsService statisticsService,IFileWorkService fileWorkService)
        {
            _veiw = veiw;
            _statisticsService = statisticsService;
            _fileWorkService = fileWorkService;
            _veiw.LoadStatistics(statisticsService.GetStatistics());
            _veiw.ExportToFile += this.ExportToFile;
        }

        public void ExportToFile(string path)
        {
            _fileWorkService.saveStatistics(path);
        }
    }
}
