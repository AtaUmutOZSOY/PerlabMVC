using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Collaborations
{
    public class UpdateCollaborationNameRequestDto:IDto
    {
        public int Id { get; set; }
        public string NewCollaborationName { get; set; }
    }
}
