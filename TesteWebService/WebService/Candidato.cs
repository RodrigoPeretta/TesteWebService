using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteWebService.WebService
{
    public class CandidatoDireto
    {
        public string BAI { get; set; }
        public string CENTRO { get; set; }
        public string CEP { get; set; }
        public string DISTR { get; set; }
        public string END_POI { get; set; }
        public string IBGE { get; set; }
        public string LAT { get; set; }
        public string LOG { get; set; }
        public string LONG { get; set; }
        public string MUN { get; set; }
        public string NUM_FIM { get; set; }
        public string NUM_INI { get; set; }
        public string POI { get; set; }
        public string PRIO { get; set; }
        public string SCORE { get; set; }
        public string SERVICE_NAME { get; set; }
        public string SIS_COORD { get; set; }
        public string TIPO { get; set; }
        public string TITU { get; set; }
        public string UF { get; set; }
        public string ZONA { get; set; }
    }

    public class ResultadoDireto
    {
        public List<CandidatoDireto> Candidatos { get; set; }
        public string errorMessage { get; set; }
        public string status { get; set; }
    }

    public class CandidatoReverso
    {
        /*
        public string BAI { get; set; }
        public long CENTRO { get; set; }
        public string CEP { get; set; }
        public string DISTR { get; set; }
        public string END_POI { get; set; }
        public string IBGE { get; set; }
        public double LAT { get; set; }
        public string LOG { get; set; }
        public double LONG { get; set; }
        public string MUN { get; set; }
        public string NUM_FIM { get; set; }
        public string NUM_INI { get; set; }
        public string POI { get; set; }
        public int PRIO { get; set; }
        public int SCORE { get; set; }
        public string SERVICE_NAME { get; set; }
        public string SIS_COORD { get; set; }
        public string TIPO { get; set; }
        public string TITU { get; set; }
        public string UF { get; set; }
        public string ZONA { get; set; }
         * */
    }

    public class ResultadoReverso
    {
        public List<CandidatoReverso> Candidatos { get; set; }
        public string errorMessage { get; set; }
        public string status { get; set; }
    }
}
