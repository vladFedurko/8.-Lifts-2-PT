using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class CreateHumanPresenter
    {
        private ICreateHumanView _view;
        private IHumanCreationService _service;

        public CreateHumanPresenter(ICreateHumanView view, IHumanCreationService service)
        {
            this._view = view;
            this._service = service;
            InitEvents();
        }

        private void InitEvents()
        {
            _view.CreateHuman += this.CreateHuman;
        }

        public void CreateHuman(int initialFloor, int finiteFloor, int inSeconds)
        {
            _service.CreateHuman(initialFloor - 1, finiteFloor - 1, inSeconds); //отсчет с 0
        }
    }
}
