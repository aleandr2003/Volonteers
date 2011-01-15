using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Entities;

namespace Models.Abstract
{
    interface IMessageRepository
    {
   		//отдает Сообщение с заполненным полем Author
   		Message GetMessage(int Id);

   		//отдает Сообщения с заполненными полями Author
        List<Message> GetMessages(int PersonId, int skip, int take);
   		int CountMessages(int PersonId);
        int CountNewMessages(int PersonId);
   		void AddMessage(Message message);
    }
}
