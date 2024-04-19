using Core.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class CarouselImage:Entity
    {
        public string ImagePath { get; set; }
        public string ImageString { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ImageRank { get; set; }
    }
}
