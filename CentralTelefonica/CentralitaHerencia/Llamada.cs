using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;        
        protected string _nroOrigen;
        protected string _nroDestino;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }
        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        public void MostrarLlamada()
        {
            Console.WriteLine("Duracion: " + this._duracion);
            Console.WriteLine("Origen: " + this._nroOrigen);
            Console.WriteLine("Destino: " + this._nroDestino);            
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return string.Compare(uno._duracion.ToString(), dos._duracion.ToString());
        }
    }
}
