using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace NativeInvocationPerformance
{
    public class Class1 : BaseScript
    {
        private Vector3 v1 = new Vector3(0, 0, 0);
        private Vector3 v2 = new Vector3(0, 0, 0);

        public Class1()
        {
            Tick += OnTick;
        }

        private async Task OnTick()
        {
            await Delay(0);

            var playerPos = Game.PlayerPed.Position;

            for (int i = 0; i < 25000; i++)
            {
                Vdist2(playerPos.X, playerPos.Y, playerPos.Z, v2.X, v2.Y, v2.Z);
                //var f = Vdist2(v1.X, v1.Y, v1.Z, v2.X, v2.Y, v2.Z);
            }
        }

    }
}
