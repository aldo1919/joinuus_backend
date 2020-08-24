using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class METPAGO
    {
        public static IEnumerable<metodopagodt> ListarMetodos()
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var list = from b in db.METPAGO
                       select new metodopagodt()
                       {
                           ID_METPAGO = b.ID_METPAGO,
                           DESC_METPAGO = b.DESC_METPAGO
                       };
            return list;
        }
    }
}