using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace EjercicioFechas
{
    class LectorArchivoTXT:ILector
    {
        public List<Evento> obtenerEventos(string cRuta)
        {
            List<string> lstEventosCadenas;
            List<Evento> lstEventos=new List<Evento>();
            string[] cTexto = File.ReadAllLines(cRuta);
            lstEventosCadenas = cTexto.ToList();
            string[] cTemp;
           
            foreach (string a in lstEventosCadenas)
            {
                cTemp = a.Split(',');
                if(cTemp.Length==2)
                {
                    lstEventos.Add(new Evento(cTemp[0],DateTime.Parse(cTemp[1])));
                }
            }
            return lstEventos;

        }
    }
}
