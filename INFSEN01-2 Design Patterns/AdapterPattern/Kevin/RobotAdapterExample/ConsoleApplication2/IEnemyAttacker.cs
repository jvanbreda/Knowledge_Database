using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAdapterExample
{
    interface IEnemyAttacker
    {
        void fireWeapon();
        void driveForward();
        void assignDriver(string driverName);

    }
}
