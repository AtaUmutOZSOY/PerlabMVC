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
    public class EfAnnouncementDal : EfEntityRepositoryBase<Announcement, PerlabDbContext>, IAnnouncementDal
    {
        
    }
}
