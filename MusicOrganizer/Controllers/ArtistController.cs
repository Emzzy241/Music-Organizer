using Microsoft.AspNetCore.Mvc;
using System;
using MusicOrganizer.Models;

namespace MusicOrganizerControllers
{
    public class ArtistController : Controller
    {
        
        // The path now includes the ID of the Record we're adding a new artist to. Because it's in curly braces, we can grab this in our route's parameter to locate the Record object and pass it into the corresponding view.
        [HttpGet("/categories/{recordId}/artists/new")]
        public ActionResult New(int recordId)
        {
            Record myRecord = Record.Find(recordId);
            return View(myRecord);
        }


        
        
        [HttpGet("/categories/{recordId}/artists/{artistId}")]
        public ActionResult Show(int recordId, int artistId)
        {
            // Finding both the recordId and artistsId so they can be passed into the dicctionary.. Remember our View can only take in one thing at a time, that is why we made use of dictionary
            Artist artist = artist.Find(artistId);
            Record Record = Record.Find(recordId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("artist", Artist);
            model.Add("record", Record);
            return View(model);
        }      
    }
}