using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface ICreateHumanView : IView
    {
        event Action<int, int, int,int> CreateHuman;
    }
}
