using System;
using System.Collections.Generic;
using System.Text;
using EderTeste.Data;
using EderTeste.Entity;



namespace EderTeste.Business
{
   public class LancamentoBusiness
    {

        public bool IncluirLancamento(LancamentoEntity entity)
        {
            bool returnIncluirLancamento = false;

            try
            {
                Lancamento obj = new Lancamento() {dtCadastroLancamento=entity.dtCadastroLancamento,
                dtEfetivacaoLancamento=entity.dtEfetivacaoLancamento,
                idLancamento=entity.idLancamento,
                idTipoLanmento=entity.idTipoLanmento,
                Observacao=entity.Observacao,
                Situacao=entity.Situacao,
                Valor=entity.Valor};


                returnIncluirLancamento = new LancamentoRepository().IncluirLancamento(obj);

            }
            catch (Exception ex)
            {
                returnIncluirLancamento = false;

                throw ex;
            }

            return returnIncluirLancamento;

        }


        public bool AlterarLancamento(LancamentoEntity entity)
        {
            bool returnIncluirLancamento = false;

            try
            {
                Lancamento obj = new Lancamento()
                {
                    dtCadastroLancamento = entity.dtCadastroLancamento,
                    dtEfetivacaoLancamento = entity.dtEfetivacaoLancamento,
                    idLancamento = entity.idLancamento,
                    idTipoLanmento = entity.idTipoLanmento,
                    Observacao = entity.Observacao,
                    Situacao = entity.Situacao,
                    Valor = entity.Valor
                };


                returnIncluirLancamento = new LancamentoRepository().AtualizarLancamento(obj);


            }
            catch (Exception ex)
            {
                returnIncluirLancamento = false;

                throw ex;
            }

            return returnIncluirLancamento;

        }



    }
}
