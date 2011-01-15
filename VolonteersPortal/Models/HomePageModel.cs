using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.DataClasses;

namespace VolonteersPortal.Models
{
    public class HomePageModel
    {
        public IEnumerable<ProjectShortData> ImmediateProjects;
        public IEnumerable<ProjectShortData> CompletedProjects;
        public int CompletedProjectsNumber;

    }
}
