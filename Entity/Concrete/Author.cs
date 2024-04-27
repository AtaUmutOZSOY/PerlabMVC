using Core.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Author:Entity
    {
        public Author(string firstName, string lastName, string affiliation)
        {
            FirstName = firstName;
            LastName = lastName;
            Affiliation = affiliation;
        }
        public Author()
        {
            
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Affiliation { get; set; }

        public List<Publication> Publications { get; set; }
    }
}
