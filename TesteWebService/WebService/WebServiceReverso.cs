using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Net;

namespace TesteWebService.WebService
{
    public class WebServiceReverso
    {
        private string URL;

        public WebServiceReverso(string url)
        {
            URL = url + "?";
        }

        public string GetResult(DataTableReader row, string saida)
        {
            var parametros = GetEntrada(row, saida);
            var requestUrl = URL + parametros;

            DateTime inicio = DateTime.Now;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUrl);

            using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                TimeSpan span = DateTime.Now - inicio;
                var streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);

                return streamReader.ReadToEnd();
            }
        }

        private string GetEntrada(DataTableReader row, string saida)
        {
            var parametros = new List<string>
                                          {
                                              "LAT=" + row["LAT"].ToString(),
                                              "LONG=" + row["LONG"].ToString(),
                                              "ZONA=" + row["ZONA"].ToString(),
                                              "PRIO=" + row["PRIORIDADE"].ToString(),
                                              "DIST_BUSCA=" + row["DIST_BUSCA"].ToString(),
                                              "SIS_Coord=" + row["SISTEMA_COORDERNADA"].ToString(),
                                              "Zona=" + row["Zona"].ToString(),
                                              "F=" + saida
                                          };

            return string.Join("&", parametros);
        }
    }
}
