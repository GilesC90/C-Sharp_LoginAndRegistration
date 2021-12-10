using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogAndReg.Models
{
    public class User
    {
        [Key]
        public int? UserId {get; set; }

        [Required(ErrorMessage = "Please provide a first name")]
        [MinLength(3, ErrorMessage = "Please provide a first name with at least 3 characters")]
        public string FirstName {get; set; }

        [Required(ErrorMessage = "Please provide a last name")]
        [MinLength(3, ErrorMessage = "Please provide a last name with at least 3 characters")]
        public string LastName {get; set; }

        [Required(ErrorMessage = "Please provide an email")]
        [MinLength(8, ErrorMessage = "Please provide an email with at least 8 characters")]
        public string Email {get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please provide a password")]
        [MinLength(8, ErrorMessage = "Please provide a password with at least 8 characters")]
        public string Password { get; set; }

        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get; set; }


    }
}