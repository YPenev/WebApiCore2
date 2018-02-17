using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiJwt.Models.DB
{
    public class School //TODO: Inherit USER !
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        public virtual City City { get; set; }

        [Required]
        public string Location { get; set; }

        //TODO: what type is picture
        public byte[] Picture { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
