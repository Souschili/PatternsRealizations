using Strategy_1st_variant.Classes;
using System;

namespace Strategy_1st_variant
{
    //  Стратегия — это поведенческий паттерн проектирования, который определяет семейство схожих алгоритмов 
    //  и помещает каждый из них в собственный класс,
    //    после чего алгоритмы можно взаимозаменять прямо во время исполнения программы.
    class Program
    {
        // У нас есть класс Робот , и несколько вариантов его поведения (режим  охраны, боевой режим, спящий режим)
        // при помощи патерна стратеия мы можем менять этот режим на лету( в процессе выполнения программы)

        static void Main(string[] args)
        {
            // создаем объект робот конструктор не принимает параметров , реализация предполагает что по дефолту у него режим Sleep
            var robot = new Robot();

            // смотрим режим робота
            Console.Write($"Robot name is {robot.Name} \n");
            robot.RobotMode();

            // меняем режим
            robot.robotTask = new GuardMode();
            Console.Write($"Robot change mode \n");
            robot.RobotMode();

            // боевой режим
            Console.Write($"Robot change mode \n");
            robot.RobotMode();


        }
    }
}
