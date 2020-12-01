using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Models
{
    public interface IPlanFireAlarm : IService
    {
        event Action<DataTable> PlanFireAlarm;

        void InitTable(out DataTable dTable);

        void LoadTable(DataTable dTable);
    }
}
