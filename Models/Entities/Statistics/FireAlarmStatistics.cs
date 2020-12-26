using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Statistics
{
    public class FireAlarmStatistics : IFireAlarmStatistics
    {
        private int countOfAlarms;
        private decimal totalTimeOfAlarms;

        private decimal startTimeOfFireAlarm;

        public FireAlarmStatistics()
        {
            countOfAlarms = 0;
            totalTimeOfAlarms = 0;
            startTimeOfFireAlarm = -1;
        }

        public void SetStartTime(decimal time)
        {
            startTimeOfFireAlarm = time;
            countOfAlarms++;
        }

        public void SetEndTime(decimal time)
        {
            totalTimeOfAlarms += time - startTimeOfFireAlarm;
        }

        public int GetCountOfAlarms() => countOfAlarms;

        public decimal GetTotalTimeOfAlarms() => totalTimeOfAlarms;
    }
}
