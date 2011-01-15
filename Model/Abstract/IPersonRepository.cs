using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Entities;

namespace Models.Abstract
{
    public interface IPersonRepository
    {
        Person GetPerson(int Id);
        //Отдает Person с заполненным списком Opinions
        Person GetPersonDetails(int Id);
        Person GetPerson(string Name);
        Person GetPersonDetails(string Name);
        void UpdatePerson(Person person);
        void InsertPerson(Person person);

    }
}
