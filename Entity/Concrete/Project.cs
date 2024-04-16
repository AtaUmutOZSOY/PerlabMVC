using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Project : Research
    {
        public Project(string title, string description) : base(title, description)
        {
        }

        public string ProjectManagerFullName { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime DeadLine { get; set; }


    }
}
