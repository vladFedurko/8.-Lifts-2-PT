using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IHumanCreationService : IService
    {
        void CreateHuman(int initialFloor, int finiteFloor, int inSeconds);

        void CreateHumanGenerationTable(IEnumerable<HumanFactory> gen);
    }
}
