using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioFechas
{
    class ProcesadorEvento
    {


        ILector lector;
        IOrganizadorEventos organizador;
        IPresentadorResultadosSrv presentador;

        public void ProcesaEvento(string _cRuta)
        {
            List<Evento> lstEventos = new List<Evento>();
            lector= new LectorArchivoTXT();
            lstEventos=lector.obtenerEventos(_cRuta);
            organizador = new OrganizadorEventos();
            lstEventos=organizador.OrganizarEventos(lstEventos);
            presentador = new PresentadorResultadoConsola();
            presentador.ImprimirResultados(lstEventos);


        }


    }
}
