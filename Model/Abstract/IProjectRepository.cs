using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.DataClasses;
using Models.Entities;
using System.Linq.Expressions;

namespace Models.Abstract
{
    public interface IProjectRepository
    {
        Project GetProject(int Id);
        IEnumerable<ProjectShortData> GetFilteredData(Expression<Func<Project, bool>> predicate);
        IEnumerable<Project> GetFiltered(Expression<Func<Project, bool>> predicate);
        
        // Отдает проект с заполненными спиками Vacancies, Images
        Project GetProjectDetails(int Id);
        
        List<PersonProjectRole> GetProjectRoleList(int PersonId);
        void UpdateProject(Project project);
        void InsertProject(Project project);

    }
}
