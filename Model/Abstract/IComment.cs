using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Abstract
{
    interface IComment
    {
        int Id {get; set;}
   		int TopicId {get; set;}
   		string Text {get; set;}
   		int PersonId {get; set;}
        DateTime DateCreated { get; set; }
    }
}
