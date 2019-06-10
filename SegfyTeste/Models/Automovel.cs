using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegfyTeste.Models
{
    public class Automovel
    {
        public int Apolice { get; set; }
        public int CPFCNPJ { get; set; }
        public string Placa { get; set; }
        public double ValorPremio { get; set; }

        public Automovel(int apolice)
        {
            this.Apolice = apolice;
        }
    }
}