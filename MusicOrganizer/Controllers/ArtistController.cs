using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizerControllers
{
    public class ArtistController : Controller
    {
        
        // The path now includes the ID of the MyRecord we're adding a new artist to. Because it's in curly braces, we can grab this in our route's parameter to locate the MyRecord object and pass it into the corresponding view.
        [HttpGet("/records/{recordId}/artists/new")]
        public ActionResult New(int recordId)
        {
            MyRecord newRecord = MyRecord.FindRecord(recordId);
            return View(newRecord);
        }


        
        
        [HttpGet("/records/{recordId}/artists/{artistId}")]
        public ActionResult Show(int recordId, int artistId)
        {
            // Finding both the recordId and artistsId so they can be passed into the dicctionary.. Remember our View can only take in one thing at a time, that is why we made use of dictionary
            Artist newArtist = Artist.FindArtist(artistId);
            MyRecord newRecord = MyRecord.FindRecord(recordId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("artistKey", newArtist);
            model.Add("record", newRecord);
            return View(model);
        }  
        
        
    }
}


