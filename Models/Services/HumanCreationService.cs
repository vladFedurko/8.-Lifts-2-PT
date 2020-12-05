using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Services
{
    public class HumanCreationService : IHumanCreationService
    {
        private SystemData data;

        public HumanCreationService(SystemData data)
        {
            this.data = data;
        }

        public void CreateHuman(int initialFloor, int finiteFloor, int inSeconds)
        {
            data.GetFloorByNumber(initialFloor).AddHumans(new Entities.Human(finiteFloor)); //пока без задержки
        }

        public void CreateHumanGenerationTable(IEnumerable<HumanGenerationRule> gen)
        {
            
        }
    }
}
