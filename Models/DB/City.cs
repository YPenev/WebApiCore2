using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiJwt.Models.DB
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(50)]
        [Required]
        public string BgName { get; set; } 

        [StringLength(50)]
        public string EnName { get; set; }

        // TODO: one to many
        public virtual ICollection<School> Schools { get; set; }
    }
}
