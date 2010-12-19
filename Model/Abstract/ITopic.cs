using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Abstract
{
    interface ITopic
    {
        int Id {get; set;}
        //(изначально будет использоваться только для Id проектов)
        int ObjectId {get; set;} 
        string Title {get; set;}
        string Text {get; set;}
        int AuthorId { get; set; }
        DateTime DateCreated { get; set; }
    }
}
