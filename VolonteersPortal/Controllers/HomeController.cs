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
        private const int immediateDays = 14;

        private const int projectsToShow = 3;
        public IProjectRepository projectRepository;

        public HomeController(IProjectRepository pRep)
        {
            projectRepository = pRep;
        }

        public ActionResult Index()
        {
            List<ProjectShortData> immediateProjects = 
                projectRepository.GetFilteredData(
                    p => 
                        p.EndDate > DateTime.Now 
                        &&
                        p.StartDate < DateTime.Now.AddDays(immediateDays)).Take(projectsToShow).ToList();
            List<ProjectShortData> recentProjects =
                projectRepository.GetFilteredData(p => p.EndDate < DateTime.Now).Take(projectsToShow).ToList();
            int completedProjectsTotal = projectRepository.GetFiltered(p => p.EndDate < DateTime.Now).Count();
            HomePageModel model = new HomePageModel
            {
                ImmediateProjects = immediateProjects,
                CompletedProjects = recentProjects,
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
