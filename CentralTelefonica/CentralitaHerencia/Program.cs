using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita miCentralita = new Centralita("Telefónica");

            Local llamada1 = new Local("1", 0.30f, "Bs.As", 2.65f);
            miCentralita.ObtenerLlamadas.Add(llamada1);

            Provincial llamada2 = new Provincial("2", eFranja.Franja_1, 0.21f, "La rioja");
            miCentralita.ObtenerLlamadas.Add(llamada2);

            Local llamada3 = new Local("3", 0.45f, "Bs.As", 1.99f);
            miCentralita.ObtenerLlamadas.Add(llamada3);

            Provincial llamada4 = new Provincial(eFranja.Franja_3, llamada2);
            miCentralita.ObtenerLlamadas.Add(llamada4);
            
            miCentralita.MostrarCentralita();

            miCentralita.OrdenarLlamadas();

            miCentralita.MostrarCentralita();

            Console.ReadKey();
        }
    }
}
