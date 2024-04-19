using Core.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class PersonImage:Entity
    {
        public Image Image { get; set; }
        public int PersonId { get; set; }

    }
}
