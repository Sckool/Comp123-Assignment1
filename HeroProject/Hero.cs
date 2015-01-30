using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroProject
{
    class Hero
    {
        // PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++
        private int speed;
        private int strength;
        private int health;
        private int currentHealth =100;

        // Public Properties
        public string name;

        //CUNSTROCTOR 
        public void everything(string name)
        {
            this.name = name;
            Console.WriteLine("Hero");
            generateAbilities(this.speed, this.strength, this.health);
        }
       
        //Generating Random numbers between 1-100 for each of the veriables
        private void generateAbilities(int strength, int speed, int health)
        {
            Random RND = new Random(); //RND = random. just a veriable 
            this.strength = RND.Next(1, 100);
            Random healthRND = new Random();
            this.health = RND.Next(1, 100);
            Random speedRND = new Random();
            this.speed = RND.Next(1, 100);
           
             
        }
        // this method looks at the hit attempt as well as the chance to get the hit attempt and calls the hitDamage method
        private bool hitAttempt()
        {
           bool attempt;
            double hit;// variable i used to get the 20% of	the	time
            Random number = new Random();//number is a variable
            hit = number.Next(1,100);
           
                if (hit <= 20)// if the hit is lower then 20 it becomes true and the damage goes through and hits
                {
                    attempt = true;
                    hitDamage();
                    Console.WriteLine("Hit: {0}", hitDamage());// desplays the damage when hit
                    hitDamage();
                   
                }
                else// if false nothing happens
                {
                    attempt = false;
                    Console.WriteLine("Miss");//desplays the damage when miss
                
                }               
            
               return attempt;
        }

        //calculates the hit damage using random 1-6 numbers * the Random created strength
       private int hitDamage()
        {
            int damage;
            Random number = new Random();
            damage = number.Next(1, 6);// random number created
            damage = damage * this.strength;// random number * strength
            
            return damage;
 
        }
        // Desplays the stats for my Hero charecter
        public void show()
       {
           Console.WriteLine("Strength {0}", this.strength);
           Console.WriteLine("Health {0}", this.health);
           Console.WriteLine("Speed {0}", this.speed);
           Console.WriteLine();
       }
        //This method calls the hitAttempt
        public void fight()
        {
            hitAttempt();
        }

}
}