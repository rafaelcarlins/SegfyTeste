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

        public List<Automovel> Get()
        {
            return automoveis;
        }

        public void Post()
        {
            AutomovelService automovelService = new AutomovelService();

            automovelService.InserirAutomovel();
        }
    }
}
