using System;
using System.Collections.Generic;

namespace Models.Concrete
{
    public class Publication : Research
    {
        public Publication()
        {
            
        }
        public string Doi { get; set; }
        public string Issn { get; set; }
        public string JournalName { get; set; }
        public DateTime PublishedYear { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();

        public Publication(string title, string description, string doi, string issn)
            : base(title, description)
        {
            Doi = doi;
            Issn = issn;
        }
    }
}
