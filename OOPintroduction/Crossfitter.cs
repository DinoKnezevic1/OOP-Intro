using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintroduction
{
    public class Crossfitter : Member
    {
        public override void PerformAWorkout()
        {
            Console.WriteLine("You just completed a crossfit workout.\nEverybody looked at you like you are weird O.O!\n");

        }
    }
}
