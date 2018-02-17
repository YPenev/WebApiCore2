using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiJwt.Models.DB
{
    public class School //TODO: Inherit USER !
    {
        [Key]
        public string Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        //TODO: Many to one
        [Required]
        public string CityId { get; set; }
        public virtual City City { get; set; }

        [Required]
        public string Location { get; set; }

        //TODO: what type is picture
        public byte[] Picture { get; set; }

        // TODO: One to many
        public virtual ICollection<Event> Events { get; set; }
    }
}
