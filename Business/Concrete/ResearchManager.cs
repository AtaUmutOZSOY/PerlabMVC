using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ResearchManager : IResearchService
    {
        IResearchDal _researchDal;

        public ResearchManager(IResearchDal researchDal)
        {
            _researchDal = researchDal;
        }

        public IResult Add(Research research)
        {
            var result = CheckExistingResearch(research.Title);
            if(result.Success)
            {
                _researchDal.Add(research);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult(result.Message);
        }

        private IResult CheckExistingResearch(string title)
        {
            var result = _researchDal.Get(x => x.Title == title);
            if (result is not null )
            {
                return new ErrorResult("This research already exist");
            }
            return new SuccessResult();
        }
        public IResult DeleteById(int id)
        {
            var existResearch = _researchDal.Get(x=>x.Id == id);
            if (existResearch is not null)
            {
                _researchDal.Delete(existResearch);
                return new SuccessResult(Messages.SucceedDelete);
            }
            return new ErrorResult("Research not found");
            
        }

        public IDataResult<List<Research>> GetAll()
        {
            var reuslt = _researchDal.GetAll();
            return new SuccessDataResult<List<Research>>(reuslt);
        }

        public IDataResult<Research> GetById(int id)
        {
            var result = _researchDal.Get(x=>x.Id == id);
            if (result is not null)
            {
                return new SuccessDataResult<Research>(result);
            }
            return new ErrorDataResult<Research>("Research not found");
        }

        
    }
}
