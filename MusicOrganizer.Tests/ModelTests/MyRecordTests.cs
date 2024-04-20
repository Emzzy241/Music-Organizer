using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizerTests.ModelTests
{
    [TestClass]
    public class MyRecordTests : IDisposable
    {

        public void Dispose()
        {
            MyRecord.ClearAllRecords();
        }
        // Test1. Test for Constructor
        [TestMethod]
         public void RecordConstructor_CreatesInstanceOfRecord_Record()
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

        // Test 4. Test to Get all Records
        [TestMethod]
        public void GetAllRecords_ReturnsAllRecords_List()
        {
            // Arrange
            MyRecord newRecord1 = new MyRecord("Koral Records");
            MyRecord newRecord2 = new MyRecord("Qavah Records");
            MyRecord newRecord3 = new MyRecord("Rinil Records");
            List<MyRecord> expectedListOfRecords = new List<MyRecord>(){newRecord1, newRecord2, newRecord3};

            // Act
            List<MyRecord> actualListOfRecords = MyRecord.GetAllRecords();

            // Assert
            CollectionAssert.AreEqual(expectedListOfRecords, actualListOfRecords);    
        }

        // Test 5. Test to clear All Records
        [TestMethod]
        public void ClearAllRecords_RemovesAllRecords_Void()
        {
            // Arrange
            MyRecord newRecord1 = new MyRecord("Koral Records");
            MyRecord newRecord2 = new MyRecord("Qavah Records");
            MyRecord newRecord3 = new MyRecord("Rinil Records");
            List<MyRecord> expectedListOfRecords = new List<MyRecord>(){};

            // Act
            MyRecord.ClearAllRecords();
            List<MyRecord> actualListOfRecords = MyRecord.GetAllRecords();

            // Assert
            CollectionAssert.AreEqual(expectedListOfRecords, actualListOfRecords);

        }

        // Test 6. Test to assign Id to each instance
        [TestMethod]
        public void Id_AssignIdToInstances_Int()
        {
            // Arrange
            MyRecord newRecord1 = new MyRecord("Koral Records");
            MyRecord newRecord2 = new MyRecord("Qavah Records");
            MyRecord newRecord3 = new MyRecord("Rinil Records");
            int expectedRecordId1 = 1;
            int expectedRecordId2 = 2;
            int expectedRecordId3 = 3;

            // Act
            int actualRecordId1 = newRecord1.RecordId;
            int actualRecordId2 = newRecord2.RecordId;
            int actualRecordId3 = newRecord3.RecordId;

            // Assert
            Assert.AreEqual(expectedRecordId1, actualRecordId1);
            Assert.AreEqual(expectedRecordId2, actualRecordId2);
            Assert.AreEqual(expectedRecordId3, actualRecordId3);
        }

        // Test 7. Test to Find Instance of MyRecord
        [TestMethod]
        public void FindInstance_ReturnsInstanceOfMyRecord_Object()
        {
            // Arrange
            MyRecord newRecord1 = new MyRecord("Koral Records");
            MyRecord newRecord2 = new MyRecord("Qavah Records");
            MyRecord newRecord3 = new MyRecord("Rinil Records");

            // Act
            MyRecord foundRecord = MyRecord.FindRecord(newRecord1.RecordId);

            // Assert
            Assert.AreEqual(newRecord1, foundRecord);
        }
    }
}