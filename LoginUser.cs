using System;
using System.ComponentModel.DataAnnotations;


namespace LogAndReg.Models
{
    public class LoginUser
    {
        public string Email {get; set;}

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}