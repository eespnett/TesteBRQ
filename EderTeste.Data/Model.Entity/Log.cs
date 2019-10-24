using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EderTeste.Data
{
  public  class Log
    {
        public int idLog { get; set; }

        public int idOperacao { get; set; }

        public DateTime dtLog { get; set; }

        public string Log { get; set; }

        public string JsaonObject { get; set; }
    }
}