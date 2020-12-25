using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Statistics
{
    public interface ILiftStatistics : IStatistic
    {
        public void MovedWithoutHumans();

        public void HumansCarried(int humansCount);

        public void DirectionChanged();

        public int GetCountOfTrips();

        public int GetCountOfIdleMoves();

        public int GetCountOfCarriedHumans();
    }
}
