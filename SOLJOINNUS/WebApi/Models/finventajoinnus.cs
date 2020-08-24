using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class FINVENTA
    {
        //Metodo para listar los nombres de opciones para finalizar la venta de entradas
        public static IEnumerable<opcionFinalizacionVdt> ListarOpciones()
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var list = from b in db.FINVENTA
                       select new opcionFinalizacionVdt()
                       {

                           DESC_FINVENTA = b.DESC_FINVENTA
                       };
            return list;
        }

        //Metodo para listar el ID y los nombres de opciones para finalizar la venta de entradas
        public static IEnumerable<opcionFinalizacionVdt2> ListarOpciones2()
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var list = from b in db.FINVENTA
                       select new opcionFinalizacionVdt2()
                       {
                           ID_FINVENTA = b.ID_FINVENTA,
                           DESC_FINVENTA = b.DESC_FINVENTA
                       };
            return list;
        }
    

}
}