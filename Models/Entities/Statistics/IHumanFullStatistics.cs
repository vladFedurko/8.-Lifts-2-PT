using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Statistics
{
    public interface IHumanFullStatistics : IStatistic
    {
        void AddWaitingTime(decimal time);

        decimal GetMaxWaitingTime();

        int GetCountOfCarriedHumans();

        decimal GetTotalWaitingTime();

        decimal GetMeanWaitingTime();
    }
}
