using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Uniciv.Api.Models;
using System;



namespace Uniciv.Api.Controllers
{
    public class FundoCapitalControllers:Controller
    {
        [HttpGet("v1/fundocapital")]
        public IActionResult ListarFundos(){
            return  Ok(
                new List<FundoCapital>{
                    new FundoCapital {
                        Nome = "Viagem de Ferias",
                        ValorAtual = 200,
                        ValorNecessario = 5000,
                        DataResgate = new DateTime(2020, 12,1)
                    },
                    new FundoCapital {
                        Nome = "Reserva de Emergencia",
                        ValorAtual = 400,
                        ValorNecessario = 1000

                    }
                }
            );
        } 

     

      [HttpPost("v1/fundocapital")]
        public IActionResult AdicionarFundo([FromBody]FundoCapital fundo){
             return Ok(
                
            );
        }

         [HttpPut("v1/fundocapital/{id}")]
        public IActionResult AlterarFundo(Guid id, [FromBody] FundoCapital fundo )
        {
            return  Ok();
        }

         [HttpGet("v1/fundocapital/{id}")]
        public IActionResult ObterFundo(Guid id,[FromBody] FundoCapital fundo         ){
            return  Ok(
                    new FundoCapital {
                        Nome = "Viagem de Ferias",
                        ValorAtual = 200,
                        ValorNecessario = 5000,
                        DataResgate = new DateTime(2020, 12,1)
                    }
                
            );
        }

        
         [HttpDelete("v1/fundocapital/{id}")]
        public IActionResult RemoverFundo(Guid id,[FromBody] FundoCapital fundo){
            return  Ok(
                
            );
        }
    }
}