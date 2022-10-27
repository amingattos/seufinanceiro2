using System;
using System.Data.SqlClient;
using System.Windows;
using System.IO;

namespace DAL
{
    public class Cls_CreateDB
    {
        String LinhaComandoSQL;

        private string _processos;
        public string Processos { get => _processos; set => _processos = value; }

        public SqlDataReader CriarDB()
        {
            int counter = 0;

            string[] commands;
            commands = new string[9]; //0-8

            try
            {
                foreach (string linha in File.ReadLines("db_seufinanceiro.sql"))
                {
                    commands[counter] = linha;
                    counter++;
                }

                for (int i = 0; i < counter; i++)
                {
                    //MessageBox.Show(commands[i], "", MessageBoxButton.OK);
                    LinhaComandoSQL = commands[i];

                    switch (i)
                    {
                        case 0:
                            Db_seufinanceiro();
                            break;
                        case 1:
                            Create_Tbl_Insert();
                            break;
                        case 2:
                            Create_Tbl_Insert();
                            break;
                        case 3:
                            Create_Tbl_Insert();
                            break;
                        case 4:
                            Create_Tbl_Insert();
                            break;
                        case 5:
                            Create_Tbl_Insert();
                            break;
                        case 6:
                            Create_Tbl_Insert();
                            break;
                        case 7:
                            Create_Tbl_Insert();
                            break;
                        case 8:
                            Create_Tbl_Insert();
                            break;
                    }
                }

                return null;
            }
            catch (SqlException e)
            {
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    //MessageBox.Show("Banco de dados já existe! ", "Atenção: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);

                    if (e.Errors[i].Number == 1801)
                    {
                        //MessageBox.Show("Banco de dados já existe! ", "Atenção: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    //else if (e.Errors[i].Number == )
                    //{
                    //    MessageBox.Show(e.Errors[i].Message, "Erro: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                    //}
                    else
                    {
                        MessageBox.Show(e.Errors[i].Message, "Erro: " + e.Errors[i].Number.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                return null;
                //throw e;
            }
        }
        public SqlDataReader Db_seufinanceiro()
        {
            Cls_ConnDB_Sql ObjCreateDB = new Cls_ConnDB_Sql();
            return ObjCreateDB.RetornaDataReaderMaster(LinhaComandoSQL);
        }
        public SqlDataReader Create_Tbl_Insert()
        {
            Cls_ConnDB_Sql ObjConnDB = new Cls_ConnDB_Sql();
            return ObjConnDB.RetornaDataReader(LinhaComandoSQL);
        }
    }
}
