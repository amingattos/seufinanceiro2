using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using connDB.Properties;


namespace ConnDB
{
    public class Cls_ConnDB_Sql
    {
        private SqlConnection ConnectionSQL()
        {
            return new SqlConnection(Settings.Default.strConexao_db_seufinanceiro);
        }

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void ClearParameters()
        {
            sqlParameterCollection.Clear();
        }

        public void AddParameters(string nameParameter, object valueParameter)
        {
            sqlParameterCollection.Add(new SqlParameter(nameParameter, valueParameter));
        }

        public object ExecCommandDB(CommandType commandType, string nameStored)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionSQL();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nameStored;
                sqlCommand.CommandTimeout = 60;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }       
        
        public DataTable ExecConsultDB(CommandType commandType, string nameStored)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionSQL();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nameStored;
                sqlCommand.CommandTimeout = 60;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
