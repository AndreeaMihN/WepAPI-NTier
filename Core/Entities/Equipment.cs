using A2Mac1.Costino.Core.Common;

namespace A2Mac1.Costino.Core.Entities
{
    public class Equipment : BaseEntity
    {
        public string Name { get; set; } = "Unknown";
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
    }
}