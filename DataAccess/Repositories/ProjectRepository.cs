using A2Mac1.Costino.DataAccess.Contracts;
using A2Mac1.Costino.DataAccess.Data;

namespace A2Mac1.Costino.DataAccess.Repositories
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(DataContext context) : base(context) { }
    }
}
