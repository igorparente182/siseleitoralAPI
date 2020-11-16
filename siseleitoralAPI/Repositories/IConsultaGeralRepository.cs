using siseleitoralAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siseleitoralAPI.Repositories
{
    public interface IConsultaGeralRepository
    {
        public Task<List<ConsultaGeral>> GetConsultaGerals(string value);

        public Task<List<ConsultaGeral>> GetConsultasContato(int zona, int codMun, int codLoc);
    }
}
