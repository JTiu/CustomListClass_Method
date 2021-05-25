using CustomListClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassMethod_Testing
{
    [TestClass]
    public class TestCustomList
    {
        [TestMethod]
        public void MenuItemOne_CheckingAddToStringA()
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

            //act is the add method
        }
        [TestMethod]
        public void MenuItemOne_CheckingAddToStringB()
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
            CourthouseToAdd.Add("Truth or Consequence");
            //act is the add method
        }

        [TestMethod]
        public void MenuItemOne_CreateArrayWithIntegersAndSymbolsIncludedInString()
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
        public void MenuItemOne_Add_ShouldAddItemToEmptyList()//naming convention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<string> listOfTowns = new CustomList<string>();//empty list
            //act in effect, going to test the function for expected result
            listOfTowns.Add("Roswell");
            //Assert
            Assert.AreEqual("Roswell", listOfTowns[0]);
        }

        [TestMethod]
        public void MenuItemOne_Remove_ShouldReturnTrue_IfItemExistsInList()//naming convbention 'method, underscore, expected result. as third item needed, add an extra underscore. 
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
        //[ExpectedException]//need to research this
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
