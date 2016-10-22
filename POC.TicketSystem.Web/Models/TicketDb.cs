

using System.Data.Entity;

namespace POC.TicketSystem.Web.Models
{
    public class TicketDb: DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
    }
}