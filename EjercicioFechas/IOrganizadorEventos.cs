using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioFechas
{
    interface IOrganizadorEventos
    {
        List<Evento> OrganizarEventos(List<Evento> lstEventos);
    }   
}
