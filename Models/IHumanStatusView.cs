using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface IHumanStatusView : IView
    {
        decimal NumberOfFloorOrLift { get; }

        bool isLiftChecked { get; }

        event Action UpdateTable;

        void LoadTable(IEnumerable<String> people);

    }
}
