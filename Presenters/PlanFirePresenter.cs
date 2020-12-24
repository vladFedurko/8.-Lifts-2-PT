using Models.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public class PlanFirePresenter
    {
        IPlanFireView _view;
        IPlanFireAlarm _serv;
        public PlanFirePresenter(IPlanFireView view, IPlanFireAlarm service)
        {
            this._view = view;
            this._serv = service;
            InitEvents();
        }

        private void InitEvents()
        {
            _view.PlanFireAlarm += this.PlanFire;
        }

        public void PlanFire(DataTable dataTable)
        {
            _serv.CreateAlarmRule(dataTable); 
        }
        public DataTable LoadTable()
        {
            return _serv.GetFireAlarmTable();
        }
    }
}
