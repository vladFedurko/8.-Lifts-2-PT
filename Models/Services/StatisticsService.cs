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

        public void ExportToFile(string path)
        {
            //TODO
        }

        public IEnumerable<string> GetStatistics()
        {
            List<string> stats = new List<string>(10);
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
            idleTrips = idleTrips * 100 / totalTrips;
            stat = data.GetLifts().Last().GetStatistics();
            trips += stat.GetCountOfTrips() + ".";
            countOfCarriedHumans += stat.GetCountOfCarriedHumans() + ".";

            stats.Add(totalTrips.ToString());
            stats.Add(idleTrips.ToString());
            stats.Add(countOfCarriedHumans);
            stats.Add(trips);
            stats.Add(totalCarriedHumans.ToString());
            stats.Add(data.GetHumanFullStatistics().GetMeanWaitingTime().ToString());
            stats.Add(data.GetHumanFullStatistics().GetMaxWaitingTime().ToString());
            stats.Add(data.GetHumanFullStatistics().GetTotalWaitingTime().ToString());
            stats.Add("");
            stats.Add("");
            return stats;
        }
    }
}
