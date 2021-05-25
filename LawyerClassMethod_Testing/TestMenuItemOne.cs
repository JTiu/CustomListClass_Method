using CustomListClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemOne
    {
        [TestMethod]
        public void CheckingAddToStringA()
        {
            //arrange is the new list

            CustomList<string> CourthouseToAdd = new CustomList<string>();//this is the arrange: a new custom list

            CourthouseToAdd.Add("Farmington");
            CourthouseToAdd.Add("Clovis");
            CourthouseToAdd.Add("White Sands");
            CourthouseToAdd.Add("Truth or Consequences");
            CourthouseToAdd.Add("Cloudcroft");


            //act is the add method
        }
        [TestMethod]
        public void CheckingAddToStringB()
        {
            //arrange is the new list

            CustomList<string> CourthouseToAdd = new CustomList<string>();//this is the arrange: a new custom list
            CourthouseToAdd.Add("Las Cruces");
            CourthouseToAdd.Add("Las Cruces");
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
            CourthouseToAdd.Add("Truth or Consequence");
            //act is the add method
        }

        [TestMethod]
        public void TestCreateArrayWithIntegerersSymbolsIncludeInString()
        {
            //arrange is the new list

            CustomList<string> CourthouseToAdd = new CustomList<string>();//this is the arrange: a new custom list
            CourthouseToAdd.Add("XXXXXXXX");//these are the 13 'actions'
            CourthouseToAdd.Add("YYYYYY");
            CourthouseToAdd.Add("ZZZZZ");
            CourthouseToAdd.Add("A1");
            CourthouseToAdd.Add("12121");
            CourthouseToAdd.Add("&&&&&&&");
            //act is the add method
        }
        [TestMethod]
        public void Add_ShouldAddItemToList()//naming convbention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<string> listOfTowns = new CustomList<string>();//empty list

            //act in effect, going to test the function for expected result
            listOfTowns.Add("&&&&&&");

            //Assert

            Assert.AreEqual("&&&&&&", listOfTowns[0]);
        }
    }
}

