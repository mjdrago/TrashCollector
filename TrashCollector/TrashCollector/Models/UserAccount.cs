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
        [Display(Name = "First Name")]
        [StringLength(25)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        [StringLength(1)]
        [Column(TypeName = "varchar")]
        public string MiddleInitial { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(25)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                if (this.MiddleInitial == null)
                {
                    return string.Format("{0} {1}", this.FirstName, this.LastName);
                }
                return string.Format("{0} {1} {2}", this.FirstName, this.MiddleInitial, this.LastName);
            }
        }
        //public virtual ApplicationUser User { get; set; }
        //public string ApllicationUserId { get; set; }
    }
}