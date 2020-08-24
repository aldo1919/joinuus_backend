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
    public class EntradaController : ApiController
    {
        //api/Entrada/ObtenerEntrada?id=
        [HttpGet]
        [Route("api/Entrada/ObtenerEntrada")]
        public entradadt ObtenerEntrada(int id)
        {
            return ENTRADA.ObtenerEntrada(id);
        }

        //api/Entrada/AgregarEntrada
        [HttpPost]
        [Route("api/Entrada/AgregarEntrada")]
        public entradadt AgregarEntrada(entradadt entradadt)
        {
            return ENTRADA.AgregarEntrada(entradadt);
        }

        //api/Entrada/ActualizarEntrada
        [HttpPut]
        [Route("api/Entrada/ActualizarEntrada")]
        public entradadt ActualizarEntrada(int id, entradadt entradadt)
        {
            return ENTRADA.ActualizarEntrada(id, entradadt);
        }
    }
}
