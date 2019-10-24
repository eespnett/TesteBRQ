using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data
{
   public class ContatoClienteRepository
    {

        public bool IncluirContatoCliente(Contato Entity)
        {
            bool returnIncluirContatoCliente = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Contato.Add(Entity);
                context.SaveChanges();
                returnIncluirContatoCliente = true;
            }

            return returnIncluirContatoCliente;


        }

        public bool AtualizarContatoCliente(Contato Entity)
        {
            bool returnAtualizarContatoCliente = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Contato.Attach(Entity);
                context.Entry(Entity).State = EntityState.Modified;
                context.SaveChanges();
                returnAtualizarContatoCliente = true;
            }

            return returnAtualizarContatoCliente;


        }


    }
}
