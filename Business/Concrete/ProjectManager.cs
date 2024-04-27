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

        public IResult CreateProject(Project project)
        {
            var result = CheckExistProject(project);
            if(result.Success)
            {
                _projectDal.Add(project);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult("This project already exist");
        }

        private IResult CheckExistProject(Project project)
        {
            var result = _projectDal.Get(x => x.Title == project.Title);
            if(result is null)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
        public IResult DeleteProjectById(int id)
        {
            var result = _projectDal.Get(x=>x.Id == id);
            if (result is null)
            {
                return new ErrorResult("Project not found");
            }
            _projectDal.Delete(result);
            return new SuccessResult(Messages.SucceedDelete);
        }

        public IDataResult<List<Project>> GetAllProjects()
        {
            var result = _projectDal.GetAll();
            return new SuccessDataResult<List<Project>>(result);
        }

        public IDataResult<Project> GetProjectById(int id)
        {
            var result = _projectDal.Get(x => x.Id == id);
            if (result is null)
            {
                return new ErrorDataResult<Project>("Project not found");
            }
            return new SuccessDataResult<Project>(result);
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