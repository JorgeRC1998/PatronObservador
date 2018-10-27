using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObserverConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservadorConcreto observador1 = new ObservadorConcreto("observador 1")
            ObservadorConcreto observador2 = new ObservadorConcreto("observador 2")
            ObservadorConcreto observador3 = new ObservadorConcreto("observador 3");

            SujetoConcreto objSuConcreto = new SujetoConcreto();

            objSuConcreto.agregarObservador(observador1);
            objSuConcreto.agregarObservador(observador2);
            objSuConcreto.agregarObservador(observador3);

            objSuConcreto.notificarObservador("Hola, cambié de estado");
            Console.ReadLine();

            objSuConcreto.eliminarObservador(observador2);
            ObservadorConcreto observador4 = new ObservadorConcreto("observador 4");
            objSuConcreto.agregarObservador(observador4);
            objSuConcreto.notificarObservador("Hola, cambie de estado nuevamente");
            Console.ReadLine();
        }
    }
}
