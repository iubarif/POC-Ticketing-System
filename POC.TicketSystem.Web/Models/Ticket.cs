using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC.TicketSystem.Web.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Source  { get; set; }

        public string RequestorName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }

        public string AssignedTo { get; set; }

        public string Comments { get; set; }

        public List<string> Attachments { get; set; }
    }
}