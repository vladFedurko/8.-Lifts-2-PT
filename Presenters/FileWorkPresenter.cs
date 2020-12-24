using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Services;

namespace Presenters
{
    public class FileWorkPresenter
    {
        private IFileWorkView _view;
        private IFileWorkService _Service;

        public FileWorkPresenter(IFileWorkView view,SystemData data)
        {
            _view = view;
            _Service = new FileWorkService(data);
            _view.setFilter(_Service.getFilter());
            InitEvents();
        }
        private void InitEvents()
        {
            _view.LoadHumanGenerationStrategy += this.LoadGenerationTable;
            _view.LoadLiftConfigurationStrategy += this.LoadLiftConfiguration;
            _view.SaveHumanGenerationStrategy += this.SaveGenerationTable;
            _view.SaveLiftConfigurationStrategy += this.SaveLiftConfiguration;
        }
        public void LoadGenerationTable(string filename)
        {
            _Service.openGenerationTable(filename);
        }

        public void LoadLiftConfiguration(string filename)
        {
            _Service.openLiftConfig(filename);
        }

        public void SaveGenerationTable(string filename)
        {
            _Service.saveGenerationTable(filename);
        }

        public void SaveLiftConfiguration(string filename)
        {
            _Service.saveLiftConfig(filename);
        }
    }
}
