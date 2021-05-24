using LawyerClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LawyerClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemFive
    {
        [TestMethod]
        public void MenuFive_CheckOverloadOperatorCount_ShouldBeFour()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange

            CustomList<string> anArrayForOverload = new CustomList<string>();
            anArrayForOverload.Add("a");
           
            CustomList<string> anotherArrayForOverload = new CustomList<string>();
            anotherArrayForOverload.Add("d");
            anotherArrayForOverload.Add("e");
            anotherArrayForOverload.Add("f");

            CustomList<string> combinedList = anArrayForOverload + anotherArrayForOverload;

            Assert.AreEqual(combinedList.Count, 4);
        }
        [TestMethod]
        public void MenuFive_CheckOverloadOperatorCapacity_ShouldBeTen()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange

            CustomList<string> anArrayForOverload = new CustomList<string>();
            anArrayForOverload.Add("a");

            CustomList<string> anotherArrayForOverload = new CustomList<string>();
            anotherArrayForOverload.Add("d");
            anotherArrayForOverload.Add("e");
            anotherArrayForOverload.Add("f");

            CustomList<string> combinedList = anArrayForOverload + anotherArrayForOverload;

            Assert.AreEqual(combinedList.Capacity, 10);
        }
        [TestMethod]
        public void MenuFive_CheckOverloadOperatorCapacity_ShouldBeTwenty()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange

            CustomList<string> anArrayForOverload = new CustomList<string>();
            anArrayForOverload.Add("a");

            CustomList<string> anotherArrayForOverload = new CustomList<string>();
            anotherArrayForOverload.Add("d");
            anotherArrayForOverload.Add("e");
            anotherArrayForOverload.Add("f");
            anotherArrayForOverload.Add("d");
            anotherArrayForOverload.Add("e");
            anotherArrayForOverload.Add("f");
            anotherArrayForOverload.Add("d");
            anotherArrayForOverload.Add("e");
            anotherArrayForOverload.Add("f");
            anotherArrayForOverload.Add("d");
            anotherArrayForOverload.Add("e");
            anotherArrayForOverload.Add("f");

            CustomList<string> combinedList = anArrayForOverload + anotherArrayForOverload;

            Assert.AreEqual(combinedList.Capacity, 20);
        }

    }
}
