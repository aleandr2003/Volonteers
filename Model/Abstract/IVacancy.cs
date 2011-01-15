using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Abstract
{
    public interface IVacancy
    {
        int Id {get; set;}
        string Name {get; set;}
        string Description {get; set;}
        int? NeededNumber {get; set;}
        bool ApprovalRequired {get; set;}
        int ProjectId {get; set;}
        List<IPerson> AppliedPersons {get; set;}
        List<IPerson> ApprovedPersons { get; set; }
    }
}
