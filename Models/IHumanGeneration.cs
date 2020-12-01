using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Models
{
    public interface IHumanGeneration : IService
    {
        event Action<DataTable> GenerateHumans;

        void InitTable(out DataTable dTable);

        void LoadTable(DataTable dTable);
    }
}
