using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VolonteersPortal.Models;
using Models.Abstract;
using Models.Entities;

namespace VolonteersPortal.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Project/

        private IProjectRepository projectRepository;

        public ProjectController(IProjectRepository projectRep)
        {
            projectRepository = projectRep;
        }

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Project/Details/5

        public ActionResult Details(int id)
        {
            Project targetProject = projectRepository.GetProject(id);
            ProjectDetailsModel model = new ProjectDetailsModel
            {
                ProjectName = targetProject.Name,
                Motto = targetProject.Motto,
                Description = targetProject.Description,
                Date = targetProject.Date
            };
            return View(model);
        }

        //
        // GET: /Project/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Project/Create

        [HttpPost]
        public ActionResult Create(CreateProjectModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DateTime ProjectDate = new DateTime(model.Year, model.Month, model.Day);
                    Project newProject = new Project
                        { 
                            Name = model.ProjectName,
                            Motto = model.Motto,
                            Description = model.Description,
                            Date = ProjectDate
                        };
                    projectRepository.InsertProject(newProject);
                    return RedirectToAction("Details", new {Id = newProject.Id });
                }

                return View(model);
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Project/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Project/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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

        [HttpPost]
        public ActionResult Apply(int vacancyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quit(int vacancyId)
        {
            return View();
        }

        public ActionResult EditName(int Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditName(int Id, string newName)
        {
            return View();
        }

        public ActionResult EditMotto(int Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditMotto(int Id, string newMotto)
        {
            return View();
        }

        public ActionResult EditDescription(int Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditDescription(int Id, string newDescription)
        {
            return View();
        }

        public ActionResult AddVacancy(int Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddVacancy(int Id, FormCollection collection)
        {
            return View();
        }

        public ActionResult EditVacancy(int Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditVacancy(int Id, FormCollection collection)
        {
            return View();
        }

        public ActionResult DeleteVacancy(int Id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult DeleteVacancy(int Id, FormCollection collection)
        {
            return View();
        }

        [HttpPost]
        public ActionResult HirePerson(int vacancyId, int personId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DenyPerson(int vacancyId, int personId)
        {
            return View();
        }
    
    
    }
}
