using Core.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class User : Entity
    {
        public User(string firstName, string? middleName, string lastName, byte[] passwordHash, byte[] passwordSalt, string email)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Email = email;
        }
        public User()
        {
            
        }

        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
    }
}
