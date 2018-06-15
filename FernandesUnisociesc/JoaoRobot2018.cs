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
        private int others;
        private static int Fernandes;
        private bool stopWhenSeeRobot;

        public override void Run()
        {
            others = Others;

            goFernandes();

            int gunIncrement = 3;

            while (true)
            {
                /*SetAhead(200);
                SetTurnLeft(50);
                Execute();*/
                
                for (int i = 0; i < 30; i++)
                {
                    TurnGunLeft(gunIncrement);
                }
                gunIncrement *= -1;
            }
        }

        public void goFernandes()
        {

            stopWhenSeeRobot = false;

            TurnRight(Utils.NormalRelativeAngleDegrees(Fernandes - Heading));

            stopWhenSeeRobot = true;

            while (true)
            {
            SetAhead(200);
            SetTurnRight(50);
            SetTurnGunLeft(90);
            Execute();
            }

            //TurnGunLeft(90);
        }

        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            if (stopWhenSeeRobot)
            {
                Stop();
                smartFire(evnt.Distance);
                Scan();
                Resume();
                Execute();
            }
            else
            {
                smartFire(evnt.Distance);
            }
        }

        public void smartFire(double robotDistance)
        {
            if (robotDistance > 200 || Energy < 15)
            {
                Fire(1);
            }
            else if (robotDistance > 50)
            {
                Fire(2);
            }
            else
            {
                Fire(3);
            }
        }
    }
}
