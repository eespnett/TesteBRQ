using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EderTeste.Data;
using EderTeste.Entity;

namespace EderTesteBusiness
{
   public class ContacorrenteBusiness
    {


        public bool AlterarContaCorrente(ContaCorrenteEntity entity)
        {
            bool returnAlterarContaCorrente = false;

            try
            {
                ContaCorrente obj = new ContaCorrente()
                {
                    DigitoAgencia = entity.DigitoAgencia,
                    DtCriacao = entity.DtCriacao,
                    DigitoContaCorrente = entity.DigitoContaCorrente,
                    DtInativacao = entity.DtInativacao,
                    idCliente = entity.idCliente,
                    idContaCorrente = entity.idContaCorrente,
                    NumeroAgencia = entity.NumeroAgencia,
                    numeroContaCorrente = entity.numeroContaCorrente,
                    SituacaoConta = entity.SituacaoConta

                };

                returnAlterarContaCorrente = new ContaCorrenteReposiry().AtualizarContaCorrente(obj);

            }
            catch (Exception ex)
            {
                returnAlterarContaCorrente = false;

                throw ex;
            }

            return returnAlterarContaCorrente;
        }

        public bool IncluirContaCorrente(ContaCorrenteEntity entity)
        {
            bool returnIncluirContaCorrente = false;

            try
            {
                ContaCorrente obj = new ContaCorrente()
                {
                    DigitoAgencia = entity.DigitoAgencia,
                    DtCriacao=entity.DtCriacao,
                    DigitoContaCorrente=entity.DigitoContaCorrente,
                    DtInativacao=entity.DtInativacao,
                    idCliente=entity.idCliente,
                    idContaCorrente=entity.idContaCorrente,
                    NumeroAgencia=entity.NumeroAgencia,
                    numeroContaCorrente=entity.numeroContaCorrente,
                    SituacaoConta=entity.SituacaoConta

                };

                returnIncluirContaCorrente = new ContaCorrenteReposiry().IncluirContaCorrente(obj);

            }
            catch (Exception ex)
            {
                returnIncluirContaCorrente = false;

                throw ex;
            }

            return returnIncluirContaCorrente;
        }
    }
}