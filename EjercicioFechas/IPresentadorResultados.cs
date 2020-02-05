using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioFechas
{
    interface IPresentadorResultadosSrv
    {
        void ImprimirResultados(List<Evento> _lstEventos);
    }
}
