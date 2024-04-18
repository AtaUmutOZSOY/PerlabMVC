using Core.Utilities.Helpers;

namespace Core.Entity.Concretes
{
    public class User:Entity
    {
      

        public User()
        {
           
        }
        public string IdentityNumber {
            get ;
            set;
        }
        public string FirstName {
            get ;
            set;
        }
        public string? MiddleName {
            get;
            set ;
        }
        public string LastName {
            get ;
            set ;
        }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Email {
            get ;
            set ;
        }

        public string Phone {
            get ;
            set ;
        }

      

        public UserTypeEnum UserType { get; set; }
        public string FullName
        {
            get
            {
                var fullName = FirstName + (string.IsNullOrEmpty(MiddleName) ? " " : $" {MiddleName} ") + LastName;
                return fullName.Trim();
            }
        }
    }

    public enum UserTypeEnum
    {
        CargoCompanyExternalUser,
        CargoCompanyCarrierUser,
        SellerCompanyInternalUser,
        LastCompanyExternalUser,
        
    }
}
