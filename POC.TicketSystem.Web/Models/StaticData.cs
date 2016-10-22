using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC.TicketSystem.Web.Models
{
    public class StaticData
    {
        public string ApplicationTitle { get; set; }

        public string Admin { get; set; }

        public string UpdateDate { get; set; }

        public List<string> Source { get; set; }

        public List<KeyValuePair<string, string>> Priority { get; set; }

        public List<KeyValuePair<string, string>> Status { get; set; }

    }
}