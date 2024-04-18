using Core.Utilities.Helpers;

namespace Core.Entity.Concretes
{
    public class User:Entity
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _email;
        private string _phone;
        private string _identityNumber;

        public User()
        {
            SellerId = 0;
            UserType = UserTypeEnum.CargoCompanyExternalUser;
        }
        public string IdentityNumber {
            get => EncryptionHelper.Decrypt(_identityNumber);
            set => _identityNumber = EncryptionHelper.Encrypt(value);
        }
        public string FirstName {
            get => EncryptionHelper.Decrypt(_firstName);
            set => _firstName = EncryptionHelper.Encrypt(value);
        }
        public string? MiddleName {
            get => EncryptionHelper.Decrypt(_middleName);
            set => _middleName = EncryptionHelper.Encrypt(value);
        }
        public string LastName {
            get => EncryptionHelper.Decrypt(_lastName);
            set => _lastName = EncryptionHelper.Encrypt(value);
        }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Email {
            get => EncryptionHelper.Decrypt(_email);
            set => _email = EncryptionHelper.Encrypt(value);
        }

        public string Phone {
            get => EncryptionHelper.Decrypt(_phone);
            set => _phone = EncryptionHelper.Encrypt(value);
        }

        public int? SellerId { get; set; }
        public int? SellerAddressId { get; set; }

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
