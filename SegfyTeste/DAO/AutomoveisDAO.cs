using SegfyTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegfyTeste.DAO
{
    public class AutomoveisDAO
    {
        string stringConexao = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = Frota; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
        Automovel automovel = new Automovel();
        public bool InserirApolice(int IdCliente, int IdVeiculo, double ValorPremio)
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

        public List<Automovel> ListarAutomoveis()
        {
            List<Automovel> ListAutomoveis = new List<Automovel>();

            using (var conn = new System.Data.SqlClient.SqlConnection(stringConexao))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    using (var comm = new System.Data.SqlClient.SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "SELECT C.Nome, A.ValorPremio, A.Apolice, V.Placa FROM Apolice as A inner join Cliente as C on c.Id = A.IdCliente" +
                            " inner join Veiculo as V on V.IdCliente = C.Id ";
                        using (var reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                automovel.Apolice  = (int)reader["Apolice"];
                                automovel.ValorPremio = (int)reader["ValorPremio"];
                                automovel.NomeCliente = reader["Nome"].ToString();
                                automovel.Placa = reader["Placa"].ToString();
                                ListAutomoveis.Add(automovel);
                            }
                        }
                    }
                }
            }

            return ListAutomoveis;
        }

        public bool ExcluirApolice(int Apolice)
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
                            comm.CommandText = "DELETE FROM Apolice WHERE Id ='" + Apolice + "'";
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

        public bool AtualizarVeiculo(double ValorPremio, int Apolice)
        {
            bool ret = false;
            using (var conn = new System.Data.SqlClient.SqlConnection(stringConexao))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        using (var comm = new System.Data.SqlClient.SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = "UPDATE Apolice Set ValorPremio ='" + ValorPremio + "' Where Id =  '" + Apolice + "'";
                            comm.ExecuteReader();

                        }
                    }
                    catch (Exception)
                    {
                        ret = false;
                        throw;
                    }
                }
                ret = true;
            }
            return ret;
        }
    }
}