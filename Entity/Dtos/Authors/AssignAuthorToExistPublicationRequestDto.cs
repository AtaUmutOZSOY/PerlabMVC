using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Authors
{
    public class AssignAuthorToExistPublicationRequestDto:IDto
    {
        public int AuthorId { get; set; }
        public int PublicationId { get; set; }
    }
}
