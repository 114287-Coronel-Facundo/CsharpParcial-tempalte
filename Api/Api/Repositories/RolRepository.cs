using Api.Data;
using Api.Dtos;
using Api.Interfaces.Repositories;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class RolRepository : IRolRepository
    {
        private readonly ContextDb _context;

        public RolRepository(ContextDb context)
        {
            _context = context;
        }

        public async Task<Rol> CreateAsync(Rol rol)
        {
            await _context.AddAsync(rol);
            await _context.SaveChangesAsync();
            return rol;
        }

        public async Task<IEnumerable<Rol>> GetAll()
        {
            var algo = _context.Roles;

            var otroalgo = algo.ToList();
            return otroalgo;
        }
    }
}
