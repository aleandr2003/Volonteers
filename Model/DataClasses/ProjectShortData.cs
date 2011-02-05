using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.DataClasses
{
    public class ProjectShortData
    {
        public int Id;
        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;
        public int VolonteersNumber;
        public int AuthorId;
        public string AuthorName;
        public List<string> VacancyNames;
    }
}
