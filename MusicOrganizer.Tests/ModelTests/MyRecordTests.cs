using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizerTests.ModelTests
{
    [TestClass]
    public class RecordsTest
    {
        // Test1. Test for Constructor
        [TestMethod]
         public void RecordConsructor_CreatesInstanceOfRecord_Record()
        {
            // Arrange
            MyRecord newRecord = new MyRecord("Lime Records");

            // Assert
            Assert.AreEqual(typeof(MyRecord), newRecord.GetType());
        }

        // Test 2. Test to Get name of Record
        [TestMethod]
        public void GetRecordTitle_ReturnsNameOfRecord_String()
        {
            // Arrange
            MyRecord newRecord = new MyRecord("Dynasty Records");
            string expectedRecordTitle = "Dynasty Records";

            // Act
            string actualRecordTitle = newRecord.RecordTitle;

            // Assert
            Assert.AreEqual(expectedRecordTitle, actualRecordTitle);

        }

        // Test 3. Test to Set name of Record
        [TestMethod]
        public void SetRecordTitle_SetsRecordTitleValue_Void()
        {
            // Arrange
            MyRecord newRecord = new MyRecord("Dynasty Records");
            string expectedRecordTitle = "Lime Records";

            // Act
            newRecord.RecordTitle = "Lime Records";

            // Assert
            Assert.AreEqual(expectedRecordTitle, newRecord.RecordTitle);
        }
    }
}