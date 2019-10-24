using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data
{
    public class ContaCorrenteReposiry
    {
        public bool IncluirContaCorrente(ContaCorrente Entity)
        {
            bool returnIncluirContaCorrente = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.ContaCorrente.Add(Entity);
                context.SaveChanges();
                returnIncluirContaCorrente = true;
            }

            return returnIncluirContaCorrente;


        }

        public bool AtualizarContaCorrente(ContaCorrente Entity)
        {
            bool returnAtualizarContaCorrente = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.ContaCorrente.Attach(Entity);
                context.Entry(Entity).State = EntityState.Modified;
                context.SaveChanges();
                returnAtualizarContaCorrente = true;
            }

            return returnAtualizarContaCorrente;


        }
    }
}
