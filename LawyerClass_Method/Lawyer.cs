using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerClass_Method
{
    public class Lawyer
    {
        public string name;
        public int yearsExperience;
        public int trialsPerYear;
        public int hearingsPerYear;

        public int numberOfTrials;
        public int numberOfHearings;

        public Lawyer(string lawyerName, int totalNumberOfTrials, int totalNumberOfHearings)
        {
            name = lawyerName;
            numberOfTrials = totalNumberOfTrials;
            numberOfHearings = totalNumberOfHearings;
        }

        public void CheckInOffice()
        {
            Console.WriteLine($"{name} is in the office");
        }
        public int CareerTotalHearings()
        {
            numberOfHearings = yearsExperience * trialsPerYear;
            Console.WriteLine($"{name} has a {numberOfHearings}");
            return numberOfHearings;
        }

        public void CareerTotalTrials()
        {
            numberOfTrials = yearsExperience * trialsPerYear;
            Console.WriteLine($"{name} has a {numberOfTrials}");
        }

        public void DisplayLawyerParameters()
        {
            Console.WriteLine($"{name}, {yearsExperience}");
            Console.ReadLine();
        }
    }
}
