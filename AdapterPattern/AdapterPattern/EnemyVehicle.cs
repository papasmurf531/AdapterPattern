using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //Adaptee
    class EnemyVehicle
    {
       private int spaces;
       private int harm;
       private string driver;
       private int health;

        public void driveForward()
        {
            Random rng = new Random();
             spaces = rng.Next(10);
        }

        public void driveOver()
        {
            Random rng = new Random();
             harm = rng.Next(125);
        }

        public void assignDriver(string driver)
        {
            this.driver = driver;
        }

        public int getMovement()
        {
            return spaces;
        }

        public int getDamage()
        {
            return harm;
        }

        public string getDriver()
        {
            return driver;
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
