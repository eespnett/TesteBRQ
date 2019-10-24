using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data
{
   public class ClienteRepository
    {

        public bool IncluirCliente(Cliente Entity)
        {
            bool returnIncluirCliente = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Cliente.Add(Entity);
                context.SaveChanges();
                returnIncluirCliente = true;
            }

            return returnIncluirCliente;
            
      
        }

        public bool AtualizarCliente(Cliente Entity)
        {
            bool returnAtualizarCliente = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Cliente.Attach(Entity);
                context.Entry(Entity).State = EntityState.Modified;
                context.SaveChanges();

                returnAtualizarCliente = true;
            }

            return returnAtualizarCliente;


        }

    }
}
