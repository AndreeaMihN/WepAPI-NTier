using A2Mac1.Costino.Core.Entities;
using A2Mac1.Costino.DataAccess.Contracts;
using A2Mac1.Costino.DataAccess.Data;

namespace A2Mac1.Costino.DataAccess.Repositories
{
    public class EquipmentRepository : BaseRepository<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(DataContext context) : base(context)
        {
        }
    }
}