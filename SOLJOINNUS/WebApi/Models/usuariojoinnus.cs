using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class TB_USUARIO
    {
        public static usuariodt ObtenerUsuario(int id)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            var obj = db.TB_USUARIO.Select(b =>
                            new usuariodt()
                            {
                                ID_USU = b.ID_USU,
                                U_NOMBRES= b.U_NOMBRES,
                                U_APELLIDOS = b.U_APELLIDOS,
                                U_CORREO = b.U_CORREO,
                                U_CONTRA = b.U_CONTRA,
                                ID_GEN = b.ID_GEN,
                                ID_PAIS = b.ID_PAIS,
                            }).SingleOrDefault(b => b.ID_USU == id);
            if (obj == null) obj = new usuariodt() { ID_USU = 0, U_NOMBRES = "" };    
            return obj;
        }

        public static usuariodt AfiliarUsuario(usuariodt usuariodt)
        {
            JOINNUSEntities1 db = new JOINNUSEntities1();
            TB_USUARIO TB_USUARIO = new TB_USUARIO()
            {
                
                ID_USU = usuariodt.ID_USU,
                U_NOMBRES = usuariodt.U_NOMBRES,
                U_APELLIDOS = usuariodt.U_APELLIDOS,
                U_CORREO = usuariodt.U_CORREO,
                U_CONTRA = usuariodt.U_CONTRA,
                ID_GEN = usuariodt.ID_GEN,
                ID_PAIS = usuariodt.ID_PAIS,
            };
            db.TB_USUARIO.Add(TB_USUARIO);
            db.SaveChanges();
            return TB_USUARIO.ObtenerUsuario(TB_USUARIO.ID_USU);
        }
    }
}