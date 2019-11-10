using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app_hora_certa.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class HoraCertaController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return DateTime.Now.ToLongDateString();
        }
    }
}
