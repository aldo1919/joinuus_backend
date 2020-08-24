using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Transfers;

namespace WebAPI.Controllers
{
    public class categoriaController : ApiController
    {
        //Muestra la lista de los nombres de las categorias
        // GET: api/publicar/categoria

        [HttpGet]
        [Route("api/publicar/categoria")]
        public IEnumerable<categoriadt> Get()
        {
            return CATEGORIA.ListarCategoria();
        }

        // POST: api/publicar/ObtenerCategoria
        [HttpGet]
        [Route("api/publicar/ObtenerCategoria")]
        public categoriadt ObtenerCategoria(int id)
        {
            return CATEGORIA.ObtenerCategoria(id);
        }


        // POST: api/publicar/registrarCategoria
        [HttpPost]
        [Route("api/publicar/registrarCategoria")]
        public categoriadt CrearCategoria(categoriadt categoriadt)
        {
            return CATEGORIA.CrearCategoria(categoriadt);
        }
    }
}
