using AutoMapper.Internal.Mappers;
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
    public class CollaborationManager : ICollaborationService
    {
        ICollaborationDal _collaborationDal;
        public CollaborationManager(ICollaborationDal collaboration)
        {
            _collaborationDal = collaboration;
        }
        public IResult CreateCollaboration(Collaboration collaboration)
        {
            var result = CheckExistCollaborationByName(collaboration.CollaborationName);
            if (result.Success)
            {
                var newCollaboration = new Collaboration()
                {
                    CollaborationName = collaboration.CollaborationName,
                    CollaborationWebSiteLink = collaboration.CollaborationWebSiteLink,
                    ImageBase64String = collaboration.ImageBase64String,
                };
                _collaborationDal.Add(newCollaboration);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult("Collaboration name already exist");
        }

        private IResult CheckExistCollaborationByName(string collaborationName)
        {
            var result = _collaborationDal.Get(x=>x.CollaborationName == collaborationName);
            if (result is not null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public IResult DeleteCollaborationById(int id)
        {
            var existCollaboration = _collaborationDal.Get(x=>x.Id == id);
            if (existCollaboration is not null) 
            {
                _collaborationDal.Delete(existCollaboration);
                return new SuccessResult(Messages.SucceedDelete);
            }
            return new ErrorResult("Collaboration not found");
        }

        public IDataResult<List<Collaboration>> GetAllCollaborations()
        {
            var result = _collaborationDal.GetAll();
            return new SuccessDataResult<List<Collaboration>>(result);
        }

        public IDataResult<Collaboration> GetCollaborationById(int id)
        {
            var result = _collaborationDal.Get(x=>x.Id ==  id);
            if (result is not null)
            {
                return new SuccessDataResult<Collaboration>(result);
            }
            return new ErrorDataResult<Collaboration>();
        }

        public IResult UpdateCollaboration(Collaboration collaboration)
        {
            var existCollaboration = GetCollaborationById(collaboration.Id);
            if (existCollaboration is not null)
            {
                existCollaboration.Data.CollaborationName = collaboration.CollaborationName;
                existCollaboration.Data.CollaborationWebSiteLink = collaboration.CollaborationWebSiteLink;
                existCollaboration.Data.ImageBase64String = collaboration.ImageBase64String;
                _collaborationDal.Update(existCollaboration.Data);
                return new SuccessResult(Messages.SucceedUpdate);
            }
            return new ErrorResult("Collaboration not found");
        }
    }
}
