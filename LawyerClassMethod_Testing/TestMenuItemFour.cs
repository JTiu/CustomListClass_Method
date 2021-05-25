using CustomListClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemFour
    {
        [TestMethod]
        public void Menu4_CheckCapacity_ShouldBeTen()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange
           
            CustomList<string> Array = new CustomList<string>();
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");

            Assert.AreEqual(Array.Capacity, 10);
        }
        [TestMethod]
        public void Menu4_CheckCapacity_ShouldBeTwenty()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange

            CustomList<string> Array = new CustomList<string>();
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");

            Assert.AreEqual(Array.Capacity, 20);
        }

        [TestMethod]
        public void Menu4_CheckCount_ShouldBeThree()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange

            CustomList<string> Array = new CustomList<string>();
          
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");

            Assert.AreEqual(Array.Count, 3);
        }
        [TestMethod]
        public void Menu4_CheckCount_ShouldBeFifteen()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange

            CustomList<string> Array = new CustomList<string>();
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");

            Assert.AreEqual(Array.Count, 15);
        }
    }
}
