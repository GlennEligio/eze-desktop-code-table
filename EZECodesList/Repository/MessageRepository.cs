using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZECodesList.ADO.NETModels;

namespace GSM
{
    class MessageRepository
    {
        private ezeEntities context;
        private static MessageRepository instance = null;

        private MessageRepository()
        {
            context = new ezeEntities();
        }

        public static MessageRepository getInstance()
        {
            if (instance == null)
            {
                instance = new MessageRepository();
            }
            return instance;
        }

        public List<Message> getMessages()
        {
            List<Message> messages = context.Messages.OrderByDescending(m => m.DateReceived).ToList();
            return messages;
        }

        public List<Message> getMessagesByDate(DateTime dt)
        {
            List<Message> messages = context.Messages.Where(m => m.DateReceived.Year == dt.Year
                                                            && m.DateReceived.Month == dt.Month
                                                            && m.DateReceived.Day == dt.Day)
                                                     .OrderByDescending(m => m.DateReceived)
                                                     .ToList();
            return messages;
        }

        public List<Message> getMessagesByDateAndSender(DateTime dt, string number)
        {
            List<Message> messages = context.Messages.Where(m => m.DateReceived.Year == dt.Year
                                                            && m.DateReceived.Month == dt.Month
                                                            && m.DateReceived.Day == dt.Day
                                                            && m.Sender == number)
                                                     .OrderByDescending(m => m.DateReceived)
                                                     .ToList();
            return messages;
        }

        public void addMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public void updateIsSeenMessageById(List<int> ids)
        {
            List<Message> messagesToUpdate = context.Messages.Where(m => ids.Contains(m.Id)).ToList();

            foreach (Message m in messagesToUpdate)
            {
                m.IsSeen = true;
            }

            context.SaveChanges();
            
        }
    }
}
