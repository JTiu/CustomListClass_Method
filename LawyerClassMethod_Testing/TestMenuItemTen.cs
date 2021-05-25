using CustomListClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemTen
    {
        [TestMethod]
        public void MenuItemTen_CheckSort_Capacity()//naming convbention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<int> sortList = new CustomList<int>();
            sortList.Add(99);
            sortList.Add(33);
            sortList.Add(55);
            sortList.Add(44);
            sortList.Add(22);
            sortList.Add(11);
            sortList.Add(66);
            sortList.Add(88);
            sortList.Add(77);
            sortList.Add(61);
            sortList.Add(76);
            sortList.Add(69);
            sortList.BubbleSort();
          
            //Assert

            Assert.AreEqual(sortList.Capacity, 20);
        }
        [TestMethod]
        public void MenuItemNine_CheckSort_Count()//naming convbention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<int> sortList = new CustomList<int>();
            sortList.Add(99);
            sortList.Add(33);
            sortList.Add(55);
            sortList.Add(44);
            sortList.Add(22);
           
            sortList.BubbleSort();

            //Assert

            Assert.AreEqual(sortList.Count, 0);
        }
    }
}
