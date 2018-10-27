using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObserverConsola
{
    class ObservadorConcreto : IObservador
    {
        String nombre = string.Empty;

        public ObservadorConcreto( string nombre)
        {
            this.nombre = nombre;
        }

        public void recibirMensaje(string mensaje)
        { 
            Console.WriteLine(string.Format("yo {0} recibí el mensaje {1} ", nombre, mensaje));
        }
    }
}
