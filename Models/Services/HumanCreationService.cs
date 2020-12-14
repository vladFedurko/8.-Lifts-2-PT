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
            data.CreateHuman(initialFloor, finiteFloor, inSeconds);
        }

        public void CreateHumanGenerationTable(IEnumerable<HumanFactory> gen)
        {
            
        }

        public Floor GetFloorByNumber(int num)
        {
            return data.GetFloorByNumber(num);
        }

        public Lift GetLiftByNumber(int num)
        {
            return data.GetLifts().FirstOrDefault(l => l.getKeeperNumber() == num);
        }
    }
}
