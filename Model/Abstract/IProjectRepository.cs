using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.DataClasses;
using Models.Entities;

namespace Models.Abstract
{
    public interface IProjectRepository
    {
        Project GetProject(int Id);
        
        // Отдает проект с заполненными спиками Vacancies, Images
        Project GetProjectDetails(int Id);
        
        List<PersonProjectRole> GetProjectRoleList(int PersonId);
        void UpdateProject(Project project);
        void InsertProject(Project project);

    }
}
