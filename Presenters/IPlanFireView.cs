using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Presenters
{
    public interface IPlanFireView : IView
    {
        event Action<DataTable> PlanFireAlarm;
        void LoadTable(DataTable dTable);
    }
}
