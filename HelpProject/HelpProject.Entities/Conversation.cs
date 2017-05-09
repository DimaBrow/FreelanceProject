using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpProject.Entities
{
    public class Conversation
    {
        public int IdForConversation { get; set; }

        public List<Message> Messages;

        public Conversation()
        {

        }
    }
}
