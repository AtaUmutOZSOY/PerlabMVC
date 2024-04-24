using Core.Utilities.Results;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICollaborationService
    {
        IDataResult<List<Collaboration>> GetAllCollaborations();

        IResult CreateCollaboration(Collaboration collaboration);
        IResult UpdateCollaboration(Collaboration collaboration);

        IResult DeleteCollaborationById(int id);

        IDataResult<Collaboration> GetCollaborationById(int id);
    }
}
