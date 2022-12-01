using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Usuario
    {
        private int id;
        private string gmail;
        private string nombre;
        private string apellido;
        private int dni;
        private string _pass;


        public Usuario(int id, string gmail, string nombre, string apellido, int dni, string _pass)
        {
            this.id = id;
            this.gmail = gmail;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this._pass = _pass;
        }
        public int Id { get => id; set => id = value; }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }

        public string Gmail { get => gmail; set => gmail = value; }
        public abstract EPermisos Permisos { get; }

        public bool VerificarPass(string pass)
        {
            bool isOkey = false;
            if (pass == this._pass)
            {
                isOkey = true;
            }
            return isOkey;
        }
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.gmail == u2.gmail;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }



        public static bool operator +(List<Usuario> u, Usuario a)
        {
            bool ok = false;
            if (!(u == a))
            {
                u.Add(a);
                ok = true;
            }
            return ok;
        }

        public static bool operator ==(List<Usuario> u, Usuario a)
        {
            bool ok = false;
            foreach (Usuario item in u)
            {
                if (item == a)
                {
                    ok = true;
                }
            }
            return ok;
        }

        public static bool operator !=(List<Usuario> u, Usuario a)
        {
            return !(u == a);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

    }

}