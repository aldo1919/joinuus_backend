using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Transfers;

namespace WebApi.Models
{
    public partial class CANTMAX
    {
        //Metodo para listar los numeros de cantidades máximas aceptables por entrada
        public static IEnumerable<cantmaxdt> ListarCantidades()
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var list = from b in db.CANTMAX
                       select new cantmaxdt()
                       {
                           ID_CANTMAX = b.ID_CANTMAX,
                           DESC_CANTMAX = b.DESC_CANTMAX
                       };
            return list;
        }


    }
}