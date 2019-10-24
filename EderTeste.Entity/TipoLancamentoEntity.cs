using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Entity
{
  public  class TipoLancamentoEntity
    {

        public int idTipoLancamento { get; set; }

        public string Lancamento { get; set; }

        public string Observacao { get; set; }

        public bool Situcao { get; set; }
    }
}
