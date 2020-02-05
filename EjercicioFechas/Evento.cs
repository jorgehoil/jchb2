using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioFechas
{
    class Evento
    {
        public string cEvento;
        public DateTime dtFechaEvento;

        public Evento(string _cEvento, DateTime _dtFechaEvento)
        {
            cEvento = _cEvento;
            dtFechaEvento = _dtFechaEvento;

        }
    }
}
