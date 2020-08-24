using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfers
{
    public class entradadt
    {
        public int ID_ENT { get; set; }
        public string EN_NOMBRE { get; set; }
        public Nullable<int> EN_CANT { get; set; }
        public Nullable<double> EN_PRECIO { get; set; }
        public string EN_DESC { get; set; }
         public Nullable<bool> EN_ACTIVADO { get; set; }
         public int ID_EVEN { get; set; }
         public int ID_CANTMIN { get; set; }
         public int ID_CANTMAX { get; set; }
         public int ID_CANTXUSU { get; set; }
         public int ID_FINVENTA { get; set; }
    }
}