using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.DataClasses;

namespace Model.Abstract
{
    interface IProjectRepository
    {
        IProject GetProject(int Id);
        
        // Отдает проект с заполненными спиками Vacancies, Images
        IProject GetProjectDetails(int Id);
        
        List<PersonProjectRole> GetProjectRoleList(int PersonId);
        void UpdateProject(IProject project);

    }
}
