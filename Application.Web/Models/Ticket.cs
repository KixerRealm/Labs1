using System.ComponentModel.DataAnnotations;

namespace Application.Web.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public int Price { get; set; }

        public virtual Guid? TheatreShow { get; set; }

        public virtual Guid? TicketUser { get; set; }
    }
}
