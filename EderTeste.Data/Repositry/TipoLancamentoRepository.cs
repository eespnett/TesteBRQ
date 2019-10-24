using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data.Repositry
{
   public class TipoLancamentoRepository
    {


        public bool IncluirTipoLancamento(TipoLancamento Entity)
        {
            bool returnIncluirLancamento = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.TipoLancameto.Add(Entity);
                context.SaveChanges();
                returnIncluirLancamento = true;
            }

            return returnIncluirLancamento;


        }

        public bool AtualizarTipoLancamento(TipoLancamento Entity)
        {
            bool returnAtualizarContatoCliente = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.TipoLancameto.Attach(Entity);
                context.Entry(Entity).State = EntityState.Modified;
                context.SaveChanges();
                returnAtualizarContatoCliente = true;
            }

            return returnAtualizarContatoCliente;


        }


    }
}
