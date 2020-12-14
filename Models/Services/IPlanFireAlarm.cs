using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Models.Services
{
    public interface IPlanFireAlarm : IService
    {
        void StartAlarm();
        void StopAlarm();
        void CreateAlarmRule(DataTable data);
    }
}
