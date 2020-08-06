using Strategy_1st_variant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_1st_variant.Classes
{
    class FigthMode : ISomeRobotTask
    {
        public void RobotMode()
        {
            Console.WriteLine("Robot's weapon is active!! FightMode set to ON!!");
        }
    }
}
