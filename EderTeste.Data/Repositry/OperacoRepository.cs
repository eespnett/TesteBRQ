using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data
{
  public  class OperacoRepository
    {

        public bool IncluirOperacao(Operacao Entity)
        {
            bool returnIncluirOperacao = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Operacao.Add(Entity);
                context.SaveChanges();
                returnIncluirOperacao = true;
            }

            return returnIncluirOperacao;


        }

        public bool AtualizarOperacao(Operacao Entity)
        {
            bool returnAtualizarOperacao = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Operacao.Attach(Entity);
                context.Entry(Entity).State = EntityState.Modified;
                context.SaveChanges();
                returnAtualizarOperacao = true;
            }

            return returnAtualizarOperacao;


        }


    }
}
