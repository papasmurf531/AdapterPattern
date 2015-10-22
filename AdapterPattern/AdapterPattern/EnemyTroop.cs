using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class EnemyTroop: EnemyActions
    {
        private int steps;
        private int damage;
        private string squad;
        private int health;

        public override void moveForward()
        {           
            Random rng = new Random();
             steps = rng.Next(10);
        }

        public override void fireWeapon()
        {          
            Random rng = new Random();
             damage = rng.Next(100);
        }

        public override void assignSquad(string squad)
        {
            this.squad = squad;        
        }

        public int getMovement()
        {
            return steps; 
        }

        public int getWeaponDamage()
        {
            return damage;
        }

        public string getSquad()
        {
            return squad;
        }

        public void setHealth(int health)
        {
            this.health = health;
        }

        public int getHealth()
        {
            return health;
        }
    }
}
