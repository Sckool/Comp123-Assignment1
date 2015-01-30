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
           Hero main = new Hero();
           main.everything("");
           main.show();
           main.fight();
           Console.ReadKey();

        }
    }
}
