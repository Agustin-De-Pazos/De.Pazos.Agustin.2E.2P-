using System;
using System.Data.SqlClient;

namespace Entidades
{
    public class MateriaCursada
    {
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private int _notaFinal;
        private eAsistencia _asistencia;
        private eEstadoCursada _estado;
        private eRegularidad _regularidad;

        public MateriaCursada(string nombre, int notaPrimerParcial, int notaSegundoParcial, int notaFinal, eAsistencia asistencia, eEstadoCursada estado, eRegularidad regularidad)
                              : this(nombre, estado, eRegularidad.Regular)
        {
            _notaPrimerParcial = notaPrimerParcial;
            _notaSegundoParcial = notaSegundoParcial;
            _notaFinal = notaFinal;
            _asistencia = asistencia;
        }

        public MateriaCursada(string nombre, eEstadoCursada estado, eRegularidad regularidad)
        {
            _nombre = nombre;
            _estado = estado;
            _regularidad = regularidad;
            _asistencia = eAsistencia.Ausente;
        }
        public MateriaCursada(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int NotaPrimerParcial { get => _notaPrimerParcial; set => _notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => _notaSegundoParcial; set => _notaSegundoParcial = value; }
        public eAsistencia Asistencia { get => _asistencia; set => _asistencia = value; }
        public eEstadoCursada Estado { get => _estado; set => _estado = value; }
        public eRegularidad Regularidad { get => _regularidad; set => _regularidad = value; }
        public int NotaFinal { get => _notaFinal; set => _notaFinal = value; }

        public static eRegularidad StringRegularidad(string regularidad)
        {
            eRegularidad tipoCuatrimestre = eRegularidad.Regular;
            if (regularidad == "Libre")
            {
                tipoCuatrimestre = eRegularidad.Libre;
                tipoCuatrimestre = (eRegularidad)1;
            }
            return tipoCuatrimestre;
        }
        public static explicit operator MateriaCursada(SqlDataReader v)
        {
            MateriaCursada nuevo = null;
            if (v is not null)
            {
                nuevo = new MateriaCursada(
                v["nombreMateriaC"].ToString() ?? "",
                Convert.ToInt32(v["notaPrimerParcial"]),
                Convert.ToInt32(v["notaSegundoParcial"]),
                Convert.ToInt32(v["notaFinal"]),
                (eAsistencia)Convert.ToInt32(v["asistencia"]),
                (eEstadoCursada)Convert.ToInt32(v["estadoCursada"]),
                (eRegularidad)Convert.ToInt32(v["asistencia"]));
            }
            return nuevo;
        }
    }
}
