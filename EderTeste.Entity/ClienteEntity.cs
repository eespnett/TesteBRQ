using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EderTeste.Entity
{
   public class ClienteEntity
    {
        public int idCliente { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public decimal Renda { get; set; }

        public DateTime DtNascimento { get; set; }

        public bool SitucaoCliente { get; set; }
    }
}