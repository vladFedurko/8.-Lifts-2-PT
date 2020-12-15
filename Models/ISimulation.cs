using Models.LiftManager;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ISimulation
    {
        public void SetService(IMainService ser);

        public void Pause();

        public void SetSpeed(decimal speed);

        public SystemData GetData();

        public void Start();

        public bool Stop();

        public bool TurnOnFireAlarm();

        public bool TurnOffFireAlarm();

        public int GetCurrentTime();

        public void DoTick();

        IMainService GetMainService();

        public bool IsStoped();
    }
}
