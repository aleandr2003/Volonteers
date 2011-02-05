using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Abstract;
using Models.Entities;
using Models.DataClasses;
using System.Linq.Expressions;

namespace Models.Repositories
{
    public class ProjectRepository: Repository, IProjectRepository
    {
        #region Methods
        public Project GetProject(int Id)
        {
            return context.Projects.Where(p => p.Id == Id).FirstOrDefault();
        }

        public IEnumerable<ProjectShortData> GetFilteredData(Expression<Func<Project,bool>> predicate)
        {
            var projectVacancies = from project in context.Projects.Where(predicate)
                                   join person in context.Persons
                                   on project.OwnerPersonId equals person.Id
                                   join vacancy in context.Vacancies
                                   on project.Id equals vacancy.ProjectId into tempProject
                                   from vacancyList in tempProject.DefaultIfEmpty()
                                   join vacPerson in context.PersonVacancies
                                   on vacancyList.Id equals vacPerson.VacancyId into tempVacancies
                                   from projVacPersonList in tempVacancies.DefaultIfEmpty()
                                   group projVacPersonList by new 
                                   {
                                       project, 
                                       OwnerName = (person.FirstName + " " + person.LastName),
                                       vacancy = vacancyList.Name
                                   } into g
                                   select new { 
                                       project = g.Key.project,
                                       OwnerName = g.Key.OwnerName,
                                       vacancy = g.Key.vacancy,
                                       Count = g.Where(p => p.PersonId != default(int)).Count()
                                   };
            var projectVacancyList = from projectVacancy in projectVacancies
                                     group projectVacancy by new { projectVacancy.project, projectVacancy.OwnerName } into g
                                     select new ProjectShortData
                                     {
                                         Id = g.Key.project.Id,
                                         Name = g.Key.project.Name,
                                         StartDate = g.Key.project.StartDate,
                                         EndDate = g.Key.project.EndDate,
                                         VolonteersNumber = g.Select(v => v.Count).Sum(),
                                         AuthorId = g.Key.project.OwnerPersonId,
                                         AuthorName = g.Key.OwnerName,
                                         VacancyNames = g.Select(v => v.vacancy).ToList()
                                     };
            return projectVacancyList;
        }

        public IEnumerable<Project> GetFiltered(Expression<Func<Project, bool>> predicate)
        {
            //List<Project> proj = context.Projects.ToList();
            //proj.ForEach(p => p.EndDate = p.StartDate.AddDays(1));
            //Person person = context.Persons.Where(p => p.Id == 2).First();
            //person.FirstName = "Александр";
            //person.LastName = "Андриенко";
            //context.SubmitChanges();
            return context.Projects.Where(predicate);
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
