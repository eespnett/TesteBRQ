using System;
using EderTeste.Entity;
using EderTeste.Data;

namespace EderTesteBusiness
{
    public class ClienteBusiness
    {

        public bool IncluirCliente(ClienteEntity obj)
        {
            bool returnIncluirCliente = false;

            try
            {
                Cliente oCliente = new Cliente()
                {
                    CPF = obj.CPF,
                    DtNascimento = obj.DtNascimento,
                    idCliente = obj.idCliente,
                    Nome = obj.Nome,
                    Renda = obj.Renda,
                    RG = obj.RG,
                    SitucaoCliente = obj.SitucaoCliente
                };

                returnIncluirCliente = new ClienteRepository().IncluirCliente(oCliente);
            }
            catch (Exception ex)
            {
                returnIncluirCliente = false;
                throw ex;
            }


            return returnIncluirCliente;

        }


        public bool AlterarCliente(ClienteEntity obj)
        {
            bool returnAlterarCliente = false;

            try
            {
                Cliente oCliente = new Cliente()
                {
                    CPF = obj.CPF,
                    DtNascimento = obj.DtNascimento,
                    idCliente = obj.idCliente,
                    Nome = obj.Nome,
                    Renda = obj.Renda,
                    RG = obj.RG,
                    SitucaoCliente = obj.SitucaoCliente
                };

                returnAlterarCliente = new ClienteRepository().AtualizarCliente(oCliente);
            }
            catch (Exception ex)
            {
                returnAlterarCliente = false;
                throw ex;
            }


            return returnAlterarCliente;

        }
    }
}
