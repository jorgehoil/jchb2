using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioFechas
{
    interface ILector
    {
        List<Evento> obtenerEventos(string cRuta);
    }
}
