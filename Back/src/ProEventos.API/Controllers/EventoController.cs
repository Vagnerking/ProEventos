using System;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EventoController : ControllerBase
    {


        public EventoController()
        {

        }

        [HttpGet]
        public Evento Get()
        {
            return new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e DotNet 5",
                Local = "João Pessoa",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(30),
                ImagemURL = "foto.png"
            };
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post!";
        }



        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }



        [HttpDelete("{id}")]
        public string Get(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }





    }
}
