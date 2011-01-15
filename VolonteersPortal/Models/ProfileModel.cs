using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Entities;
using Models.DataClasses;

namespace VolonteersPortal.Models
{
    public class ProfileModel
    {
        public Person person;
        public IEnumerable<PersonProjectRole> ImmediateProjects;
        public IEnumerable<PersonProjectRole> CompletedProjects;
    }
}
