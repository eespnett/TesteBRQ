using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EderTeste.Entity;
//using EderTeste.Data;
using EderTeste.Business;


namespace EderTEste.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentoController : ControllerBase
    {
       

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] ContaCorrenteEntity ContaCorrenteDestino, ContaCorrenteEntity ContaCorrenteOrigem, Lancamento oLancamento )
        {

            bool returnEfetuarLancamento = new TipoLancamentoBusiness().ProcessarLancamento(ContaCorrenteDestino,
                ContaCorrenteOrigem,
                oLancamento);


            if (returnEfetuarLancamento)
            {
              return  StatusCode(200);
            }
            else
            {
                return StatusCode(400);
            }

         
        }



    }
}
