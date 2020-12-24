using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Statistics
{
    public class HumanFullStatistics : IHumanFullStatistics
    {
        private int countOfHumans;
        private decimal maxWaitingTime;
        private decimal totalWatingTime;

        public HumanFullStatistics()
        {
            countOfHumans = 0;
            maxWaitingTime = 0;
            totalWatingTime = 0;
        }

        public void AddWaitingTime(decimal time)
        {
            totalWatingTime += time;
            countOfHumans++;
            if (time > maxWaitingTime)
                maxWaitingTime = time;
        }

        public decimal GetMaxWaitingTime() => maxWaitingTime;

        public int GetCountOfCarriedHumans() => countOfHumans;

        public decimal GetTotalWaitingTime() => totalWatingTime;

        public decimal GetMeanWaitingTime() => totalWatingTime / countOfHumans;
    }
}
