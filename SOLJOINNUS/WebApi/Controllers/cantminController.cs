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
    public class cantminController : ApiController
    {
        [HttpGet]
        [Route("api/listar/Listarcantmin")]
        public IEnumerable<cantmindt> Listarcantmin()
        {
            return CANTMIN.Listarcantmin();
        }

    }
}
