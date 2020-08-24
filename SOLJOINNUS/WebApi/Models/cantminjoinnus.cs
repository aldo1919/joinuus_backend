using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class CANTMIN
    {
        public static IEnumerable<cantmindt> Listarcantmin()
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var list = from b in db.CANTMIN
                       select new cantmindt()
                       {
                           ID_CANTMIN = b.ID_CANTMIN,
                           DESC_CANT = b.DESC_CANT

                       };
            return list;
        }
    }
}