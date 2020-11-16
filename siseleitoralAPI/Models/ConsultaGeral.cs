using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace siseleitoralAPI.Models
{
    [Table("ConsultaGeral")]
    public class ConsultaGeral
    {
        public string Tipo { get; set; }

        public string Nome { get; set; }

        public string Contato { get; set; }

        public string Zonal { get; set; }

        public int Zona { get; set; }

        public int CodLoc { get; set; }

        public int CodMun { get; set; }

        public string Municipio { get; set; }

        public string Bairro { get; set; }

        public string Local { get; set; }

        public string Endereco { get; set; }

        public string CEP { get; set; }

        public long Eleitores { get; set; }

        public int Secoes_Total { get; set; }


    }
}
