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
    public class EventoController : ApiController
    {
        //api/Evento/DetalleEvento?ID_EV=1
        [HttpGet]
        [Route("api/Evento/DetalleEvento")]
        public IEnumerable<eventodt> DetalleEvento(int ID_EV)
        {
            return EVENTO.DetalleEvento(ID_EV);
        }

        // Eventos de acuerdo al precio de entrada indicado 
        //api/publicarlista1/listarevento
        [HttpGet]
        [Route("api/publicarlista1/listarevento")]
        public IEnumerable<eventodt> ListarEventoP(Double precio)
        {
            return EVENTO.ListarEventoP(precio);
        }

        // Eventos de acuerdo a la categoría indicada
        //api/publicarlista2/listarevento
        [HttpGet]
        [Route("api/publicarlista2/listarevento")]
        public IEnumerable<eventodt> ListarEventoC(int cat)
        {
            return EVENTO.ListarEventoC(cat);
        }

        // Eventos de acuerdo a la fecha indicada
        //api/publicarlista3/listarevento
        [HttpGet]
        [Route("api/publicarlista3/listarevento")]
        public IEnumerable<eventodt> ListarEventoF(DateTime fecha)
        {
            return EVENTO.ListarEventoF(fecha);
        }


        [HttpPost]
        [Route("api/Evento/PublicarEvento")]
        public eventodt PublicarEvento(eventodt eve)
        {
            if (eve is null)
            {
                throw new ArgumentNullException(nameof(eve));
            }

            return EVENTO.PublicarEvento(eve);
        }
        //api/Evento/ObtenerEvento
        [HttpGet]
        [Route("api/Evento/ObtenerEvento")]
        public eventodt ObtenerEvento(int id)
        {
            return EVENTO.ObtenerEvento(id);

        }


    }
}
