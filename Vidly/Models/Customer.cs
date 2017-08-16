using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required] // Data annotations allow to override code first conventions.
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; } // Navigation property. 

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } // Entity framework will recognize this as a secondary key.

        [Display(Name = "Date of Birth")]
        [OverEighteenMembershipType]
        public DateTime BirthDate { get; set; }

    }
}