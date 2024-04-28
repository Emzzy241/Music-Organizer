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

        public static Artist FindArtist(int objId)
        {
            return _artistInstances[objId-1];
        } 

        // Method to remove a single instance of Artist from list
        public static void RemoveArtist(int objId)
        {
            Artist searchArtist = Artist.FindArtist(objId);
            _artistInstances.Remove(searchArtist);
        }
        
        
    }
}


