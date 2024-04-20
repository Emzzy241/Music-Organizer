using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class MyRecord
    {
        public string RecordTitle { get; set; }

        public MyRecord(string myRecordTitle)
        {
            RecordTitle = myRecordTitle;
        }
        
        
    }
}