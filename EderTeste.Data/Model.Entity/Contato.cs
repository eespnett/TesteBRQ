using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EderTeste.Data
{
  public  class Contato
    {

        public int idContato { get; set; }

        public int idTipoContato { get; set; }

        public string Conato { get; set; }

        public string SitucaoContato { get; set; }

        public string Observacao { get; set; }
    }
}