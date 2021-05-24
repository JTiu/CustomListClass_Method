using LawyerClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LawyerClassMethod_Testing
{
    [TestClass]
    public class TestCustomList
    {
        [TestMethod]
        public void CheckingAddToString()
        {
            //arrange is the new list

            CustomList<string> CourthouseToAdd = new CustomList<string>();//this is the arrange: a new custom list
            CourthouseToAdd.Add("Las Cruces");//these are the 13 'actions'
            CourthouseToAdd.Add("Mesilla");
            CourthouseToAdd.Add("Roswell");
            CourthouseToAdd.Add("Albuquerque");
            CourthouseToAdd.Add("Santa Fe");
            CourthouseToAdd.Add("Rio Rancho");
            CourthouseToAdd.Add("Hobbs");
            CourthouseToAdd.Add("Alamogordo");
            CourthouseToAdd.Add("Farmington");
            CourthouseToAdd.Add("Clovis");
            CourthouseToAdd.Add("White Sands");
            CourthouseToAdd.Add("Truth or Consequences");
            CourthouseToAdd.Add("Cloudcroft");
            Console.WriteLine($"Start an array of thirteen New Mexico Courthouses:\n{CourthouseToAdd}");

            //act is the add method
        }
        [TestMethod]
            public void Add_ShouldAddItemToList()//naming convbention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
            { //arrange
                CustomList<string> listOfTowns = new CustomList<string>();//empty list


                //act in effect, going to test the function for expected result
                listOfTowns.Add("Roswell");

                //Assert

                Assert.AreEqual("Roswell", listOfTowns[0]);
            }

            [TestMethod]
            public void Remove_ShouldReturnTrue_IfItemExistsInList()//naming convbention 'method, underscore, expected result. as third item needed, add an extra underscore. 
            { //arrange
                CustomList<string> listOfTowns = new CustomList<string>();//empty list
                listOfTowns.Add("Roswell");
                listOfTowns.Add("Mesilla");

                //act in effect, going to test the function for expected result
                bool result = listOfTowns.Remove("Roswell");

                //Assert

                Assert.IsTrue(result);
            }
            [TestMethod]
            public void Remove_ShouldReturnFalse_IfItemDoesNotExistInList()//naming convbention 'method, underscore, expected result. as third item needed, add an extra underscore. 
            { //arrange
                CustomList<string> listOfTowns = new CustomList<string>();//empty list
                listOfTowns.Add("Roswell");
                listOfTowns.Add("Mesilla");

                //act in effect, going to test the function for expected result
                bool result = listOfTowns.Remove("Las Cruces");
                //Assert

                Assert.IsFalse(result);
            }
        }
    }

