using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Transfers;

namespace WebApi.Controllers
{
    public class finVentaController : ApiController
    {
        //Muestra la lista de los nombres de opciones para finalizar la venta de entradas
        [HttpGet]
        [Route("api/publicar/finventa")]

        // GET: api/publicar/finventa
        public IEnumerable<opcionFinalizacionVdt> Get()
        {
            return FINVENTA.ListarOpciones();
        }

        //Muestra la lista de ID y los nombres de opciones para finalizar la venta de entradas
        [HttpGet]
        [Route("api/publicar/finventa2")]

        // GET: api/publicar/finventa2
        public IEnumerable<opcionFinalizacionVdt2> Get2()
        {
            return FINVENTA.ListarOpciones2();
        }

    }
}
