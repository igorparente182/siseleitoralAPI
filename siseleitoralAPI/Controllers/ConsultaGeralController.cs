using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using siseleitoralAPI.Services;

namespace siseleitoralAPI.Controllers
{
    [Route("api/ConsultaGeral")]
    [ApiController]
    public class ConsultaGeralController : Controller
    {
        public readonly IConsultaGeralService _consultaGeralService;


        public ConsultaGeralController(IConsultaGeralService consultaGeralService)
        {
            _consultaGeralService = consultaGeralService;
        }

        [HttpGet]
        [Route("ConsultaGerals")]
        public async Task<JsonResult> Index(string value)
        {
            return Json( await _consultaGeralService.GetConsultaGerals(value));
        }

        [HttpGet]
        [Route("ConsultasContato")]
        public async Task<JsonResult> Index(int zona, int codMun, int codLoc)
        {
            return Json(await _consultaGeralService.GetConsultasContato(zona,codMun,codLoc));
        }
    }
}
