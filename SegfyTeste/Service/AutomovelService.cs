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
        public bool InserirAutomovel()
        {
            return automoveisBLL.InserirAutomovel();
        }

        public List<Automovel> ListarAutomoveis()
        {
            throw new NotImplementedException();
        }
    }
}