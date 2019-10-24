using System;
using System.Collections.Generic;
using System.Text;
using EderTeste.Data;
using EderTeste.Entity;



namespace EderTeste.Business
{
  public  class OperacaoBusiness
    {

        public bool IncluirOperacao(OperacaoEntity entity)
        {
          bool  returnIncluirOperacao = false;
            try
            {
                Operacao obj = new Operacao() { descOperacao = entity.Operacao,
                idOperacao=entity.idOperacao,
                Observacao=entity.Observacao,
                Situcao=entity.Situcao};

                returnIncluirOperacao = new OperacoRepository().IncluirOperacao(obj);


            }
            catch (Exception ex)
            {
                returnIncluirOperacao = false;

                throw ex;
            }

            return returnIncluirOperacao;


        }



        public bool AlterarOperacao(OperacaoEntity entity)
        {
            bool returnAlterarOperacao = false;
            try
            {
                Operacao obj = new Operacao()
                {
                    descOperacao = entity.Operacao,
                    idOperacao = entity.idOperacao,
                    Observacao = entity.Observacao,
                    Situcao = entity.Situcao
                };

                returnAlterarOperacao = new OperacoRepository().AtualizarOperacao(obj);


            }
            catch (Exception ex)
            {
                returnAlterarOperacao = false;

                throw ex;
            }

            return returnIncluirOperacao;


        }





    }
}
