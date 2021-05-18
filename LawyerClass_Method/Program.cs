using System;

namespace LawyerClass_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Lawyer jamesTiuLawyer = new Lawyer("James", 5, 5000, 15, 4);
            Console.WriteLine($"Facts: {jamesTiuLawyer.name} has {jamesTiuLawyer.numberOfTrials} trials and {jamesTiuLawyer.numberOfTrials} hearings");
            Console.ReadLine();

            Lawyer jessicaJimenez = new Lawyer("Jessica", 4, 1000, 14, 7);
            Console.WriteLine($"Facts : {jessicaJimenez.name} has {jessicaJimenez.numberOfTrials} trials and {jessicaJimenez.numberOfTrials} hearings");
            Console.ReadLine();

            Lawyer meghanMelendez = new Lawyer("megMel", 6, 500, 16, 5);
            PotentialJuror juror1 = new PotentialJuror(27, "Jess", "not guilty");

            Trial juryTrial = new Trial("Smith v Jones", 30, 12, "Mowrery", 20, 30);
            {


                if (jamesTiuLawyer.numberOfTrials > jessicaJimenez.numberOfTrials)
                {
                    Console.WriteLine("james wins");
                }
                else
                {
                    Console.WriteLine("jessica wins.");
                }
                Console.ReadLine();

                {
                    jessicaJimenez.DisplayLawyerParameters();
                    jamesTiuLawyer.DisplayLawyerParameters();
                    meghanMelendez.DisplayLawyerParameters();
                    meghanMelendez.CheckInOffice();
                    meghanMelendez.CareerTotalTrials();
                    meghanMelendez.CareerTotalHearings();
                    juryTrial.DisplayTrialParameters();
                    juryTrial.TotalNumberAppearances();
                    juryTrial.JurySelection();
                    juror1.ToString();
                    juror1.JurorFacts();
                    Console.ReadLine();

                }



            }


        }
    }
}
