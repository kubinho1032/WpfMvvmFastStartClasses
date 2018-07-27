using System.Data;

namespace WarsztatWpf.Infrastructure
{
    public interface IEntity
    {
        EntityState EntityState { get; set; }
    }
}
