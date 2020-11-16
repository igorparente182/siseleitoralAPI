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
        public List<ConsultaGeral> GetConsultaGerals(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return _context.ConsultaGerals.ToList();
            }
            return _context.ConsultaGerals.ToList();
        }
    }
}
