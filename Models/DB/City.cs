using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiJwt.Models.DB
{
    public class City
    {
        [Key]
        public string Id { get; set; }

        [StringLength(50)]
        [Required]
        public string BgName { get; set; } 

        [StringLength(50)]
        public string EnName { get; set; }

        // TODO: one to many
        public virtual ICollection<School> Schools { get; set; }
    }
}
