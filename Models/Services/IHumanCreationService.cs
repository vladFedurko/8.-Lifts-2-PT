using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IHumanCreationService : IService
    {
        void CreateHuman(int humanNumber,int initialFloor, int finiteFloor, int inSeconds);

        void CreateHumanGenerationTable(DataTable dataTable);
        DataTable GetHumanGenerationTable();
        Floor GetFloorByNumber(int num);

        Lift GetLiftByNumber(int num);
    }
}
