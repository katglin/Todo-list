using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo_list.Models;

namespace Todo_list.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(Database.Notes.OrderByDescending(x=>x.CreatedAt).ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Note note)
        {
            if (ModelState.IsValid)
            {
                Database.Notes.Add(note);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(DateTime createdAt)
        {
            Note note = Database.Notes.Where(x => 
                x.CreatedAt.ToString("MM/dd/yyyy HH:mm:ss") == createdAt.ToString("MM/dd/yyyy HH:mm:ss"))
                .FirstOrDefault();
            return View(note);
        }

        [HttpPost]
        public ActionResult Edit(Note note)
        {
            if (ModelState.IsValid)
            {
                Note updatedNote = Database.Notes.Where(x =>
                    x.CreatedAt.ToString("MM/dd/yyyy HH:mm:ss") == note.CreatedAt.ToString("MM/dd/yyyy HH:mm:ss"))
                    .FirstOrDefault();
                if(updatedNote!=null)
                {
                    updatedNote.Message = note.Message;
                    updatedNote.Status = note.Status;
                }
                return RedirectToAction("Index");
            }
            return View(note.CreatedAt);
        }

        [HttpGet]
        public ActionResult Delete(DateTime createdAt)
        {
            Note note = Database.Notes.Where(x =>
                x.CreatedAt.ToString("MM/dd/yyyy HH:mm:ss") == createdAt.ToString("MM/dd/yyyy HH:mm:ss"))
                .FirstOrDefault();
            if(note!=null)
                Database.Notes.Remove(note);
            return RedirectToAction("Index");
        }
    }
}