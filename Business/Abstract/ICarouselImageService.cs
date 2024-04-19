using Core.Utilities.Results;
using Models.Concrete;
using Models.Dtos.CarouselImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarouselImageService
    {
        IResult Add(AddCarouselImageRequestDto addCarouselImageRequestDto);

        IResult DeleteById(int id);

        IResult UpdateById(UpdateCarouselImageRequestDto updateCarouselImageRequestDto);

        IDataResult<List<CarouselImage>> GetAll();

        IDataResult<CarouselImage> GetById(int id);
    }
}
