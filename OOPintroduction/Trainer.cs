using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintroduction
{
    internal class Trainer : ITrainer
    {
        public void PerformTrainingSession()
        {
            Console.WriteLine("Group training session has ended!\n");
        }
    }
}
