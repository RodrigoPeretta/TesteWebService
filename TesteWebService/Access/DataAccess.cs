using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Data;

namespace TesteWebService
{
    public class DataAccess
    {
        public static string database;
        private OleDbConnection connection;

        public DataAccess()
        {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", database);
            connection = new OleDbConnection(connectionString);
        }

        private void OpenConnection()
        {
            connection.Open();
        }

        private void CloseConnection()
        {
            connection.Close();
        }

        private bool IsConnectionOpen()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                return true;
            else
                return false;
        }

        public int GetCountAllRows()
        {
            var sql = "Select count(*) from GEOCODIFICACAO";

            OleDbCommand command = new OleDbCommand(sql,connection);

            if (!IsConnectionOpen())
                OpenConnection();

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count;

            CloseConnection();
        }


        public int GetCountRowsToProcess()
        {
            var sql = @"Select count(*) from GEOCODIFICACAO where PROCESSAR = TRUE";

            OleDbCommand command = new OleDbCommand(sql, connection);

            if (!IsConnectionOpen())
                OpenConnection();

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count;

            CloseConnection();
        }

        public DataSet GetDataTableToProcess()
        {
            var sql = @"Select * from GEOCODIFICACAO where PROCESSAR = TRUE";

            OleDbCommand command = new OleDbCommand(sql, connection);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(command);

            DataSet ds = new DataSet();

            if (!IsConnectionOpen())
                OpenConnection();

            myDataAdapter.Fill(ds);

            return ds;

            CloseConnection();
        }

        public void Update(DataTableReader dataReader, string result)
        {
            //result = result.Replace("'", " ");
            //var sql = string.Format(@"Update GEOCODIFICACAO set Resultado = '{0}',Processar = false where OBJECTID = {1}", result, dataReader["OBJECTID"]);

            WebService.ResultadoDireto resultadoDireto = Newtonsoft.Json.JsonConvert.DeserializeObject<WebService.ResultadoDireto>(result);

            var sql = "";
            result = result.Replace("'", " ");

            if (!resultadoDireto.status.Contains("OK"))
            {
                sql = string.Format(@"Update GEOCODIFICACAO set Resultado = '{0}',Processar = false where OBJECTID = {1}", result, dataReader["OBJECTID"]);
            }
            else
            {
                sql = string.Format(@"Update GEOCODIFICACAO set
                                                RESULTADO = '{0}',
                                                RESULTADO_UF = '{2}',
                                                RESULTADO_MUN = '{3}',
                                                RESULTADO_DISTR = '{4}',
                                                RESULTADO_IBGE = '{5}',
                                                RESULTADO_POI = '{6}',
                                                RESULTADO_END_POI = '{7}',
                                                RESULTADO_TIPO = '{8}',
                                                RESULTADO_TITU = '{9}',
                                                RESULTADO_LOG = '{10}',
                                                RESULTADO_NUM_INI = '{11}',
                                                RESULTADO_NUM_FIM = '{12}',
                                                RESULTADO_BAI = '{13}',
                                                RESULTADO_CEP = '{14}',
                                                RESULTADO_PRIO = {15},
                                                RESULTADO_SCORE = {16},
                                                RESULTADO_SIS_COORD = '{17}',
                                                RESULTADO_LAT = '{18}',
                                                RESULTADO_LONG = '{19}',
                                                RESULTADO_ZONA = '{20}',
                                                RESULTADO_CENTRO = '{21}',
                                                RESULTADO_SERVICE_NAME = '{22}',
                                                PROCESSAR = false
                                                where OBJECTID = {1}",
                                                result.Substring(0,255),
                                                dataReader["OBJECTID"],
                                                resultadoDireto.Candidatos[0].UF,
                                                resultadoDireto.Candidatos[0].MUN,
                                                resultadoDireto.Candidatos[0].DISTR,
                                                resultadoDireto.Candidatos[0].IBGE,
                                                resultadoDireto.Candidatos[0].POI,
                                                resultadoDireto.Candidatos[0].END_POI,
                                                resultadoDireto.Candidatos[0].TIPO,
                                                resultadoDireto.Candidatos[0].TITU,
                                                resultadoDireto.Candidatos[0].LOG,
                                                resultadoDireto.Candidatos[0].NUM_INI,
                                                resultadoDireto.Candidatos[0].NUM_FIM,
                                                resultadoDireto.Candidatos[0].BAI,
                                                resultadoDireto.Candidatos[0].CEP,
                                                resultadoDireto.Candidatos[0].PRIO,
                                                resultadoDireto.Candidatos[0].SCORE,
                                                resultadoDireto.Candidatos[0].SIS_COORD,
                                                resultadoDireto.Candidatos[0].LAT,
                                                resultadoDireto.Candidatos[0].LONG,
                                                resultadoDireto.Candidatos[0].ZONA,
                                                resultadoDireto.Candidatos[0].CENTRO,
                                                resultadoDireto.Candidatos[0].SERVICE_NAME
                                    );
            }

            OleDbCommand command = new OleDbCommand(sql, connection);

            if (!IsConnectionOpen())
                OpenConnection();

            command.ExecuteNonQuery();

            CloseConnection();
        }

                public int GetCountAllRowsReverso()
        {
            var sql = "Select count(*) from GEOCODIFICACAO_REVERSA";

            OleDbCommand command = new OleDbCommand(sql,connection);

            if (!IsConnectionOpen())
                OpenConnection();

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count;

            CloseConnection();
        }


        public int GetCountRowsToProcessReverso()
        {
            var sql = @"Select count(*) from GEOCODIFICACAO_REVERSA where PROCESSAR = TRUE";

            OleDbCommand command = new OleDbCommand(sql, connection);

            if (!IsConnectionOpen())
                OpenConnection();

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count;

            CloseConnection();
        }

        public DataSet GetDataTableToProcessReverso()
        {
            var sql = @"Select * from GEOCODIFICACAO_REVERSA where PROCESSAR = TRUE";

            OleDbCommand command = new OleDbCommand(sql, connection);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(command);

            DataSet ds = new DataSet();

            if (!IsConnectionOpen())
                OpenConnection();

            myDataAdapter.Fill(ds);

            return ds;

            CloseConnection();
        }

        public void UpdateReverso(DataTableReader dataReader, string result)
        {
            var sql = string.Format(@"Update GEOCODIFICACAO_REVERSA set Resultado = '{0}',Processar = false where OBJECTID = {1}", result, dataReader["OBJECTID"]);

            OleDbCommand command = new OleDbCommand(sql, connection);

            if (!IsConnectionOpen())
                OpenConnection();

            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
