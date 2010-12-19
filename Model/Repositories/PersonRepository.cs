using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using Model.Abstract;

namespace Model.Repositories
{
    public class PersonRepository: Repository, IPersonRepository
    {
        #region IPersonRepository Members

        IPerson IPersonRepository.GetPerson(int Id)
        {
            throw new NotImplementedException();
        }

        IPerson IPersonRepository.GetPersonDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
