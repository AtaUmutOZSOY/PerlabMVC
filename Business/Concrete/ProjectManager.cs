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
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResult UpdateProject(Project project)
        {
            var result = _projectDal.Get(x => x.Id == project.Id);
            if (result is not null)
            {
                result.ProjectManagerFullName = project.ProjectManagerFullName;
                result.DeadLine = project.DeadLine;
                result.Title = project.Title;
                result.Description = project.Description;
                _projectDal.Update(result);
                return new SuccessResult(Messages.SucceedUpdate);
            }
            return new ErrorResult("Project not found");

        }
    }
}