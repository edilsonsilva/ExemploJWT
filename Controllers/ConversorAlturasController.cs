using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PROJETOJWT.Controllers
{
    [Route("api/[controller]")]
    public class ConversorAlturasController:Controller
    {
        [Authorize("Admin")]
        [HttpGet("PesMetros/{alturaPes}")]
        public object Get(double alturaPes){
            return new{
                AlturaPes = alturaPes,
                AlturaMetros = Math.Round(alturaPes*0.3048,4)
            };
        }
        [Authorize("Admin")]
        [HttpGet("Outros/{alturaPes}")]
        public object Novo(double alturaPes){
            return new{
                AlturaPes = alturaPes,
                AlturaMetros = Math.Round(alturaPes*0.3048,4)
            };
        }
    }
}