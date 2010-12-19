using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Abstract
{
    interface IPersonRepository
    {
        IPerson GetPerson(int Id);
        //Отдает Person с заполненным списком Opinions
        IPerson GetPersonDetails(int Id);
        void UpdatePerson(IPerson person);
    }
}
