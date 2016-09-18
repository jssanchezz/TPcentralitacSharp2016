using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float _costo;

        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region Constructores

        public Local(Llamada unaLlamada, float costo)
            : base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        #endregion 

        #region Métodos

        private float CalcularCosto()
        {
            return this._costo * this.Duracion;
        }

        public void MostrarLocal()
        {
            this.MostrarLlamada();

            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine("Costo de la llamada: " + this.CostoLlamada);

            Console.WriteLine(mySb.ToString());
        }

        #endregion
    }
}
