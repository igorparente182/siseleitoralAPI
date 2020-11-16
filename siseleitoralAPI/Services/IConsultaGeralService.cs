using siseleitoralAPI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siseleitoralAPI.Services
{
    public interface IConsultaGeralService
    {
        public Task<GenericResult> GetConsultaGerals(string value);

        public Task<GenericResult> GetConsultasContato(int zona, int codMun, int codLoc);
    }
}
