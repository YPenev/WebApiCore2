using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiJwt.Models.DB
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Event Event { get; set; }

        [Required]
        public bool CheckedIn { get; set; }
    }
}
