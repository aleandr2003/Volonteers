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
        public Person GetPerson(int Id);
        //Отдает Person с заполненным списком Opinions
        public Person GetPersonDetails(int Id);
        public void UpdatePerson(Person person);
    }
}
