using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizerControllers
{
    public class MyRecordController : Controller
    {

        // Using IActionResult or ActionResult is the same thing; one is an interface and one is not
        [HttpGet("/records")]
        public ActionResult Index()
        {
            List<MyRecord> listOfRecords = MyRecord.GetAllRecords();
            return View(listOfRecords);
        }
        
        [HttpGet("/records/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/records")]
        public ActionResult Create(string myRecordTitle)
        {
            MyRecord userRecord = new MyRecord(myRecordTitle);
            // The Create helps in creating an instance of MyRecord
            // The below helps in collecting all instances already created, And then I redirect my Action to Index View so it can be displayed to user
            List<MyRecord> listOfRecords = MyRecord.GetAllRecords();
            return RedirectToAction("Index");
        }

        // Thge 2nd Create for adding artists into a record
        [HttpPost("/records/{recordId}/artists")]
        public ActionResult Create(int recordId, string artistName)
        {
            // For this route I a expecting 2 things one is name of artists I am getting from user and the other is the hidden Id I passed in the forms
            Dictionary<string, object> model = new Dictionary<string, object>(){};
            MyRecord foundRecord = MyRecord.FindRecord(recordId);
            Artist newArtist = new Artist(artistName);
            foundRecord.AddArtist(newArtist);
            List<Artist> myArtistLists = foundRecord.Artists;
            model.Add("artists", myArtistLists);
            model.Add("record", foundRecord);
            return View("Show", model);
        }

        [HttpGet("/records/{recordId}")]
        public ActionResult Show(int recordId)
        {
            // MyRecord searchRecord = MyRecord.FindRecord(recordId);
            // return View(searchRecord);

            // After implementing feature of storing artists into records 

            Dictionary<string, object> model = new Dictionary<string, object>(){};
            MyRecord selectedRecord = MyRecord.FindRecord(recordId);
            List<Artist> recordArtists =   selectedRecord.Artists;
            model.Add("record", selectedRecord);          
            model.Add("artists", recordArtists);
            return View(model);          
        }

        // The Delete Feature for a single Records
        [HttpGet("/records/{recordId}/deleterecord")]
        public ActionResult DeleteRecord(int recordId)
        {
            return View();
        }

        [HttpPost("/records/{recordId}/deletemyrecord")]
        public ActionResult DeleteMyRecord(int recordId)
        {
            MyRecord.RemoveRecord(recordId);
            return RedirectToAction("Index");
        }

        // The Delete Feature for all Records
        [HttpGet("/records/delete")]
        public ActionResult Delete()
        {
            return View();
        }
        
        [HttpPost("/records/deleteall")]
        public ActionResult DeleteAll()
        {
            MyRecord.ClearAllRecords();
            return RedirectToAction("Index");
        }

        // Route for Deleting all QArtists from list
        [HttpGet("/records/{recordId}/artists/deleteartist")]
        public ActionResult DeleteArtist(int recordId)
        {
            return View(recordId);
        }

        [HttpPost("records/{recordId}/artists/deleteallartists")]
        public ActionResult DeleteAllArtist(int recordId)
        {
            MyRecord foundRecord = MyRecord.FindRecord(recordId);
            foundRecord.Artists.Clear(); // THis clears all artist under a record
            // List<Artist> listOfArtists = Artist.GetAllArtists();
            // // Artist.ClearAllArtists();
            // listOfArtists.Clear();
            return RedirectToAction("Show", new { recordId = recordId });
        }

        // [HttpGet("/records/{recordId}/artists/deleteallartists/confirm")]
        // public ActionResult ConfirmDeleteAllArtists(int recordId)
        // {
        //     MyRecord selectedRecord = MyRecord.FindRecord(recordId);
        //     return View(selectedRecord);
        // }
    }
}

