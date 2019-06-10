using SegfyTeste.BLL;
using SegfyTeste.Interface;
using SegfyTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegfyTeste.Service
{
    public class AutomovelService : IAutomovel
    {
        AutomoveisBLL automoveisBLL = new AutomoveisBLL();

        public bool AtualizarVeiculo(double ValorPremio, int Apolice)
        {
            throw new NotImplementedException();
        }

        public bool ExcluirApolice(int Apolice)
        {
            return automoveisBLL.ExcluirApolice(Apolice);
        }

        public bool InserirApolice(int IdCliente, int IdVeiculo, double ValorPremio)
        {
            return automoveisBLL.InserirApolice(IdCliente, IdVeiculo, ValorPremio);
        }

        public List<Automovel> ListarApolice()
        {
            return automoveisBLL.ListarAutomoveis();
        }

       
    }
}