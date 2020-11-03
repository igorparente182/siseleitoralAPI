using Microsoft.EntityFrameworkCore;
using siseleitoralAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siseleitoralAPI.Context
{
    public class SiseleitoralContext:DbContext
    {
        public SiseleitoralContext(DbContextOptions<SiseleitoralContext> options)
            : base(options)
        {

        }

        public DbQuery<ConsultaGeral> ConsultaGerals { get; set; }
    }
}
