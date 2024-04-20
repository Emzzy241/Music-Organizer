using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class MyRecord
    {
        public string RecordTitle { get; set; }

        public int RecordId { get; }

        public List<Artist> Artists { get; set; }
        
        
        
        

        private static List<MyRecord> _myRecordInstances = new List<MyRecord>(){};


        public MyRecord(string myRecordTitle)
        {
            RecordTitle = myRecordTitle;
            _myRecordInstances.Add(this);
           RecordId = _myRecordInstances.Count;
        // The reason for this is to ensure we dont get the error telling us: Object reference not set to an instance of an object.
        // We are also setting the value for Artists to an empty list so it wont think its null
           Artists = new List<Artist>(){};
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

        public static void RemoveRecord(int recordId)
        {
            MyRecord searchRecord = MyRecord.FindRecord(recordId);
            _myRecordInstances.Remove(searchRecord);
        }

        // This methodhelps us store Artist(Item) inside a certain Record(category)
        public void AddArtist(Artist myArtist)
        {
            Artists.Add(myArtist);
        }
        
        
    }
}