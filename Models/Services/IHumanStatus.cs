using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IHumanStatus : IService
    {
        decimal NumberOfFloorOrLift { get; }

        bool isLiftChecked { get; }

        event Action UpdateTable;

        void LoadTable(IEnumerable<String> people);

    }
}
