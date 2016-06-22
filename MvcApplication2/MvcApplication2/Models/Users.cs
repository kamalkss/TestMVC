using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Users_login : IValidatableObject
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RemmeberMe { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(Username))
                yield return new ValidationResult("نام کاربری نمیتواند خالی باشد", new[] { "Username" });
            if (string.IsNullOrEmpty(Password))
                yield return new ValidationResult("کلمه عبور نمیتواند خالی باشد", new[] { "Password" });


            if (Username != Password)
                yield return new ValidationResult("برای ورود نام کاربری و کلمه عبور باید یکسان باشد", new[] { "Username", "Password" });
        }
    }
}