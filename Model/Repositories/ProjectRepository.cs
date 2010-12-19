using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Abstract;
using Model.Entities;
using Model.DataClasses;

namespace Model.Repositories
{
    public class ProjectRepository: Repository, IProjectRepository
    {
        #region Methods
        public IProject GetProject(int Id);
        // Отдает проект с заполненными спиками Vacancies, Images
        public IProject GetProjectDetails(int Id);
        public List<PersonProjectRole> GetProjectRoleList(int PersonId);
        public void UpdateProject(Project project);
        #endregion
    }
}
