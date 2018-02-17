using System.ComponentModel.DataAnnotations;

namespace WebApiJwt.Models.DB
{
    public class Ticket
    {
        [Key]
        public string Id { get; set; }

        //TODO: Many to one
        public string EventId { get; set; }

        [Required]
        public virtual Event Event { get; set; }

        [Required]
        public bool CheckedIn { get; set; }
    }
}
