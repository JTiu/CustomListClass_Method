using CustomListClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemNine
    {
        [TestMethod]
        public void MenuItemNine_CheckZip_Capacity()//naming convbention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<int> aList = new CustomList<int>();
            aList.Add(1);
            aList.Add(3);
            aList.Add(5);
            aList.Add(7);
            aList.Add(9);

            CustomList<int> bList = new CustomList<int>();
            bList.Add(2);
            bList.Add(4);
            bList.Add(6);
            bList.Add(8);
            bList.Add(10);
            CustomList<int> zList = aList.ZipMethod(bList);
            //Assert

            Assert.AreEqual(zList.Capacity, 10);
        }
        [TestMethod]
        public void MenuItemNine_CheckZip_Index()//naming convbention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<int> aList = new CustomList<int>();
            aList.Add(1);
            aList.Add(3);
            aList.Add(5);
            aList.Add(7);
            aList.Add(9);

            CustomList<int> bList = new CustomList<int>();
            bList.Add(2);
            bList.Add(4);
            bList.Add(6);
            bList.Add(8);
            bList.Add(10);
            CustomList<int> zList = aList.ZipMethod(bList);
            //Assert

            Assert.AreEqual(zList[0], 1);
            Assert.AreEqual(zList[7], 8);
        }
    }
}
