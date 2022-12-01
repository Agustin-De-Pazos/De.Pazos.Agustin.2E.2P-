using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen
    {
        private int _id;
        private DateTime _fecha;
        private string _nombre;
        private string _materia;

        public Examen(DateTime fecha, string nombre, string materia)
        {
            _fecha = fecha;
            _nombre = nombre;
            _materia = materia;
        }
        public Examen(int id, DateTime fecha, string nombre, string materia)
        {
            _id = id;
            _fecha = fecha;
            _nombre = nombre;
            _materia = materia;
        }
        public int Id { get => _id; set => _id = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Materia { get => _materia; set => _materia = value; }

        public static explicit operator Examen(SqlDataReader v)
        {
            Examen nuevo = new Examen(
            Convert.ToInt32(v["id"]),
            (DateTime)v["fecha"],
            v["nombre"].ToString() ?? "",
            v["materia"].ToString() ?? "");

            return nuevo;
        }
    }
}
