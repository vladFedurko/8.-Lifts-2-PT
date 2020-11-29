using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8.Lifts_2__PT;

namespace Presenters
{
    interface IMainView : IView
    {

        void ShowState();

        void SetParameters(int floors, int lifts);

    }
}
