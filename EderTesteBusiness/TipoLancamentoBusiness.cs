using System;
using System.Collections.Generic;
using System.Text;
using EderTeste.Data;
using EderTeste.Entity;



namespace EderTeste.Business
{
   public class TipoLancamentoBusiness
    {

        public bool IncluirTipoLancamento(TipoLancamentoEntity entity)
        {
            bool returnIncluirTipoLancamento = false;


            try
            {
                TipoLancamento obj = new TipoLancamento() {idTipoLancamento= entity.idTipoLancamento,
                Lancamento=entity.Lancamento,
                Observacao= entity.Observacao,
                Situcao= entity.Situcao};

                returnIncluirTipoLancamento = new TipoLancamento().(obj);
            }
            catch (Exception ex)
            {
                returnIncluirTipoLancamento = false;
                throw ex;
            }

            return returnIncluirTipoLancamento;

        }

        public bool ProcessarLancamento(ContaCorrenteEntity contaCorrenteDestino, ContaCorrenteEntity contaCorrenteOrigem, LancamentoEntity oLancamento, string strObj)
        {
          bool bValidar=  ValidarDadosEntrada(contaCorrenteDestino, contaCorrenteOrigem, oLancamento);

            if (bValidar==true)
            {
                bValidar = new LancamentoBusiness().IncluirLancamento(oLancamento);

                new LogBusiness().IncluirLog(new LogEntity() {dtLog=DateTime.Now,
                idOperacao=1,
                JsaonObject=strObj,
                Log= "O processamento foi efetuado com sucesso"});
                
            }
            else
            {

                 bValidar= false;
            }

            return bValidar;
        }

        private bool  ValidarDadosEntrada(ContaCorrenteEntity contaCorrenteDestino, ContaCorrenteEntity contaCorrenteOrigem, LancamentoEntity oLancamento)
        {
            bool bValidador = false;


            if (contaCorrenteDestino != null)
            {
                bValidador = true;
            }
            else
            {
                bValidador = false;
            }

            if (contaCorrenteOrigem != null)
            {
                bValidador = true;
            }
            else
            {
                bValidador = true;
            }
            if (oLancamento != null)
            {
                bValidador = true;
            }

            return bValidador;
        }

        public bool AlterarTipoLancamento(TipoLancamentoEntity entity)
        {
            bool returnAlterarTipoLancamento = false;


            try
            {
                TipoLancamento obj = new TipoLancamento()
                {
                    idTipoLancamento = entity.idTipoLancamento,
                    Lancamento = entity.Lancamento,
                    Observacao = entity.Observacao,
                    Situcao = entity.Situcao
                };

                returnAlterarTipoLancamento = new LancamentoRepository().AtualizarLancamento(obj);
            }
            catch (Exception ex)
            {
                returnAlterarTipoLancamento = false;
                throw ex;
            }

            return returnAlterarTipoLancamento;

        }


    }
}
