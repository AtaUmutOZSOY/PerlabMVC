using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.PersonImage
{
    public class CreatePersonImageRequestDto:IDto
    {
        public int PersonId { get; set; }
        public string Base64String { get; set; }
    }
}
