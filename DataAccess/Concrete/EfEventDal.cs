using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfEventDal:EfEntityRepositoryBase<Event,PerlabDbContext>,IEventDal
    {
    }
}
