using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.DataClasses;

namespace Model.Abstract
{
    interface IOpinion
    {
        int Id {get; set;}
        int ObjectPersonId {get; set;}
        string Text {get; set;}
        int Count {get; set;}
        int AuthorId {get; set;}
        PersonShortData AuthorData {get; set;}
        
        //проверяет, чтобы юзер не плюсовал мнение повторно.
        bool IsSupported(int PersonId);

        //Добавляет 1 к счетчику
        void Support(int PersonId);
    }
}
