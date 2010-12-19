using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.DataClasses;

namespace Model.Abstract
{
    interface IMessage
    {
        int Id {get; set;}
        int AuthorId {get; set;}
        int RecipientId {get; set;}
        string Text {get; set;}
        bool IsNew {get; set;}

        IPerson Author { get; set; }
        IPerson Recipient { get; set; }

        PersonShortData AuthorData {get; set;}
        PersonShortData RecipientData { get; set; }
    }
}
