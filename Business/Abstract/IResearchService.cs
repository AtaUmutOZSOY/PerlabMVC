using Core.Utilities.Results;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IResearchService
    {
        IResult Add(Research research);
        IResult DeleteById(int id);

        IDataResult<Research> GetById(int id);

        IDataResult<List<Research>> GetAll();
    }
}
