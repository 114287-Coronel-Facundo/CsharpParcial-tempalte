using Api.Dtos;

namespace Api.Interfaces.Services
{
    public interface IRolService
    {
        Task<RolDto> CreateAsync(RolDto rol);
        Task<IEnumerable<RolDto>> GetAsync();
    }
}
