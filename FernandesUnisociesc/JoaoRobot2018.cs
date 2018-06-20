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
        private bool peek;
        private double moveAmount;

        public override void Run()
        {
            moveAmount = Math.Max(BattleFieldWidth, BattleFieldHeight);

            peek = false;

            TurnLeft(Heading % 90);
            Ahead(moveAmount);

            peek = true;
            TurnGunRight(90);
            TurnRight(90);

            while (true)
            {

                peek = true;

                Ahead(moveAmount);
 
                peek = false;

                TurnRight(90);
            }
        }

        public override void OnHitRobot(HitRobotEvent e)
        {
            if (e.Bearing > -90 && e.Bearing < 90)
            {
                Back(100);
            } 
            else
            {
                Ahead(100);
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            smartFire(e.Distance);

            if (peek)
            {
                Scan();
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
