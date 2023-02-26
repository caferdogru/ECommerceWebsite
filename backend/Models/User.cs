using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {

        private string _password;

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public string Password 
        { 
            get { return _password; }
            set { _password = this.hashPassword(value); }
        
        }

        public string hashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;


        }

        public bool verifyPassword(string password)
        {
            bool isPasswordTrue = BCrypt.Net.BCrypt.Verify(password, this._password, false);
            return isPasswordTrue;


        }
    }




}
