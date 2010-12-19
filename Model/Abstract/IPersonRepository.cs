using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;

namespace Model.Abstract
{
    interface IPersonRepository
    {
        IPerson GetPerson(int Id);
        //Отдает Person с заполненным списком Opinions
        IPerson GetPersonDetails(int Id);
        void UpdatePerson(Person person);
    }
}
