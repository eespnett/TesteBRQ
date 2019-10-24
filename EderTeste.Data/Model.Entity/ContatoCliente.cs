using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EderTeste.Data
{
  public  class ContatoCliente
    {
        public int idContatoCliente { get; set; }

        public int idContato { get; set; }

        public int idCliente { get; set; }
    }
}