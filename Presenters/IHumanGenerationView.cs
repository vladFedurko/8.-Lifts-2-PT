using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Presenters
{
    public interface IHumanGenerationView : IView
    {
        event Action<DataTable> GenerateHumans;
    }
}
