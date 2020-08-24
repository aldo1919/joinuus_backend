using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class EVENTO
    {
        public static IEnumerable<eventodt> DetalleEvento(int ID_EV)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            var list = from b in db.EVENTO.Where(t => t.ID_EV == ID_EV)
                       select new eventodt()
                       {
                           ID_EV = b.ID_EV,
                           EV_NOMBRE = b.EV_NOMBRE,
                           EV_DESC = b.EV_DESC,
                           EV_INFO = b.EV_INFO,
                           EV_FECINICIO = b.EV_FECINICIO,
                           EV_FECFIN = b.EV_FECFIN,
                           EV_DIREC = b.EV_DIREC,
                           EV_REF = b.EV_REF,
                           EV_ENCU = b.EV_ENCU,
                           ID_CATEG = b.ID_CATEG,
                           ID_USU = b.ID_USU,
                           ID_CIU = b.ID_CIU,
                           categoriadt = new categoriadt()
                           {
                               ID_CAT = b.ID_CATEG,
                               CAT_DESC = b.CATEGORIA.CAT_DESC
                           },
                           ciudaddt = new ciudaddt()
                           {
                               ID_CIU = b.ID_CIU,
                               CIUDAD = b.CIUDAD.CIUDAD1,
                               //ID_PAIS = b.CIUDAD.ID_PAIS
                           }

                       };
            return list;
        }

        public static IEnumerable<eventodt> ListarEventoP(Double precio)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var lista = from b in db.EVENTO
                        join c in db.ENTRADA on b.ID_EV equals c.ID_EVEN
                        where c.EN_PRECIO == precio
                        select new eventodt()
                        {
                            ID_EV = b.ID_EV,
                            EV_NOMBRE = b.EV_NOMBRE,
                            EV_DESC = b.EV_DESC,
                            EV_INFO = b.EV_INFO,
                            EV_FECINICIO = b.EV_FECINICIO,
                            EV_FECFIN = b.EV_FECFIN,
                            EV_IMG = b.EV_IMG,
                            EV_VIDEO = b.EV_VIDEO,
                            EV_IMGTICKET = b.EV_IMGTICKET,
                            EV_DIREC = b.EV_DIREC,
                            EV_REF = b.EV_REF,
                            EV_ENCU = b.EV_ENCU,
                            ID_CATEG = b.ID_CATEG,
                            ID_USU = b.ID_USU,
                            ID_CIU = b.ID_CIU,
                            entradadt = new entradadt()
                            {
                                ID_ENT = c.ID_ENT,
                                EN_NOMBRE = c.EN_NOMBRE,
                                EN_PRECIO = c.EN_PRECIO
                            }

                        };
            return lista;

        }


        public static IEnumerable<eventodt> ListarEventoC(int cat)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var lista = from b in db.EVENTO.Where(t => t.ID_CATEG == cat)
                        select new eventodt()
                        {
                            ID_EV = b.ID_EV,
                            EV_NOMBRE = b.EV_NOMBRE,
                            EV_DESC = b.EV_DESC,
                            EV_INFO = b.EV_INFO,
                            EV_FECINICIO = b.EV_FECINICIO,
                            EV_FECFIN = b.EV_FECFIN,
                            EV_IMG = b.EV_IMG,
                            EV_VIDEO = b.EV_VIDEO,
                            EV_IMGTICKET = b.EV_IMGTICKET,
                            EV_DIREC = b.EV_DIREC,
                            EV_REF = b.EV_REF,
                            EV_ENCU = b.EV_ENCU,
                            ID_CATEG = b.ID_CATEG,
                            ID_USU = b.ID_USU,
                            ID_CIU = b.ID_CIU,

                            categoriadt = new categoriadt()
                            {
                                ID_CAT = b.CATEGORIA.ID_CAT,
                                CAT_DESC = b.CATEGORIA.CAT_DESC
                            }


                        };
            return lista;
        }

        public static IEnumerable<eventodt> ListarEventoF(DateTime fecha)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var lista = from b in db.EVENTO.Where(t => t.EV_FECINICIO == fecha)
                        select new eventodt()
                        {
                            ID_EV = b.ID_EV,
                            EV_NOMBRE = b.EV_NOMBRE,
                            EV_DESC = b.EV_DESC,
                            EV_INFO = b.EV_INFO,
                            EV_FECINICIO = b.EV_FECINICIO,
                            EV_FECFIN = b.EV_FECFIN,
                            EV_IMG = b.EV_IMG,
                            EV_VIDEO = b.EV_VIDEO,
                            EV_IMGTICKET = b.EV_IMGTICKET,
                            EV_DIREC = b.EV_DIREC,
                            EV_REF = b.EV_REF,
                            EV_ENCU = b.EV_ENCU,
                            ID_CATEG = b.ID_CATEG,
                            ID_USU = b.ID_USU,
                            ID_CIU = b.ID_CIU
                        };
            return lista;
        }


        public static eventodt ObtenerEvento(int id)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            var obj = db.EVENTO.Select(b =>
                            new eventodt()
                            {
                                ID_EV = b.ID_EV,
                                EV_NOMBRE = b.EV_NOMBRE,
                                EV_DESC = b.EV_DESC,
                                EV_INFO = b.EV_INFO,
                                EV_FECINICIO = b.EV_FECINICIO,
                                EV_FECFIN = b.EV_FECFIN,
                                EV_DIREC = b.EV_DIREC,
                                EV_REF = b.EV_REF,
                                EV_ENCU = b.EV_ENCU,
                                ID_CATEG = b.ID_CATEG,
                                ID_USU = b.ID_USU,
                                ID_CIU = b.ID_CIU,

                            }).SingleOrDefault(b => b.ID_EV == id);
            if (obj == null) obj = new eventodt() { ID_EV = 0, EV_NOMBRE = "" };
            return obj;
        }

        public static eventodt PublicarEvento(eventodt ev)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            EVENTO EVE = new EVENTO()
            {
                ID_EV = ev.ID_EV,
                EV_NOMBRE = ev.EV_NOMBRE,
                EV_DESC = ev.EV_DESC,
                EV_INFO = ev.EV_INFO,
                EV_FECINICIO = ev.EV_FECINICIO,
                EV_FECFIN = ev.EV_FECFIN,
                EV_DIREC = ev.EV_DIREC,
                EV_REF = ev.EV_REF,
                EV_ENCU = ev.EV_ENCU,
                ID_CATEG = ev.ID_CATEG,
                ID_USU = ev.ID_USU,
                ID_CIU = ev.ID_CIU,
            };
            db.EVENTO.Add(EVE);
            db.SaveChanges();
            return EVENTO.ObtenerEvento(EVE.ID_EV);
        }
    }
}