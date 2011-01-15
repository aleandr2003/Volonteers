using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Abstract;
using VolonteersPortal.Models;
using Models.Entities;


namespace VolonteersPortal.Controllers
{
    public class PersonController : Controller
    {
        public IPersonRepository personRepository;

        public PersonController(IPersonRepository personRep)
        {
            personRepository = personRep;
        }
        //
        // GET: /Person/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Person/Details/5
        public ActionResult Details(string nickname)
        {
            Person person = personRepository.GetPerson(nickname);

            return View(new ProfileModel {person = person });
        }
    
        //
        // GET: /Person/Edit/5
        public ActionResult Edit(string nickname)
        {
            return View();
        }

        //
        // POST: /Person/Edit/5
        [HttpPost]
        public ActionResult Edit(string nickname, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/EditAvatar/5
        public ActionResult EditAvatar(string nickname)
        {
            return View();
        }

        //
        // POST: /Person/EditAvatar/5
        [HttpPost]
        public ActionResult EditAvatar(string nickname, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Delete/5
        public ActionResult Delete(string nickname)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5
        [HttpPost]
        public ActionResult Delete(string nickname, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
