using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Publications
{
    public class CreateNewPublicationRequestDto:IDto
    {
        public string Title { get; set; }
        public string JournalName { get; set; }
        public DateTime PublishedYear { get; set; }
        public string Doi { get; set; }
        public string Issn { get; set; }

    }
}
