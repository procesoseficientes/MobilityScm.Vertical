using System;
using System.Runtime.Serialization;
using MobilityScm.Modelo.Tipos;

namespace MobilityScm.Vertical.Entidades
{
    [Serializable()]
    public class Operacion
    {
        public ResultadoOperacionTipo Resultado { get; set; }
        public string Mensaje { get; set; }
        private object _dato;
        public string NombreRfc { get; set; }

        public object Dato
        {
            get { return _dato; }
            set
            {
                DbData = null;
                _dato = new object();
                _dato = value;
            }
        }

        public string DbData { get; set; }

        public T ObtenerDato<T>()
        {
            return (T)_dato;
        }


        public int Codigo { get; set; }
    }
}