using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerClass_Method
{
    class Trial
    {
        //has
        public string name;
        public int numberOfPotentialJurors;
        public int seatedJurors;
        public string judge;

        public int numberOfTrials;
        public int numberOfHearings;
        string result;

        //Constructor

        public Trial (string trialName, int numberPotentialJurors, int seatedJurors, string judgeName)
        {
            name = trialName;
            numberOfPotentialJurors = numberPotentialJurors;
            numberOfHearings = seatedJurors;
            judge = judgeName;           ;
        }

        //can do
        public void DisplayTrialParameters()
        {
            Console.WriteLine($"{name}, {numberOfPotentialJurors} possible jurors, {seatedJurors} seated jurors. Presiding Judge : {judge}");
            Console.ReadLine();
        }




    }
}
