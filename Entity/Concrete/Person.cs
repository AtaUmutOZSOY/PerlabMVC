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
      
        

        public GraduateEnums GraduateTypeEnum { get; set; }
        public string GraduateSchoolName { get; set; }
        public string ResearchGateUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string OrcidUrl { get; set; }

    }
}
