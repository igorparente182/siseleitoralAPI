using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siseleitoralAPI.Util
{
    public class GenericResult
    {
        public bool Success { get; set; }

        public string Menssage { get; set; }

        public object Data { get; set; }
    }
}
