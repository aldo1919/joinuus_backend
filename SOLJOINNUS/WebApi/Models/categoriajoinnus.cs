using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class CATEGORIA
    {
        //Metodo para listar los nombres de las categorias
        public static IEnumerable<categoriadt> ListarCategoria()
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();

            var list = from b in db.CATEGORIA
                       select new categoriadt()
                       {
                           ID_CAT = b.ID_CAT,
                           CAT_DESC = b.CAT_DESC
                       };
            return list;
        }

        //Metodo para obtener categoria
        public static categoriadt ObtenerCategoria(int id)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            var obj = db.CATEGORIA.Select(b =>
                            new categoriadt()
                            {
                                ID_CAT = b.ID_CAT,
                                CAT_DESC = b.CAT_DESC,

                            }).SingleOrDefault(b => b.ID_CAT == id);
            if (obj == null) obj = new categoriadt() { ID_CAT = 0, CAT_DESC = "" };
            return obj;
        }
        public static categoriadt CrearCategoria(categoriadt categoriadt)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            CATEGORIA categorianew = new CATEGORIA()
            {
                ID_CAT = categoriadt.ID_CAT,
                CAT_DESC = categoriadt.CAT_DESC,
            };
            //Se agrega a la Tabla CATEGORIA

            db.CATEGORIA.Add(categorianew);
            db.SaveChanges();

            return CATEGORIA.ObtenerCategoria(categoriadt.ID_CAT);
        }
    }
}