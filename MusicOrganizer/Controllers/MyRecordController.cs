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

        [HttpGet("/records/{recordId}")]
        public ActionResult Show(int recordId)
        {
            MyRecord searchRecord = MyRecord.FindRecord(recordId);
            return View(searchRecord);
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
    }
}