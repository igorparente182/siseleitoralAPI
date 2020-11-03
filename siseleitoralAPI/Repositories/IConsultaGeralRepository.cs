using siseleitoralAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siseleitoralAPI.Repositories
{
    public interface IConsultaGeralRepository
    {
        public List<ConsultaGeral> GetConsultaGerals(string value);
    }
}
