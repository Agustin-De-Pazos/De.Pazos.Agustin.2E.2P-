using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Admin : Usuario
    {
        public Admin(int id, string gmail, string nombre, string apellido, int dni, string pass) : base(id, gmail, nombre, apellido, dni, pass)
        { }
        public override EPermisos Permisos
        {
            get
            {
                return EPermisos.Admin;
            }

        }
        public static explicit operator Admin(SqlDataReader v)
        {
            Admin nuevo = new Admin(
            Convert.ToInt32(v["id"]),
            v["gmail"].ToString() ?? "",
            v["nombre"].ToString() ?? "",
            v["apellido"].ToString() ?? "",
            Convert.ToInt32(v["dni"]),
            v["pass"].ToString() ?? "");

            return nuevo;
        }
    }
}