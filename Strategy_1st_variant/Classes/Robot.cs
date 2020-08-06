using Strategy_1st_variant.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_1st_variant.Classes
{
    class Robot
    {
        public string Name { get; set; }  // поле отвечает за имя объекта 
        public ISomeRobotTask robotTask { private get; set; } // реализуем только сеттер

        // режим по умолчанию
        public Robot()
        {
            this.Name = "Hall900";
            this.robotTask = new SleepMode();
        }


        public Robot(ISomeRobotTask task)
        {
            this.robotTask = task;
        }

        public void RobotMode() =>
            robotTask.RobotMode();
    }
}
