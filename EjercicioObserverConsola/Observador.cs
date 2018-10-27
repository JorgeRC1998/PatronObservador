using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObserverConsola
{
    abstract class Observador
    {
        ArrayList observadores = new ArrayList();

        public void agregarObservador(ObservadorConcreto observador)
        {
            observadores.Add(observador);
        }

        public void eliminarObservador(ObservadorConcreto observador)
        {
            observadores.Remove(observador);
        }

        public void notificarObservador(string mensaje)
        {
            foreach(ObservadorConcreto item in observadores)
            {
                item.recibirMensaje(mensaje);
            }
        }
    }
}
