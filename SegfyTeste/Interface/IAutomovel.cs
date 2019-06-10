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
        bool InserirAutomovel();
        List<Automovel> ListarAutomoveis();
    }
}
