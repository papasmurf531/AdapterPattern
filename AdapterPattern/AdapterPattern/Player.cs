using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public class Player
    {
       private int health;
       private int dam;
       public Player(int health)
       {
           this.health = health;
       }

       public void setHealth(int health)
       {
           this.health = health;
       }

       public int getHealth()
       {
           return health;
       }

       public void setDamage()
       {
           Random rng = new Random();
           dam = rng.Next(200);
       }

       public int getDamage()
       {
           return dam;
       }

    }
}
