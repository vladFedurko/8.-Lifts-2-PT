using Models.Entities.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public class StatisticsService : IStatisticsService
    {
        private SystemData data;

        public StatisticsService(SystemData data)
        {
            this.data = data;
        }
        public void ResetStatistics() { data.RemoveAllStatistics(); }

        public IEnumerable<string> GetStatistics()
        {
            List<string> stats = new List<string>(10);
            this.SetLiftStatistics(stats);
            this.SetHumanStatistics(stats);
            this.SetFireAlarmStatistics(stats);
            return stats;
        }

        private void SetLiftStatistics(List<string> stats)
        {
            string trips = "";
            string countOfCarriedHumans = "";
            decimal idleTrips = 0;
            int totalTrips = 0;
            int totalCarriedHumans = 0;
            ILiftStatistics stat;
            for (int i = 0; i < data.GetParameters().LiftsCount - 1; ++i)
            {
                stat = data.GetLifts().ElementAt(i).GetStatistics();
                totalTrips += stat.GetCountOfTrips();
                trips += stat.GetCountOfTrips() + ", ";
                totalCarriedHumans += stat.GetCountOfCarriedHumans();
                countOfCarriedHumans += stat.GetCountOfCarriedHumans() + ", ";
                idleTrips += stat.GetCountOfIdleMoves();
            }
            stat = data.GetLifts().Last().GetStatistics();
            trips += stat.GetCountOfTrips() + ".";
            totalTrips += stat.GetCountOfTrips();
            totalCarriedHumans += stat.GetCountOfCarriedHumans();
            countOfCarriedHumans += stat.GetCountOfCarriedHumans() + ".";
            idleTrips += stat.GetCountOfIdleMoves();
            if (totalTrips != 0)
                idleTrips = idleTrips * 100 / totalTrips;
            else
                idleTrips = 0;

            stats.Add(totalTrips.ToString());
            stats.Add(idleTrips.ToString());
            stats.Add(countOfCarriedHumans);
            stats.Add(trips);
            stats.Add(totalCarriedHumans.ToString());
        }

        private void SetHumanStatistics(List<string> stats)
        {
            stats.Add(data.GetHumanStatistics().GetMeanWaitingTime().ToString());
            stats.Add(data.GetHumanStatistics().GetMaxWaitingTime().ToString());
            stats.Add(data.GetHumanStatistics().GetTotalWaitingTime().ToString());
        }

        private void SetFireAlarmStatistics(List<string> stats)
        {
            stats.Add(data.GetFireAlarmStatistics().GetCountOfAlarms().ToString());
            stats.Add(data.GetFireAlarmStatistics().GetTotalTimeOfAlarms().ToString());
        }
    }
}
