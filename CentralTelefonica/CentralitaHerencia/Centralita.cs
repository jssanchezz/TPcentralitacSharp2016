using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        #region Propiedades

        public float GananciaLocal
        {
            get
            {
                return this.CalcularGanancia(eTipoLlamada.Local);
            }
        }
        public float GananciaProvincial
        {
            get
            {
                return this.CalcularGanancia(eTipoLlamada.Provincial);
            }
        }
        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(eTipoLlamada.Todas);
            }
        }
        public List<Llamada> ObtenerLlamadas
        {
            get 
            {
                return this._listaDeLlamadas;
            }
        }

        #endregion

        #region Constructores
        
        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa ;
        }

        #endregion

        #region Metodos

        private float CalcularGanancia(eTipoLlamada tipo)
        {
            float ganancia = 0;

            switch (tipo)
            {
                case eTipoLlamada.Local:
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        if (item is Local)
                            ganancia = ganancia + ((Local)item).CostoLlamada;                        
                    }
                    break;
                
                case eTipoLlamada.Provincial:
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        if(item is Provincial)
                        ganancia = ganancia + ((Provincial)item).CostoLlamada;
                    }
                    break;

                case eTipoLlamada.Todas: 
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        if(item is Local)
                            ganancia = ganancia + ((Local)item).CostoLlamada;
                        if (item is Provincial)
                            ganancia = ganancia + ((Provincial)item).CostoLlamada;
                    }
                    break;
            }

            return ganancia;
        }

        public void MostrarCentralita()
        {
            StringBuilder mySb = new StringBuilder();

            mySb.AppendLine("Razon social: " + this._razonSocial);
            mySb.AppendLine("Ganancia local: " + this.GananciaLocal);
            mySb.AppendLine("Ganancia provincial: " + this.GananciaProvincial);
            mySb.AppendLine("Ganancia total: " + this.GananciaTotal);
            mySb.AppendLine();
            mySb.AppendLine("Detalles de llamadas locales:");

            Console.WriteLine(mySb.ToString());

            foreach (Llamada item in this._listaDeLlamadas)
            {
                if(item is Local)
                    ((Local)item).MostrarLocal();
            }

            mySb.Clear();
            mySb.AppendLine("Detalles de llamadas provinciales:");
            
            foreach (Llamada item in this._listaDeLlamadas)
            {
                if(item is Provincial)
                    ((Provincial)item).MostrarProvincial();
            }
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion 
    }
}
