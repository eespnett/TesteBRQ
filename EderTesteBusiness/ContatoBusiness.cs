using System;
using System.Collections.Generic;
using System.Text;
using EderTeste.Data;
using EderTeste.Entity;



namespace EderTesteBusiness
{
  public  class ContatoBusiness
    {

        public bool IncluirContato(ContatoEntity entity)
        {
            bool returnIncluirContato = false;


            try
            {
                Contato obj = new Contato() {Conato=entity.Conato,
                idContato=entity.idContato,
                idTipoContato=entity.idTipoContato,
                Observacao=entity.Observacao,
                SitucaoContato=entity.SitucaoContato};


                returnIncluirContato = new ContatoRepository().IncluirContato(obj);



            }
            catch (Exception ex)
            {
                returnIncluirContato = false;
                throw ex;
            }

            return returnIncluirContato;
        }


        public bool AlterarContato(ContatoEntity entity)
        {
            bool returnAlterarContato = false;


            try
            {
                Contato obj = new Contato()
                {
                    Conato = entity.Conato,
                    idContato = entity.idContato,
                    idTipoContato = entity.idTipoContato,
                    Observacao = entity.Observacao,
                    SitucaoContato = entity.SitucaoContato
                };


                returnAlterarContato = new ContatoRepository().AtualizarContato(obj);



            }
            catch (Exception ex)
            {
                returnAlterarContato = false;
                throw ex;
            }

            return returnAlterarContato;
        }
    }
}
