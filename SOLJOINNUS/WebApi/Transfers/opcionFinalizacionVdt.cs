using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfers
{
    //Obtiene la lista de nombre de opciones para finalizar la venta de entradas
    public class opcionFinalizacionVdt
    {
        public string DESC_FINVENTA { get; set; }
    }

    //Obtiene la lista de ID y nombre de opciones para finalizar la venta de entradas
    public class opcionFinalizacionVdt2
    {

        public int ID_FINVENTA { get; set; }
        public string DESC_FINVENTA { get; set; }
    }

}