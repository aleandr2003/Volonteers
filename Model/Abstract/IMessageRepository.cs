using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Abstract
{
    interface IMessageRepository
    {
   		//отдает Сообщение с заполненным полем Author
   		IMessage GetMessage(int Id);

   		//отдает Сообщения с заполненными полями Author
        List<IMessage> GetMessages(int PersonId, int skip, int take);
   		int CountMessages(int PersonId);
        int CountNewMessages(int PersonId);
   		void AddMessage(IMessage message);
    }
}
