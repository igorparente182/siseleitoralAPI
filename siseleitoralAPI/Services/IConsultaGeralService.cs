using siseleitoralAPI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siseleitoralAPI.Services
{
    public interface IConsultaGeralService
    {
        public GenericResult GetConsultaGerals(string value);
    }
}
