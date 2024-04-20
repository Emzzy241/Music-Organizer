using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class MyRecord
    {
        public string RecordTitle { get; set; }

        public int RecordId { get; }
        
        

        private static List<MyRecord> _myRecordInstances = new List<MyRecord>(){};


        public MyRecord(string myRecordTitle)
        {
            RecordTitle = myRecordTitle;
            _myRecordInstances.Add(this);
           RecordId = _myRecordInstances.Count;
        }

        // GetAllRecords() method
        public static List<MyRecord> GetAllRecords()
        {
            return _myRecordInstances;
        }

        // ClearAllRecords() method
        public static void ClearAllRecords()
        {
            _myRecordInstances.Clear();
        }

        // FindRecord() method
        public static MyRecord FindRecord(int recordId)
        {
            return _myRecordInstances[recordId-1];
        }
        
        
    }
}