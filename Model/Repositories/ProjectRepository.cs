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
        public IProject GetProject(int Id)
        {
            throw new NotImplementedException();
        }
        // Отдает проект с заполненными спиками Vacancies, Images
        public IProject GetProjectDetails(int Id)
        {
            throw new NotImplementedException();
        }
        public List<PersonProjectRole> GetProjectRoleList(int PersonId)
        {
            throw new NotImplementedException();
        }
        public void UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
