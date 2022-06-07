using A2Mac1.Costino.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Mac1.Costino.Application.Services.Contracts
{
    public interface IProjectService
    {
        Task<Project> CreateAsync(ProjectModel projectModel);

        Task<BaseResponseModel> DeleteAsync(Guid id);

        Task<IEnumerable<ProjectModel>> GetAllAsync();

        Task<BaseResponseModel> UpdateAsync(Guid id, ProjectModel projectModel);
    }
}
