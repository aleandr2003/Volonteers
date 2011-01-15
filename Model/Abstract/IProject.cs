using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Abstract
{
    public interface IProject
    {
        int Id {get; set;}
        string Name {get; set;}

        //(Лозунг)
        string Motto {get; set;} 
        int OwnerPersonId {get; set;}
        string Descriptions {get; set;}

        List<IVacancy> Vacancies {get; set;}
        //List<IImage> Images { get; set; }
    }
}
