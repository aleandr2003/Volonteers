using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Abstract;
using Models.Entities;
using Models.DataClasses;

namespace Models.Repositories
{
    public class ProjectRepository: Repository, IProjectRepository
    {
        #region Methods
        public Project GetProject(int Id)
        {
            return context.Projects.Where(p => p.Id == Id).FirstOrDefault();
        }
        // Отдает проект с заполненными спиками Vacancies, Images
        public Project GetProjectDetails(int Id)
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

        public void InsertProject(Project project)
        {
            context.Projects.InsertOnSubmit(project);
            context.SubmitChanges();
        }

        #endregion

    }
}
