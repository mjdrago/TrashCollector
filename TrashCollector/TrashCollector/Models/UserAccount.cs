using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [StringLength(1)]
        [Column(TypeName = "varchar")]
        public string MiddleInitial { get; set; }

        [Required]
        [StringLength(25)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        //public virtual ApplicationUser User { get; set; }
        //public string ApllicationUserId { get; set; }
    }
}