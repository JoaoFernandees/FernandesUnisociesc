using Robocode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandesUnisociesc
{
    public class JoaoRobot2018 : Robot
    {
        public override void Run()
        {
            while(true)
            {
                Ahead(100);
                TurnLeft(90);
            }
        }
    }
}
