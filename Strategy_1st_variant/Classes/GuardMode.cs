using Strategy_1st_variant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_1st_variant.Classes
{
    class GuardMode : ISomeRobotTask
    {
        public void RobotMode()
        {
            Console.WriteLine("Robot in GuardMod !!");
        }
    }
}
