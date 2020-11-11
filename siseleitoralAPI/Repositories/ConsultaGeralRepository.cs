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
            return _context.ConsultaGerals.Where(c => c.Bairro.ToUpper().Contains(value.ToUpper())
            || c.CEP.ToUpper().Contains(value.ToUpper())
            || c.CodLoc.ToString().ToUpper().Contains(value.ToUpper())
            || c.Contato.ToUpper().Contains(value.ToUpper())
            || c.Eleitores.ToString().ToUpper().Contains(value.ToUpper())
            || c.Endereco.ToUpper().Contains(value.ToUpper())
            || c.Local.ToUpper().Contains(value.ToUpper())
            || c.Nome.ToUpper().Contains(value.ToUpper())
            || c.Zonal.ToUpper().Contains(value.ToUpper())
            || c.Secoes_Total.ToString().ToUpper().Contains(value.ToUpper())
            || c.Zona.ToString().ToUpper().Contains(value.ToUpper())
            ).OrderBy(c=> new { c.Local,c.Tipo,c.Nome}). ToList();
        }
    }
}
