using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAdapterExample
{    
    class EnemyRobot
    {
        Random randomGenerator = new Random();

        public void smashWithHands()
        {
            int damage = randomGenerator.Next(1, 10) + 1;
            Console.WriteLine("Robot does " + damage + " damage with hands");
        }

        public void walkForward()
        {
            int movement = randomGenerator.Next(1, 10) + 1;
            Console.WriteLine("Robot walked " + movement + " spaces");
        }

        public void reactToHuman(string driverName)
        {
            Console.WriteLine("Robot encountered " + driverName);
        }
    }
}
