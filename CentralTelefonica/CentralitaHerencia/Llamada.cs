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

        #region Propiedades

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

        #endregion 

        #region Constructores

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        #endregion 

        #region Métodos

        public void MostrarLlamada()
        {
            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine("Origen: " + this._nroOrigen);
            mySb.AppendLine("Destino: " + this._nroDestino);
            mySb.AppendLine("Duracion: " + this._duracion);

            Console.WriteLine(mySb.ToString());
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return string.Compare(uno._duracion.ToString(), dos._duracion.ToString());
        }

        #endregion 
    }
}
