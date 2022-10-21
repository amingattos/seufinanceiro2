using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;


namespace seufinanceiro.Model
{
    internal class Cls_ConnDB_Sql
    {
        public static SqlConnection AbreBancoMaster() // Banco de dados Master
        {
            String StringConexao = @"Data Source=.\sqlExpress; Initial Catalog= master; Integrated Security= True";

            try
            {
                SqlConnection conn = new SqlConnection(StringConexao);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SqlConnection AbreBanco()
        {
            String StringConexao = @"Data Source=.\sqlExpress; Initial Catalog= db_seufinanceiro; Integrated Security= True";

            try
            {
                SqlConnection conn = new SqlConnection(StringConexao);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FechaBanco(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
            catch (Exception e)
            { throw e; }
        }

        public DataSet RetornaDataSet(String strQuery)
        {
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmdComando = new SqlCommand(strQuery, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmdComando);
                da.Fill(ds);
                return ds;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FechaBanco(conn);
            }
        }

        public SqlDataReader RetornaDataReader(String strquery)
        {
            try
            {
                SqlDataReader dr;
                SqlCommand sqlComando = new SqlCommand(strquery, AbreBanco());
                dr = sqlComando.ExecuteReader();
                return dr;
            }
            catch (SqlException e)
            {
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    //MessageBox.Show(e.Errors[i].Message, "Erro: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);

                    if (e.Errors[i].Number == 4060)
                    {
                        MessageBox.Show("Banco de dados não existente! ", "Erro: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);

                        Controller.Cls_CreateDB objCreateDB = new Controller.Cls_CreateDB();
                        objCreateDB.CriarDB();

                    }
                    else if (e.Errors[i].Number == 18456)
                    {
                        MessageBox.Show("Falha ao conectar-se ao Banco de dados", "Erro: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    //else if (e.Errors[i].Number == )
                    //{

                    //}
                }
                return null;
                //throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public SqlDataReader RetornaDataReaderMaster(String strquery)
        {
            try
            {
                SqlDataReader dr;
                SqlCommand sqlComando = new SqlCommand(strquery, AbreBancoMaster());
                dr = sqlComando.ExecuteReader();

                //MessageBox.Show("Banco de dados\nCriado com sucesso!");

                return dr;
            }
            catch (SqlException e)
            {
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    //MessageBox.Show(e.Errors[i].Message, "Erro: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);

                    //if (e.Errors[i].Number == 1801)
                    //{
                    //    MessageBox.Show("Banco de dados já existe! ", "Atenção: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                    //}
                    ////else if (e.Errors[i].Number == )
                    ////{
                    ////    MessageBox.Show(e.Errors[i].Message, "Erro: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                    ////}
                    //else
                    //{
                    //    MessageBox.Show(e.Errors[i].Message, "Erro: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                    //}
                }
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ExecutaComando(String strquery)
        {
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                SqlCommand sqlConn = new SqlCommand(strquery, conn);
                sqlConn.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            //EM caso de erro ou não, o finally é executado para fechar a conexão com o BD
            finally
            {
                FechaBanco(conn);
            }
        }
    }
}
