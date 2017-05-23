using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAdapterExample
{
    class EnemyTank : IEnemyAttacker
    {
        Random randomGenerator = new Random();

        public void fireWeapon()
        {
            int damage = randomGenerator.Next(1, 10) + 1;

            Console.WriteLine("Enemy Tank Does " + damage + " Damage");
        }

        public void driveForward()
        {
            int movement = randomGenerator.Next(1, 5) + 1;

            Console.WriteLine("Enemy Tank moves " + movement + " spaces");

        }

        public void assignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the tank");
        }
        
    }
}
