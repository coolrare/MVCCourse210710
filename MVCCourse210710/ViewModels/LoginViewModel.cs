using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCourse210710.ViewModels
{
    public class LoginViewModel : IValidatableObject
    {
        [Required]
        [DisplayName("帳號")]
        public string Username { get; set; }
        [Required]
        [DisplayName("密碼")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Username == "will" && this.Password == "123")
            {
                yield return ValidationResult.Success;
            }
            else
            {
                yield return new ValidationResult("帳號或密碼錯誤", 
                    new string[] { "Username", "Password" });
            }
        }
    }
}