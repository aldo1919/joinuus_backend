using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfers
{
    public class usuariodt
    {
        public int ID_USU { get; set; }
        public string U_NOMBRES { get; set; }
        public string U_APELLIDOS { get; set; }
        public string U_CORREO { get; set; }
        public string U_CONTRA { get; set; }
        public int ID_GEN { get; set; }
        public int ID_PAIS { get; set; }
    }
}