using Strategy_1st_variant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_1st_variant.Classes
{
    class SleepMode : ISomeRobotTask
    {
        public void RobotMode()
        {
            Console.WriteLine("Robot is in SleepMode !!");
        }
    }
}
