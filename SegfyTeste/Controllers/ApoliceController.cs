using SegfyTeste.Models;
using SegfyTeste.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SegfyTeste.Controllers
{
    public class ApoliceController : ApiController
    {
        private static List<Automovel> automoveis = new List<Automovel>();
        AutomovelService automovelService = new AutomovelService();

        public List<Automovel> Get()
        {
            automovelService.ListarApolice();
            return automoveis;
        }

        public void Post(int IdCliente, int IdVeiculo, double ValorPremio)
        {
            automovelService.InserirApolice( IdCliente, IdVeiculo, ValorPremio);
        }

        public bool Delete(int Apolice)
        {
            return automovelService.ExcluirApolice(Apolice);
        }

        public bool Update(int Apolice, double ValorPremio)
        {
            return automovelService.AtualizarVeiculo(ValorPremio, Apolice);
        }
    }
}
