using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiJwt.Models.DB
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        //TODO: Many to one
        public string EventId { get; set; }

        [Required]
        public virtual Event Event { get; set; }

        [Required]
        public bool CheckedIn { get; set; }
    }
}
