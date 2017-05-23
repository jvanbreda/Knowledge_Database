using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyTank kappaTank = new EnemyTank();

            EnemyRobot pepeBot = new EnemyRobot();

            IEnemyAttacker robotAdapter = new EnemyRobotAdapter(pepeBot);

            Console.WriteLine("####### The Robot #######");

            pepeBot.reactToHuman("Swen");
            pepeBot.walkForward();
            pepeBot.smashWithHands();

            Console.WriteLine("####### The Enemy Tank #######");

            kappaTank.assignDriver("Jesse");
            kappaTank.driveForward();
            kappaTank.fireWeapon();

            Console.WriteLine("####### Robot with Adapter #######");

            robotAdapter.assignDriver("Gert-Jan");
            robotAdapter.driveForward();
            robotAdapter.fireWeapon();

            Console.Read();
        }
    }
}
