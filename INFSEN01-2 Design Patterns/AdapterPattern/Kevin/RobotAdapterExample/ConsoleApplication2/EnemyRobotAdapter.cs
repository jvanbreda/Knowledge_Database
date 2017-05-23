using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAdapterExample
{
    class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot robot;

        public EnemyRobotAdapter (EnemyRobot newRobot)
        {
            this.robot = newRobot;
        }

        public void fireWeapon()
        {
            robot.smashWithHands();
        }

        public void driveForward()
        {
            robot.walkForward();
        }

        public void assignDriver(string driverName)
        {
            robot.reactToHuman(driverName);
        }

        

        
    }
}
