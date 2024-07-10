using Api.Dtos;
using Api.Interfaces.Repositories;
using Api.Interfaces.Services;
using Api.Models;
using AutoMapper;

namespace Api.Services
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;
        private readonly IMapper _mapper;

        public RolService(IRolRepository rolRepository, IMapper mapper)
        {
            _rolRepository = rolRepository;
            _mapper = mapper;

        }
        public async Task<RolDto> CreateAsync(RolDto rol)
        {
            rol.Id = new Guid();
            var toInsert = _mapper.Map<Rol>(rol);

            var result = await _rolRepository.CreateAsync(toInsert);
            return _mapper.Map<RolDto>(result);
        }

        public async Task<IEnumerable<RolDto>> GetAsync()
        {
            return _mapper.Map<IEnumerable<RolDto>>(await _rolRepository.GetAll());
        }
    }
}
