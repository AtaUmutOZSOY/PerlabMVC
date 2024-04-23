using Core.Entity.Concretes;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Person : Entity
    {
        public Person()
        {
            if (MiddleName == string.Empty)
            {
                FullName = FirstName + " " + LastName;
            }
            FullName = FirstName + " "+ MiddleName+ " " + LastName;
        }

        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public string? FullName { get; set; }
        public GraduateEnums GraduateTypeEnum { get; set; }
        public string GraduateSchoolName { get; set; }
        public string ResearchGateUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string OrcidUrl { get; set; }
        public string PersonImageBase64String { get; set; }
        public int VisualRank { get; set; }

    }
}
