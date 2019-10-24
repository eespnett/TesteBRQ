using System;
using System.Collections.Generic;
using System.Text;
using EderTeste.Data;
using EderTeste.Entity;


namespace EderTesteBusiness
{
    public class ContatoClienteBusiness
    {

        public bool IncluirContatoCliente(ContatoClienteEntity entity)
        {
            bool returnIncluirContatoCliente = false;

            try
            {
                ContatoCliente obj = new ContatoCliente() {idCliente= entity.idCliente,
                idContato= entity.idContato,
                idContatoCliente=entity.idContatoCliente};

                returnIncluirContatoCliente = new ContatoClienteRepository().IncluirContatoCliente(obj);

            }
            catch (Exception ex)
            {
                returnIncluirContatoCliente = false;

                throw ex;
            }

            return returnIncluirContatoCliente;
        }

        public bool AlterarContatoCliente(ContatoClienteEntity entity)
        {
            bool returnIncluirContatoCliente = false;

            try
            {
                ContatoCliente obj = new ContatoCliente()
                {
                    idCliente = entity.idCliente,
                    idContato = entity.idContato,
                    idContatoCliente = entity.idContatoCliente
                };

                returnIncluirContatoCliente = new ContatoClienteRepository().AtualizarContatoCliente(obj);

            }
            catch (Exception ex)
            {
                returnIncluirContatoCliente = false;

                throw ex;
            }

            return returnIncluirContatoCliente;
        }

    }
}
