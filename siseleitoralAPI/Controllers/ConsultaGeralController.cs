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
        public JsonResult Index(string value)
        {
            return Json(_consultaGeralService.GetConsultaGerals(value));
        }
    }
}
