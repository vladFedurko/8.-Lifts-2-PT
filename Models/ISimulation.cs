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
        public void ChangeStrategy(ILiftManager st);

        public void SetService(IMainService ser);

        public void Pause();

        public void SetSpeed(decimal speed);

        public SystemData GetData();

        public void Start();

        public void Stop();

        public void TurnOnFireAlarm();

        public void TurnOffFireAlarm();

        public int GetCurrentTime();

        public void DoTick();
    }
}
