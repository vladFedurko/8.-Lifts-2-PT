using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Statistics
{
    public interface IFireAlarmStatistics : IStatistic
    {
        public void SetStartTime(decimal time);

        public void SetEndTime(decimal time);

        public int GetCountOfAlarms();

        public decimal GetTotalTimeOfAlarms();
    }
}
