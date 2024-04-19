using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Concrete;
using Models.Dtos.CarouselImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarouselImageManager : ICarouselImageService
    {
        ICarouselImageDal _carouselImageDal;

        public CarouselImageManager(ICarouselImageDal carouselImageDal)
        {
            _carouselImageDal = carouselImageDal;
        }

        public IResult Add(AddCarouselImageRequestDto addCarouselImageRequestDto)
        {
            var isImageExistResult = CheckExistCarouselImage(addCarouselImageRequestDto.ImageString);

            if (isImageExistResult.Success)
            {
                var newCarouselImage = new CarouselImage()
                {
                    ImageString = addCarouselImageRequestDto.ImageString,
                    Description = addCarouselImageRequestDto.Description,
                    Title = addCarouselImageRequestDto.Title,
                    ImageRank = addCarouselImageRequestDto.ImageRank,
                    ImagePath = addCarouselImageRequestDto.ImagePath,
                };
                _carouselImageDal.Add(newCarouselImage);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult("This image already exist");
        }

        public IResult DeleteById(int id)
        {
            var existCarouselImage = _carouselImageDal.Get(x=>x.Id == id);
            if (existCarouselImage != null)
            {
                _carouselImageDal.Delete(existCarouselImage);
                return new SuccessResult(Messages.SucceedDelete);
            }
            return new ErrorResult("Carousel image not found.");
        }

        public IDataResult<List<CarouselImage>> GetAll()
        {
            var carouselImages = _carouselImageDal.GetAll();
            return new SuccessDataResult<List<CarouselImage>>(carouselImages);
        }

        public IDataResult<CarouselImage> GetById(int id)
        {
            var carouselImage = _carouselImageDal.Get(x => x.Id == id);
            if (carouselImage is not null)
            {
                return new SuccessDataResult<CarouselImage>(carouselImage);
            }
            return new ErrorDataResult<CarouselImage>();

        }

        public IResult UpdateById(UpdateCarouselImageRequestDto updateCarouselImageRequestDto)
        {
            var existCarouselImage = _carouselImageDal.Get(x=>x.Id == updateCarouselImageRequestDto.Id);
            if (existCarouselImage is not null)
            {
                existCarouselImage.Description = updateCarouselImageRequestDto.Description;
                existCarouselImage.Title = updateCarouselImageRequestDto.Title;
                existCarouselImage.ImagePath = updateCarouselImageRequestDto.ImagePath;
                existCarouselImage.ImageRank = updateCarouselImageRequestDto.ImageRank;
                existCarouselImage.ImageString = updateCarouselImageRequestDto.ImageString;
                _carouselImageDal.Update(existCarouselImage);
                return new SuccessResult(Messages.SucceedUpdate);
            }
            return new ErrorResult("Carousel image not found");

        }

        private IResult CheckExistCarouselImage(string carouselImageString)
        {
            var result = _carouselImageDal.Get(x=>x.ImageString == carouselImageString);

            if (result is null)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }


    }
}
