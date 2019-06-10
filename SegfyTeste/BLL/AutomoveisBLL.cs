using SegfyTeste.DAO;
using SegfyTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegfyTeste.BLL
{
    public class AutomoveisBLL
    {
        AutomoveisDAO automoveisDAO = new AutomoveisDAO();
        public bool InserirApolice(int IdCliente, int IdVeiculo, double ValorPremio)
        {
            return automoveisDAO.InserirApolice(IdCliente, IdVeiculo, ValorPremio);
        }

        public bool ExcluirApolice(int Apolice)
        {
            return automoveisDAO.ExcluirApolice( Apolice);
        }

        public List<Automovel> ListarAutomoveis()
        {
            return automoveisDAO.ListarAutomoveis();
        }
    }
}