using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioFechas
{
    class ProcesadorTiempo:IProcesadorEventoSrv
    {
        public string ObtenerTiempo(DateTime dtFechaEvento)
        {

            DateTime dtAhora = DateTime.Now;
            string cRetorno;
            bool lOcurrira = false;
            int iHours = 0, iDias = 0, iMinutos = 0, iMeses = 0;
            int iResiduo;
            long Miliseg;
            Double min;
            TimeSpan span;
            if (dtAhora > dtFechaEvento)
            {
                span = dtAhora.Subtract(dtFechaEvento);
                lOcurrira = false;
            }
            else
            {
                span = dtFechaEvento.Subtract(dtAhora);
                lOcurrira = true;
            }
            iMinutos = (int)Math.Round(span.TotalMinutes);
            if (iMinutos >= 43200)
            {
                iResiduo = iMinutos % 43200; //Meses
                iMeses = (iMinutos - iResiduo) / 43200;
                iMinutos = 0;
            }
            if (iMinutos >= 1440)
            {
                iResiduo = iMinutos % 1440;//Dias
                iDias = (iMinutos - iResiduo) / 1440;
                iMinutos = 0;
            }
            if (iMinutos >= 60)
            {
                iResiduo = iMinutos % 60;
                iHours = (iMinutos - iResiduo);
                iMinutos = 0;
            }
            cRetorno = string.Format("{0} En ", lOcurrira ? "Ocurrirá" : "Ocurrió");
            cRetorno = cRetorno += (iMeses > 0) ? iMeses + " Mes(s)" : "";
            cRetorno = cRetorno += (iDias > 0) ? iDias + " Dia (s)" : "";
            cRetorno = cRetorno += (iHours > 0) ? iHours + " Hora(s) " : "";

            return cRetorno;

        }



    }
}
