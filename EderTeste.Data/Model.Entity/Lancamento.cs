using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EderTeste.Data
{
  public  class Lancamento
    {
        public int idLancamento { get; set; }

        public DateTime dtCadastroLancamento { get; set; }

        public DateTime dtEfetivacaoLancamento { get; set; }

        public decimal Valor { get; set; }

        public int idTipoLanmento { get; set; }

        public bool Situacao { get; set; }

        public string Observacao { get; set; }
    }
}