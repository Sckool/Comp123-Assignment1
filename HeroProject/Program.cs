/*Author = Rishav Giri
 * Date last modified = Jan 30/2015
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroProject
{
    class Program

    {
        
        static void Main(string[] args)
        { 
          
           SuperHero newmain = new SuperHero();
           newmain.everything("");
           newmain.SuperHeroCon("");
           newmain.showPowers();    
           newmain.show();
           newmain.fight();
           Console.ReadKey();
          

        }
    }
}
