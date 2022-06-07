using A2Mac1.Costino.Application.Models;
using A2Mac1.Costino.Application.Services.Contracts;
using A2Mac1.Costino.DataAccess.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace A2Mac1.Costino.Api.Controllers
{
    [Route("api/project")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private ILoggerManager _logger;
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _projectService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(ProjectModel projectModel)
        {
            return Ok(await _projectService.CreateAsync(projectModel));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, ProjectModel projectModel)
        {
            return Ok(await _projectService.UpdateAsync(id, projectModel));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            return Ok(await _projectService.DeleteAsync(id));
        }
    }
}