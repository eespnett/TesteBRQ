using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data
{
   public class TipoLancamento
    {
        public int idTipoLancamento { get; set; }

        public string Lancamento { get; set; }

        public string Observacao { get; set; }

        public bool Situcao { get; set; }
    }
}
