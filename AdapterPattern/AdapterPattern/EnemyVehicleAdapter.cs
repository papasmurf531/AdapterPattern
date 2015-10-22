using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class EnemyVehicleAdapter: EnemyActions
    {
        EnemyVehicle myVehicle;       

        public EnemyVehicleAdapter(EnemyVehicle newVehicle)
        {
            myVehicle = newVehicle;
        }

        public override void moveForward()
        {
            myVehicle.driveForward();
        }

        public override void fireWeapon()
        {
            myVehicle.driveOver();
        }

        public override void assignSquad(string squad)
        {
            myVehicle.assignDriver(squad);
        }


    }
}
