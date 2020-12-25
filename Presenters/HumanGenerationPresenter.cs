using Models.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class HumanGenerationPresenter
    {
        private IHumanGenerationView _view;
        private IHumanCreationService _service;

        public HumanGenerationPresenter(IHumanGenerationView view, IHumanCreationService service)
        {
            this._view = view;
            this._service = service;
            InitEvents();
        }

        private void InitEvents()
        {
            _view.GenerateHumans += this.GenerateHuman;
        }

        public void GenerateHuman(DataTable dataTable)
        {
            _service.CreateHumanGenerationTable(dataTable); //отсчет с 0
        }
        public DataTable LoadTable()
        {
           return _service.GetHumanGenerationTable();
        }

    }
}
