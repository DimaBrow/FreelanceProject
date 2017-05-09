using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpProject.Entities
{
    public class User
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string GeneratedNick { get; set; }

        public int ID { get; set; }

        public decimal Balance { get; set; }

        public BankAccount Account { get; set; }

        public Rating URating { get; set; }

        public List<Ticket> UserTickets;

        public List<Conversation> Conversations;

        public User()
        {

        }

    }
}
