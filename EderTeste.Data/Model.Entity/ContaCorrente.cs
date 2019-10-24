using System;

namespace EderTeste.Data
{
    public class ContatoCorrente
    {

        public int idContaCorrente { get; set; }

        public int numeroContaCorrente { get; set; }

        public int DigitoContaCorrente { get; set; }

        public int NumeroAgencia { get; set; }

        public int DigitoAgencia { get; set; }

        public int idCliente { get; set; }

        public bool SituacaoConta { get; set; }

        public DateTime DtCriacao { get; set; }

        public DateTime DtInativacao { get; set; }

    }
}
