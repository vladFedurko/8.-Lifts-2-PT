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
        private ISimulationStatisticsView _view;
        private IStatisticsService _statisticsService;
        private IFileWorkService _fileWorkService;

        public StatisticsPresenter(ISimulationStatisticsView veiw, IStatisticsService statisticsService,IFileWorkService fileWorkService)
        {
            _view = veiw;
            _statisticsService = statisticsService;
            _fileWorkService = fileWorkService;
            _view.LoadStatistics(statisticsService.GetStatistics());
            _view.setFilter(_fileWorkService.getFilter());
            _view.ExportToFile += this.ExportToFile;
        }

        public void ExportToFile(string path)
        {
            _fileWorkService.saveStatistics(path);
        }
    }
}
