using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class GENERO
    {
        public static IEnumerable<generodt> ListarGenero()
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var list = from b in db.GENERO
                       select new generodt()
                       {
                           ID_GEN = b.ID_GEN,
                           GENERO1 = b.GENERO1
                       };
            return list;
        }
    }
}