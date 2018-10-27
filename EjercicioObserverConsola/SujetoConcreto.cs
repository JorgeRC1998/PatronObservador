using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObserverConsola
{
    class SujetoConcreto: Observador
    {
        public void enviarMensaje(string mensaje)
        {
            notificarObservador(mensaje);
        }
    }
}
