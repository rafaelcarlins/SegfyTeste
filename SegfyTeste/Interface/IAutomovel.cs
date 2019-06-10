using SegfyTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegfyTeste.Interface
{
    public interface IAutomovel
    {
        bool InserirApolice(int IdCliente, int IdVeiculo, double ValorPremio);
        List<Automovel> ListarApolice();
        bool ExcluirApolice(int Apolice);
        bool AtualizarVeiculo(double ValorPremio, int Apolice);
    }
}
