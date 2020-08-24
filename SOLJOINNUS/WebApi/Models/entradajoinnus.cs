using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class ENTRADA
    {
        public static entradadt ObtenerEntrada(int id)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            var obj = db.ENTRADA.Select(b =>
                            new entradadt()
                            {
                                ID_ENT = b.ID_ENT,
                                EN_NOMBRE = b.EN_NOMBRE,
                                EN_CANT = b.EN_CANT,
                                EN_PRECIO = b.EN_PRECIO,
                                EN_DESC = b.EN_DESC,
                                EN_ACTIVADO = b.EN_ACTIVADO,
                                ID_EVEN = b.ID_EVEN,
                                ID_CANTMIN = b.ID_CANTMIN,
                                ID_CANTMAX = b.ID_CANTMAX,
                                ID_CANTXUSU = b.ID_CANTXUSU,
                                ID_FINVENTA = b.ID_FINVENTA,
                            }).SingleOrDefault(b => b.ID_ENT == id);
            if (obj == null) obj = new entradadt() { ID_ENT = 0, EN_NOMBRE = "" };
            return obj;
        }

        public static entradadt AgregarEntrada(entradadt entradadt)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            ENTRADA ENTRADA = new ENTRADA()
            {
                ID_ENT = entradadt.ID_ENT,
                EN_NOMBRE = entradadt.EN_NOMBRE,
                EN_CANT = entradadt.EN_CANT,
                EN_PRECIO = entradadt.EN_PRECIO,
                EN_DESC = entradadt.EN_DESC,

                EN_ACTIVADO = entradadt.EN_ACTIVADO,
                ID_EVEN = entradadt.ID_EVEN,
                ID_CANTMIN = entradadt.ID_CANTMIN,
                ID_CANTMAX = entradadt.ID_CANTMAX,
                ID_CANTXUSU = entradadt.ID_CANTXUSU,
                ID_FINVENTA = entradadt.ID_FINVENTA,
            };
            db.ENTRADA.Add(ENTRADA);
            db.SaveChanges();
            return ENTRADA.ObtenerEntrada(ENTRADA.ID_ENT);
        }

        public static entradadt ActualizarEntrada(int id, entradadt entradadt)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            ENTRADA ENTRADA = db.ENTRADA.Find(id);
            ENTRADA.EN_NOMBRE = entradadt.EN_NOMBRE;
            ENTRADA.EN_CANT = entradadt.EN_CANT;
            ENTRADA.EN_PRECIO = entradadt.EN_PRECIO;
            ENTRADA.EN_DESC = entradadt.EN_DESC;

            ENTRADA.EN_ACTIVADO = entradadt.EN_ACTIVADO;
            ENTRADA.ID_EVEN = entradadt.ID_EVEN;
            ENTRADA.ID_CANTMIN = entradadt.ID_CANTMIN;
            ENTRADA.ID_CANTMAX = entradadt.ID_CANTMAX;
            ENTRADA.ID_CANTXUSU = entradadt.ID_CANTXUSU;
            ENTRADA.ID_FINVENTA = entradadt.ID_FINVENTA;

            db.Entry(ENTRADA).State = EntityState.Modified;
            db.SaveChanges();
            return ENTRADA.ObtenerEntrada(ENTRADA.ID_ENT);
        }
    }
}