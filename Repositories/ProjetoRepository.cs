using Microsoft.EntityFrameworkCore; // Adicionando esta diretiva
using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo.WebApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoContext _context;

        // Construtor para injeção de dependência do contexto
        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }

        // Método assíncrono para listar os projetos
        public async Task<List<Projeto>> ListarAsync()
        {
            return await _context.Projetos.ToListAsync();  // Usando ToListAsync()
        }
    }
}
