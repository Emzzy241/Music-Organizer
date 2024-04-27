using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class MyRecord
    {
        public string RecordTitle { get; set; }

        public int RecordId { get; set; }

        public List<Artist> Artists { get; set; }
        
        
        
        

        private static List<MyRecord> _myRecordInstances = new List<MyRecord>(){};


        public MyRecord(string myRecordTitle)
        {
            RecordTitle = myRecordTitle;
            _myRecordInstances.Add(this);
        // The reason for this is to ensure we dont get the error telling us: Object reference not set to an instance of an object.
        // We are also setting the value for Artists to an empty list so it wont think its null
           Artists = new List<Artist>(){};
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

        // Method to remove a single record
        public static void RemoveRecord(int recordId)
        {
            // The way I implemente dit that gave the internal server error when I created 3 records, delete the first and try viewing the 2nd and 3rd.
            // MyRecord searchRecord = MyRecord.FindRecord(recordId);
            // _myRecordInstances.Remove(searchRecord);

            // How I prevented the internal server error
             MyRecord searchRecord = MyRecord.FindRecord(recordId);
            if (searchRecord != null)
            {
                _myRecordInstances.Remove(searchRecord);
                // Update IDs after removal
                //  this loop goes through each MyRecord object in the list and updates its RecordId property to be sequential starting from 1 after the removal of a record. This ensures that the RecordId values remain consistent and sequential even after records are deleted from the list.
                for (int i = 0; i < _myRecordInstances.Count; i++)
                {
                    _myRecordInstances[i].RecordId = i + 1;
                }
            }
        }

        // This methodhelps us store Artist(Item) inside a certain Record(category)
        public void AddArtist(Artist myArtist)
        {
            Artists.Add(myArtist);
        }
        
        
    }
}