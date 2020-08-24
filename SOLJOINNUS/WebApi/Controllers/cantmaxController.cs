using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi.Models;
using WebAPI.Transfers;

namespace WebAPI.Controllers
{


    public class cantmaxController : ApiController
    {
  
        //Muestra la lista de ID y cantidades máxima aceptable por entrada
        [HttpGet]
        [Route("api/publicar/cantmax")]

        // GET: api/publicar/cantmax
        public IEnumerable<cantmaxdt> Get()
        {
            return CANTMAX.ListarCantidades();
        }

    }
}
