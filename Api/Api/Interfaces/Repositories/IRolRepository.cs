using Api.Dtos;
using Api.Models;

namespace Api.Interfaces.Repositories
{
    public interface IRolRepository
    {
        Task<Rol> CreateAsync(Rol rol);
        Task<IEnumerable<Rol>> GetAll();
    }
}
