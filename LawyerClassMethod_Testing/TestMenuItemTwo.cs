using LawyerClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LawyerClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemTwo
    {
        [TestMethod]
        public void Menu2_Remove_ShouldReturnTrue_IfItemExistsInList()//naming convbention 'method, underscore, expected result. as third item needed, add an extra underscore. 
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
        public void Menu2_Remove_ShouldReturnFalse_IfItemDoesNotExistInList()//naming convbention 'method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange
            CustomList<string> listOfTowns = new CustomList<string>();//empty list
            listOfTowns.Add("Roswell");
            listOfTowns.Add("Mesilla");

            //act in effect, going to test the function for expected result
            bool result = listOfTowns.Remove("Las Cruces");
            //Assert

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Menu2_Remove_ItemFromShortArray_IsTrue()//naming convbention 'method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange
            CustomList<string> NM_CourthouseCollectionForRemoval = new CustomList<string>();
            NM_CourthouseCollectionForRemoval.RemoveCourthouseFromShortArray();
            NM_CourthouseCollectionForRemoval.Add("ThisCourthouse");
            NM_CourthouseCollectionForRemoval.Add("ThatCourthouse");

            bool result = NM_CourthouseCollectionForRemoval.Remove("ThisCourthouse");

            //Assert

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Menu2_Remove_ItemFromShortArray_IsFalse()//naming convention 'method, underscore, expected result. as third item needed, add an extra underscore. 
        { //arrange
            CustomList<string> NM_CourthouseCollectionForRemoval = new CustomList<string>();
            NM_CourthouseCollectionForRemoval.RemoveCourthouseFromShortArray();
            NM_CourthouseCollectionForRemoval.Add("ThisCourthouse");
            NM_CourthouseCollectionForRemoval.Add("ThatCourthouse");

            bool result = NM_CourthouseCollectionForRemoval.Remove("AnotherCourthouse");

            //Assert
            Assert.IsFalse(result);
        }
    }
}

