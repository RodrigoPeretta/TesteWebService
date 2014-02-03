using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace TesteWebService.WebService
{
    public class WebService
    {
        private string URL;

        public WebService(string Url)
        {
            URL = Url + "?";
        }

        public string GetResult(DataTableReader row, string saida)
        {
            var parametros = GetEntrada(row,saida);
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
                                              "UF=" + row["UF"].ToString(),
                                              "MUN=" + row["CIDADE"].ToString(),
                                              "LOG=" + row["ENDERECO"].ToString(),
                                              "BAI=" + row["BAIRRO"].ToString(),
                                              "CEP=" + row["CEP"].ToString(),
                                              "POI=" + row["POI"].ToString(),
                                              "CAND=" + row["CANDIDATOS"].ToString(),
                                              "PRIO=" + row["PRIORIDADE"].ToString(),
                                              "SIS_Coord=" + row["SISTEMA_COORDENADA"].ToString(), 
                                              "F=" + saida
                                          };

            return string.Join("&", parametros);
        }
    }
}
