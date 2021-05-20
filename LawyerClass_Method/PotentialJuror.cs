using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerClass_Method
{
    class PotentialJuror
    {
        //has
        int age;
        string name;
        string willConvict;

        //spawn
        public PotentialJuror(int incomingAge, string incomingName, string incomingDecision)
        {
            age = incomingAge;
            name = incomingName;
            willConvict = incomingDecision;
        }

        public void JurorFacts()
        {
            Console.WriteLine($"{name} is {age} y.o. and will return {willConvict}");
            //Console.ReadLine();
        }
    }
}
