using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected eFranja _franjaHoraria;

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

        public Provincial(eFranja miFranja, Llamada unaLlamada)
            :base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, eFranja miFranja, float duracion, string destino)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        #endregion 

        #region Métodos

        private float CalcularCosto()
        {
            float costo = 0;
            switch ((int)this._franjaHoraria)
            {
                case 0:
                    costo = this.Duracion * 0.99f;
                    break;
                case 1:
                    costo = this.Duracion * 1.25f;
                    break;
                case 2:
                    costo = this.Duracion * 0.66f;
                    break;
            }
            return costo;
        }

        public void MostrarProvincial()
        {
            this.MostrarLlamada();

            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine("Franja horaria: " + this._franjaHoraria);
            mySb.AppendLine("Costo llamada: " + this.CostoLlamada);
           
            Console.WriteLine(mySb.ToString());
        }

        #endregion

    }
}
