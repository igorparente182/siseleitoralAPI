using Microsoft.EntityFrameworkCore;
using siseleitoralAPI.Context;
using siseleitoralAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siseleitoralAPI.Repositories
{
    public class ConsultaGeralRepository : IConsultaGeralRepository
    {
        private readonly SiseleitoralContext _context;

        public ConsultaGeralRepository(SiseleitoralContext context)
        {
            _context = context;
        }
        public async Task<List<ConsultaGeral>> GetConsultaGerals(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return await _context.ConsultaGerals.ToListAsync();
            }
            return await _context.ConsultaGerals.ToListAsync();
        }

        public async Task<List<ConsultaGeral>> GetConsultasContato(int zona, int codMun, int codLoc)
        {
            return await _context.ConsultaGerals.Where(c => c.Zona == zona && c.CodMun == codMun && c.CodLoc==codLoc).ToListAsync();
        }

    }
}
