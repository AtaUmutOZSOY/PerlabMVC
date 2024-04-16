using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Person : User
    {
        public Person(string firstName, string? middleName, string lastName, byte[] passwordHash, byte[] passwordSalt, string email) : base(firstName, middleName, lastName, passwordHash, passwordSalt, email)
        {
        }

        public GraduateEnums GraduateTypeEnum { get; set; }
        public string GraduateSchoolName { get; set; }
        public string ResearchGateUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string OrcidUrl { get; set; }

    }
}
