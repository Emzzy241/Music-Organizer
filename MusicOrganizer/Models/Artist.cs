using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
    public class Artist
    {
        public string ArtistName { get; set; }

        public int ArtistId { get; }
        
        

        private static List<Artist> _artistInstances = new List<Artist>(){};

        public Artist(string myArtistName)
        {
            ArtistName = myArtistName;
            _artistInstances.Add(this);
            ArtistId = _artistInstances.Count;
        }

        public static List<Artist> GetAllArtists()
        {
            return _artistInstances;
        }

        public static void ClearAllArtists()
        {
            _artistInstances.Clear();
        }

        // Find() method
        public static Artist Find(int objId)
        {
            return _artistInstances[objId-1];
        } 
        
        
    }
}