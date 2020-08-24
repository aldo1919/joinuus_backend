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
    public class AfiliacionUsuarioController : ApiController
    {
        //api/AfiliacionUsuario/ListarPaises
        //[HttpGet]
        //[Route("api/AfiliacionUsuario/ListarPaises")]
        //public IEnumerable<paisdt> ListarPaises()
        //{
        //    return PAIS.ListarPaises();
        //}

        [HttpGet]
        [Route("api/AfiliacionUsuario/ListarCiudades")]
        public IEnumerable<ciudaddt> ListarCiudadXPais(int ID_PAIS)
        {
            return CIUDAD.ListarCiudadXPais(ID_PAIS);
        }


        //api/AfiliacionUsuario/ObtenerUsuario
        [HttpGet]
        [Route("api/AfiliacionUsuario/ObtenerUsuario")]
        public usuariodt ObtenerUsuario(int id)
        {
            return TB_USUARIO.ObtenerUsuario(id);
        }

        //api/AfiliacionUsuario/AfiliarUsuario
        [HttpPost]
        [Route("api/AfiliacionUsuario/AfiliarUsuario")]
        public usuariodt AfiliarUsuario(usuariodt usuariodt)
        {
            return TB_USUARIO.AfiliarUsuario(usuariodt);
        }

        //api/AfiliacionUsuario/ListarGenero
        [HttpGet]
        [Route("api/AfiliacionUsuario/ListarGenero")]
        public IEnumerable<generodt> ListarGenero()
        {
            return GENERO.ListarGenero();
        }
    }
}
