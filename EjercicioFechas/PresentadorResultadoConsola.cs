using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioFechas
{
   class PresentadorResultadoConsola: IPresentadorResultadosSrv
    {
       public void ImprimirResultados(List<Evento> _lstEventos)
        {
            foreach (Evento evento in _lstEventos)
            {
                Console.WriteLine(evento.cEvento);
            }
        }
    }
}
