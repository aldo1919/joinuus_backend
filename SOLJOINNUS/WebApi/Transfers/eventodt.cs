using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Transfers;

namespace WebApi.Transfers
{
    public class eventodt
    {
        public int ID_EV { get; set; }
        public string EV_NOMBRE { get; set; }
        public string EV_DESC { get; set; }
        public string EV_INFO { get; set; }
        public Nullable<System.DateTime> EV_FECINICIO { get; set; }
        public Nullable<System.DateTime> EV_FECFIN { get; set; }
        public byte[] EV_IMG { get; set; }
        public byte[] EV_VIDEO { get; set; }
        public byte[] EV_IMGTICKET { get; set; }
        public string EV_DIREC { get; set; }
        public string EV_REF { get; set; }
        public string EV_ENCU { get; set; }
        public int ID_CATEG { get; set; }
        public int ID_USU { get; set; }
        public int ID_CIU { get; set; }

        public categoriadt categoriadt { get; set; }
        public ciudaddt ciudaddt { get; set; }
        public entradadt entradadt { get; set; }

    }
}