using Core.Entity.Interfaces;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Person
{
    public class CreatePersonRequestDto:IDto
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public GraduateEnums GraduateTypeEnum { get; set; }
        public string GraduateSchoolName { get; set; }
        public string ResearchGateUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string OrcidUrl { get; set; }
        public int VisualRank { get; set; }
    }
}
