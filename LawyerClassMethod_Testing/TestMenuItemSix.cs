using CustomListClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemSix
    {
        [TestMethod]
        public void MenuSix_CreateNumericArray_CountShouldBeEleven()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange

            CustomList<int> CourthouseToAdd = new CustomList<int>();
            CourthouseToAdd.Add(11);
            CourthouseToAdd.Add(12);
            CourthouseToAdd.Add(13);
            CourthouseToAdd.Add(14);
            CourthouseToAdd.Add(14);
            CourthouseToAdd.Add(15);
            CourthouseToAdd.Add(16);
            CourthouseToAdd.Add(17);
            CourthouseToAdd.Add(18);
            CourthouseToAdd.Add(19);
            CourthouseToAdd.Add(20);
            CourthouseToAdd.Add(21);
            CourthouseToAdd.Add(22);
           

            Assert.AreEqual(CourthouseToAdd.Count, 13);
        }
        [TestMethod]
        public void MenuSix_CreateNumericArray_Index()//naming convention method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange

            CustomList<int> CourthouseToAdd = new CustomList<int>();
            CourthouseToAdd.Add(11);
            CourthouseToAdd.Add(12);
            CourthouseToAdd.Add(13);
            CourthouseToAdd.Add(14);
            CourthouseToAdd.Add(14);
            CourthouseToAdd.Add(15);
            CourthouseToAdd.Add(16);
            CourthouseToAdd.Add(17);
            CourthouseToAdd.Add(18);
            CourthouseToAdd.Add(19);
            CourthouseToAdd.Add(20);
            CourthouseToAdd.Add(21);
            CourthouseToAdd.Add(22);


            Assert.AreEqual(CourthouseToAdd[1], 12);
            Assert.AreEqual(CourthouseToAdd[0], 11);
        }


    }
}
