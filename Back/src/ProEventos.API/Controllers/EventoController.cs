using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EventoController : ControllerBase
    {

        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
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
