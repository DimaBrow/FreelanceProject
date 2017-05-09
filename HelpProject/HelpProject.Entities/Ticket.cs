using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpProject.Entities
{
    public class Ticket
    {

        public int TicketID { get; set; }

        public User Owner { get; set; }

        public User Executor { get; set; }

        public DateTime Creation { get; set; }

        public DateTime ActualDate { get; set; }

        public decimal Price { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Categories TCategory { get; set; }

        public Status TStatus { get; set; }

        public Ticket()
        {

        }

    }

}
