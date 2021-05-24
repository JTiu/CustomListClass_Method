using LawyerClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LawyerClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemFour
    {
        [TestMethod]
        public void Menu4_Remove_ShouldReturnTrue_IfItemExistsInList()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange
            CustomList<string> Array = new CustomList<string>();
            Array.Add("Las Cruces");
            Array.Add("Mesilla");
            Array.Add("Roswell");
            //Console.WriteLine($"A three item array, for capacity & count check:\n{Array}");
            //Console.WriteLine($"\nCapacity is: {Array.Capacity}, Count is: {Array.Count}");
        }

        [TestMethod]
        public void CheckIndex()//naming convbention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<string> addToIndex = new CustomList<string>();//empty list

            //act in effect, going to test the function for expected result
            addToIndex.Add("X");
            addToIndex.Add("Y");
            addToIndex.Add("Z");
            //Assert

            Assert.AreEqual("X", addToIndex[0]);
            Assert.AreEqual("Y", addToIndex[1]);
        }




    }
}
