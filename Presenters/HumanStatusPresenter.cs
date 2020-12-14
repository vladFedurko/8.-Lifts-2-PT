using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Services;
using Models.Entities;

namespace Presenters
{
    public class HumanStatusPresenter
    {
        private IHumanStatusView _view;
        private IHumanCreationService _creationService;

        public HumanStatusPresenter(IHumanStatusView view, IHumanCreationService creationService)
        {
            _view = view;
            _creationService = creationService;
            _view.UpdateTable += this.UpdateTable;
            this.UpdateTable();
        }

        public void UpdateTable()
        {
            IEnumerable<Human> keepers;
            if(_view.isLiftChecked)
            {
                keepers = _creationService.GetLiftByNumber((int)_view.NumberOfFloorOrLift - 1).getHumans();
            } else
            {
                keepers = _creationService.GetFloorByNumber((int)_view.NumberOfFloorOrLift - 1).getHumans();
            }
            Dictionary<string, int> fullStatus = new Dictionary<string, int>();
            string humStatus;
            foreach(var hum in keepers)
            {
                humStatus = hum.GetStatus();
                if (fullStatus.ContainsKey(humStatus))
                {
                    fullStatus[humStatus] ++;
                } else
                {
                    fullStatus.Add(humStatus, 1);
                }
            }
            _view.LoadTable(fullStatus);
        }
    }
}
