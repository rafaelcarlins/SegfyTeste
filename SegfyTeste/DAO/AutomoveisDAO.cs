using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegfyTeste.DAO
{
    public class AutomoveisDAO
    {
        string stringConexao = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = Frota; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
        public bool InserirAutomoveis()
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(stringConexao))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    using (var comm = new System.Data.SqlClient.SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "INSERT INTO Veiculos (Chassi, IdCor, IdTipoVeiculo) " +
                                            "VALUES('" + Chassi + "', " + IdCor + ", " + IdVeiculo + ")";
                        comm.ExecuteReader();
                    }
                }
            }
            return true;
        }
    }
}