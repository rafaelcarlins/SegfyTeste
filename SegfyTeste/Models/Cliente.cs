using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegfyTeste.Models
{
    public class Cliente
    {
        public int CPFCNPJ { get; set; }
        public string Nome { get; set; }

        public Cliente(int CPF_CNPJ)
        {
            this.CPFCNPJ = CPF_CNPJ;
        }
    }
}