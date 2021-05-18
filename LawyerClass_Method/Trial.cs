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
        public int jurors;
        public string judge;

        public int trials;
        public int hearings;
        string result;

        //Constructor

        public Trial (string trialName, int numberPotentialJurors, int seatedJurors, string judgeName, int numberOfTrials, int numberOfHearings)
        {
            name = trialName;
            numberOfPotentialJurors = numberPotentialJurors;
            judge = judgeName;     
            jurors = seatedJurors;
            hearings = numberOfHearings;
            trials = numberOfTrials;
        }

        //can do
        public void DisplayTrialParameters()
        {
            Console.WriteLine();
            Console.WriteLine($"{name}, {numberOfPotentialJurors} possible jurors, {jurors} seated jurors. Presiding Judge : {judge}");
            Console.ReadLine();
        }
         public void TotalNumberAppearances()
        {
            Console.WriteLine($"\ntotal appearances of counsel: {trials} trials + {hearings} hearings");
            int combinedAppearances = trials + hearings;
            Console.WriteLine($"\nCounsel has {combinedAppearances} appearances");
            
        }

        public void JurySelection()
        {
            int jurorsNotChosen = numberOfPotentialJurors - jurors;
            Console.WriteLine($"\nThese many possible jurors were not seated: {jurorsNotChosen}");
            Console.ReadLine();
        }


    }
}
