using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Entities;
using Models.Abstract;

namespace Models.Repositories
{
    public class PersonRepository: Repository, IPersonRepository
    {
        #region IPersonRepository Members

        public Person GetPerson(int Id)
        {
            return context.Persons.Where(p => p.Id == Id).FirstOrDefault();
        }

        public Person GetPersonDetails(int Id)
        {
            return context.Persons.Where(p => p.Id == Id).FirstOrDefault();
            //добавить заполнение Opinions.
        }

        public Person GetPerson(string Name)
        {
            return context.Persons.Where(p => p.NickName == Name).FirstOrDefault();
        }

        public Person GetPersonDetails(string Name)
        {
            return context.Persons.Where(p => p.NickName == Name).FirstOrDefault();
            //добавить заполнение Opinions.
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
        public void InsertPerson(Person person)
        {
            context.Persons.InsertOnSubmit(person);
            context.SubmitChanges();
        }

        #endregion
    }
}
