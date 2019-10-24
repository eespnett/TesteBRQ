using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data
{
 public   class ContatoRepository
    {


        public bool IncluirContato(Contato Entity)
        {
            bool returnIncluirContato = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Contato.Add(Entity);
                context.SaveChanges();
                returnIncluirContato = true;
            }

            return returnIncluirContato;


        }

        public bool AtualizarContato(Contato Entity)
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
