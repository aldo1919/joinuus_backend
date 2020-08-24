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
    public class ListaPagoController : ApiController
    {
        //api/ListaPago/ListaMetodosPago
        [HttpGet]
        [Route("api/ListaPago/ListaMetodosPago")]
        public IEnumerable<metodopagodt> ListarMetodos()
        {
            return METPAGO.ListarMetodos();
        }


        }
}
