using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiJwt.Models.DB
{
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        [Required]
        public string Description { get; set; }

        //TODO: many to one
        [Required]
        public Guid SchoolId { get; set; }
        public virtual School School { get; set; }

        //TODO: many to one
        [Required]
        public Guid TicketId { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        public string Location { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public int FromGrade { get; set; }

        [Required]
        public int ToGrade { get; set; }

        public int? FreeSeats { get; set; }
    }
}
