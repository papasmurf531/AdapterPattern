using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPattern
{
    public partial class Form1 : Form
    {
        public Player user = new Player(500);
        
        public bool isVehicle = false;
        public bool isTrooper = false;

        public int userDamDelt;
        public int enemyDamDelt;
       

        static EnemyVehicle banshee = new EnemyVehicle();
        EnemyVehicleAdapter bansheeAdapter = new EnemyVehicleAdapter(banshee);
        EnemyTroop brute = new EnemyTroop();


        public Form1()
        {           
            InitializeComponent();
            playerHealthLbl.Text = "" + user.getHealth();
            shootBtn.Enabled = false;         
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            isVehicle = true;
           
            banshee.setHealth(1000);
            enemyHealthLbl.Text = "" + banshee.getHealth();
            bansheeAdapter.assignSquad("Elite");  //Calls the assignDriver function in EnemyVehicle
            outputTb.Text = "The driver of the banshee is a Covenant " + banshee.getDriver() + ".";
            outputTb.AppendText ("The Banshee has an intial health level of " + banshee.getHealth() + ".");
            buttonDisable();
            shootBtn.Enabled = true;
        }

        private void enemyTroopBtn_Click(object sender, EventArgs e)
        {
            isTrooper = true;
            brute.setHealth(300);
            enemyHealthLbl.Text = "" + brute.getHealth();
            brute.assignSquad("Omega");
            outputTb.Text = "The Enemy Trooper is a Brute and is part of the " + brute.getSquad() + " squad.";
            outputTb.AppendText("\r\n" +" The Brute has an intial health level of " + brute.getHealth() + ".");
            buttonDisable();
            shootBtn.Enabled = true;
        }



       

        private void shootBtn_Click(object sender, EventArgs e)
        {
            int userHealth = user.getHealth();
            int enemyHealth;
            int movement;
            bool victory = false;
            bool alive = true;
            user.setDamage();
            userDamDelt = user.getDamage();


            if (isTrooper == true)
            {
                brute.fireWeapon();
                brute.moveForward();
                enemyDamDelt = brute.getWeaponDamage();               
                movement = brute.getMovement();
                outputTb.AppendText("\r\n" + "The Brute has delt " + enemyDamDelt + " points of damage to you & moved " + movement + " feet towards you.");
                enemyHealth = brute.getHealth();
                enemyHealth = enemyHealth - userDamDelt;
                brute.setHealth(enemyHealth);
                enemyHealthLbl.Text = "" + brute.getHealth();
            }

            if (isVehicle == true)
            {
                bansheeAdapter.fireWeapon(); //calls the runOver method in Enemy Vehicle
                bansheeAdapter.moveForward(); //calls the driveOver method in Enemy Vehicle
                enemyDamDelt = banshee.getDamage();
                movement = banshee.getMovement();
                outputTb.AppendText("\r\n" + "The Banshee ran into you and delt " + enemyDamDelt + " points of damage to you & moved back " + movement + " feet.");
                enemyHealth = banshee.getHealth();
                enemyHealth = enemyHealth - userDamDelt;
                banshee.setHealth(enemyHealth); 
                enemyHealthLbl.Text = "" + banshee.getHealth();              
            }

            userHealth = userHealth - enemyDamDelt;
            user.setHealth(userHealth);
            playerHealthLbl.Text = "" + userHealth;
            victory = checkPlayerWin();
            alive = checkPlayerLoss();

            if (alive == false)
            {
                outputTb.AppendText("\r\n" + "GAME OVER! You died. hit reset to try again!");
                shootBtn.Enabled = false;
            }

            if (victory == true)
            {
                outputTb.AppendText("\r\n" + "CONGRATULATIONS! You defeated the enemy. Hit the reset button to start a new match.");
                shootBtn.Enabled = false;
            }

            if (victory == false && alive == true)
                outputTb.AppendText("\r\n" + "Don't stop fighting");

            
            //checkPlayerLoss();

        }

       

        private void resetBtn_Click(object sender, EventArgs e)
        {
            banshee.setHealth(1000);
            brute.setHealth(300);
            user.setHealth(500);
            outputTb.Text = " ";
            enemyHealthLbl.Text = "Null";
            playerHealthLbl.Text = "" + user.getHealth();
            isVehicle = false;
            isTrooper = false;
            buttonEnable();
            shootBtn.Enabled = true;
        }

        private bool checkPlayerLoss()
        {
            if (user.getHealth() <= 0)                         
                return false;   //make false        

            else                      
                return true;  //make true
        
        }

        private bool checkPlayerWin()
        {
            if (isVehicle == true && banshee.getHealth() <= 0)
            {
                shootBtn.Enabled = false;
                return true;
            }

            if (isTrooper == true && brute.getHealth() <= 0)
            {
                shootBtn.Enabled = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonDisable()
        {
            vehicleBtn.Enabled = false;
            enemyTroopBtn.Enabled = false;
        }

        private void buttonEnable()
        {
            vehicleBtn.Enabled = true;
            enemyTroopBtn.Enabled = true;
        }

        private void outputTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
