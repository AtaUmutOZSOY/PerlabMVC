using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.CarouselImage
{
    public class AddCarouselImageRequestDto:IDto
    {
        public string ImageString { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int ImageRank { get; set; }

    }
}
