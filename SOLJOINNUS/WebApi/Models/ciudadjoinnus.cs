using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class CIUDAD
    {
        public static IEnumerable<ciudaddt> ListarCiudadXPais(int ID_PAIS)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            var list = from b in db.CIUDAD.Where(t => t.ID_PAIS == ID_PAIS)
                       select new ciudaddt()
                       {
                           ID_CIU = b.ID_CIU,
                           CIUDAD = b.CIUDAD1,
                       };
            return list.ToList();
        }
    }
}