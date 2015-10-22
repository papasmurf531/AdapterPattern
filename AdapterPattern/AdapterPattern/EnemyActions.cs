using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Target
   public abstract class EnemyActions
    {       

        public abstract void moveForward();

        public abstract void fireWeapon();

        public abstract void assignSquad(string squad);

    }
}
