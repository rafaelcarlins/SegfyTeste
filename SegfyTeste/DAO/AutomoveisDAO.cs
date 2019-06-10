using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegfyTeste.DAO
{
    public class AutomoveisDAO
    {
        string stringConexao = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = Frota; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
        public bool InserirAutomoveis(int IdCliente, int IdVeiculo, double ValorPremio)
        {
            bool ret = false;
            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(stringConexao))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (var comm = new System.Data.SqlClient.SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = "INSERT INTO Apolice (IdCliente, idVeiculo, ValorPremio) " +
                                                "VALUES(" + IdCliente + ", " + IdVeiculo + ", '" + ValorPremio + "')";
                            comm.ExecuteReader();
                        }
                    }
                }
                ret = true;
            }
            catch (Exception)
            {
                ret = false;
            }
            
            return ret;
        }
    }
}