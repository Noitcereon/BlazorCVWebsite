using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVWebsite.Models
{
    public class ContactFormModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        
        [Required]
        public string Subject { get; set; }

        [Required]
        [MinLength(20, ErrorMessage = "Your message is too short. Try adding some context about why you're contacting me.")]
        [StringLength(1000, ErrorMessage = "Your message is too long (max is 1000 characters)")]
        public string Message { get; set; }
    }
}
