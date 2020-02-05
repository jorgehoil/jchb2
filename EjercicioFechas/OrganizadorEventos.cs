using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioFechas
{
    class OrganizadorEventos:IOrganizadorEventos
    {
        public List<Evento> OrganizarEventos(List<Evento> _lstEventos)
        {
            List<Evento> lstEventos = new List<Evento>();
            IProcesadorEventoSrv srvProcesador = new ProcesadorTiempo();
            string cTempEvento = string.Empty;
            foreach (Evento evento in _lstEventos)
            {
                 cTempEvento=evento.cEvento+=(" "+srvProcesador.ObtenerTiempo(evento.dtFechaEvento));
                lstEventos.Add(new Evento(cTempEvento,evento.dtFechaEvento));
            }

            return lstEventos;

        }


    }
}
