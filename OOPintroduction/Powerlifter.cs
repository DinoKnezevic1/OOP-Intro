using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintroduction
{
    public class Powerlifter:Member
    {
        public override void PerformAWorkout()
        {
            Console.WriteLine("You completed your workout!\nYour stats: 20 minutes of effective workout;\n 1 and a half hours of rest -.-\n");
        }
    }
}
