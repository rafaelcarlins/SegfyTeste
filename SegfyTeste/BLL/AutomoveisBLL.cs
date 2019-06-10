using SegfyTeste.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegfyTeste.BLL
{
    public class AutomoveisBLL
    {
        AutomoveisDAO automoveisDAO = new AutomoveisDAO();
        public bool InserirAutomovel()
        {
            return automoveisDAO.InserirAutomoveis();
        }
    }
}