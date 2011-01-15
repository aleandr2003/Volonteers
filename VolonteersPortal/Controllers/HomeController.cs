using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Abstract;
using Models.DataClasses;
using VolonteersPortal.Models;
using Models.Entities;
using Models.Repositories;


namespace VolonteersPortal.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public IProjectRepository projectRepository;

        public HomeController(IProjectRepository pRep)
        {
            projectRepository = pRep;
        }

        public ActionResult Index()
        {
            List<ProjectShortData> immediateProjects = new List<ProjectShortData>();
            List<ProjectShortData> completedProjects = new List<ProjectShortData>();
            int completedProjectsTotal = 1;
            HomePageModel model = new HomePageModel
            {
                ImmediateProjects = immediateProjects,
                CompletedProjects = completedProjects,
                CompletedProjectsNumber = completedProjectsTotal
            };

            return View(model);
        }
        public ActionResult SuggestProject()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}
