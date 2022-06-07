using A2Mac1.Costino.Application.Models;
using A2Mac1.Costino.Application.Services.Contracts;
using A2Mac1.Costino.DataAccess.Contracts;
using AutoMapper;

namespace A2Mac1.Costino.Application.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository, IMapper mapper)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<Project> CreateAsync(ProjectModel projectModel)
        {
            var project = _mapper.Map<Project>(projectModel);

            var addedProject = await _projectRepository.AddAsync(project);

            return addedProject;
        }

        public async Task<BaseResponseModel> DeleteAsync(Guid id)
        {
            var project = await _projectRepository.GetFirstAsync(project => project.Id == id);
            return new BaseResponseModel
            {
                Id = (await _projectRepository.DeleteAsync(project)).Id
            };
        }

        public async Task<IEnumerable<ProjectModel>> GetAllAsync()
        {
            var projects = await _projectRepository.GetAllAsync(tl => tl.Id != null);

            return _mapper.Map<IEnumerable<ProjectModel>>(projects);
        }

        public async Task<BaseResponseModel> UpdateAsync(Guid id, ProjectModel projectModel)
        {
            var project = await _projectRepository.GetFirstAsync(tl => tl.Id == id);

            project.Name = projectModel.Name;
            project.Description = projectModel.Description;
            project.Number = projectModel.Number;

            return new BaseResponseModel
            {
                Id = (await _projectRepository.UpdateAsync(project)).Id
            };
        }
    }
}