using Core.Utilities.Results;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IResult CreateProject(Project project);
        IResult DeleteProjectById(int id);
        IResult UpdateProject(Project project);

        IDataResult<Project> GetProjectById(int id);
        IDataResult<List<Project>> GetAllProjects();
    }
}
