using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Statistics
{
    public class LiftStatistics : ILiftStatistics
    {
        private int countOfTrips;
        private int countOfIdleMoves;
        private int countOfCarriedHumans;

        public LiftStatistics()
        {
            countOfTrips = 0;
            countOfIdleMoves = 0;
            countOfCarriedHumans = 0;
        }

        public void MovedWithoutHumans() => countOfIdleMoves++;

        public void HumansCarried(int humansCount) => countOfCarriedHumans += humansCount;

        public void DirectionChanged() => countOfTrips++;

        public int GetCountOfTrips() => countOfTrips;

        public int GetCountOfIdleMoves() => countOfIdleMoves;

        public int GetCountOfCarriedHumans() => countOfCarriedHumans;

    }
}
