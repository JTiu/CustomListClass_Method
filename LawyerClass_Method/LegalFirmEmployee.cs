using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerClass_Method
{
   public class LegalFirmEmployee
    {
        //law firm employee variables, called fields, as these variables on on the law firm employee class, store data about the employees
        public string firstName;
        public string lastName;
        public string email;
        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthday;
       


        //ctor
        public LegalFirmEmployee(string firstName, string lastName, string email, int numberOfHoursWorked, double hourlyRate, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.numberOfHoursWorked = numberOfHoursWorked;
            this.wage = wage;
            this.hourlyRate = hourlyRate;
            this.birthday = birthday;
        }

        //method

        public void LawFirmEmployePrintData()
        {
            Console.WriteLine($"Employee {firstName} {lastName}: {email}, worked {numberOfHoursWorked} hours at rate {hourlyRate} equalling this wage {wage}. send birthday card {birthday}");
            Console.ReadLine();
        }

        
    }
}
