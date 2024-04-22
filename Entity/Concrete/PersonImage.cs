using Core.Entity.Concretes;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class PersonImage:Entity
    {
        public string Base64String { get; set; }
        public int PersonId { get; set; }

    }
}
