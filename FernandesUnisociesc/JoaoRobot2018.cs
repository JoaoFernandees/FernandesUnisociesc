using Robocode;
using Robocode.Util;
using Robocode.RobotInterfaces;
using Robocode.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandesUnisociesc
{
    public class JoaoRobot2018 : AdvancedRobot
    {
        public override void Run()
        {

            //TurnRadarLeftRadians(Math.PI);
            SetTurnRadarRightRadians(Double.PositiveInfinity);

            while (true)
            {
                //SetAhead(100);
                //SetTurnLeft(50);
                SetTurnRadarLeft(10);
                SetTurnGunLeft(5);
                //SetTurnGunLeft(360);
                //IsAdjustRadarForGunTurn = true;
                Execute();
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            double GetRadarTurnRemainingRadians = 0;
            SetTurnRadarLeftRadians(GetRadarTurnRemainingRadians);
            Fire(1);
            Execute();
        }

        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            SetAhead(200);
            SetTurnLeft(150);
        }
    }
}
