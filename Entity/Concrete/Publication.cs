using System;
using System.Collections.Generic;

namespace Models.Concrete
{
    public class Publication : Research
    {
        public string DOI { get; set; }
        public string ISSN { get; set; }
        public string JournalName { get; set; }
        public string? Abstract { get; set; }

        public List<Author> Authors { get; set; } = new List<Author>();

        public Publication(string title, string description, string doi, string issn)
            : base(title, description)
        {
            DOI = doi;
            ISSN = issn;
        }
    }
}
