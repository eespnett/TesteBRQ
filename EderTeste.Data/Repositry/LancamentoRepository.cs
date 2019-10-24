using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data
{
   public class LancamentoRepository
    {


        public bool IncluirLancamento(Lancamento Entity)
        {
            bool returnIncluirLancamento = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Lancamento.Add(Entity);
                context.SaveChanges();
                returnIncluirLancamento = true;
            }

            return returnIncluirLancamento;


        }

        public bool AtualizarLancamento(Lancamento Entity)
        {
            bool returnAtualizarContatoCliente = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Lancamento.Attach(Entity);
                context.Entry(Entity).State = EntityState.Modified;
                context.SaveChanges();
                returnAtualizarContatoCliente = true;
            }

            return returnAtualizarContatoCliente;


        }


    }
}
