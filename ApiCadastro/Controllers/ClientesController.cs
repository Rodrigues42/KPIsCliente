using System;
using crud.Services;
using crud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace crud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        public ClientesController()
        {

        }

        [HttpGet]
        public ActionResult<List<Clientes>> GetAll() => ClientesServices.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Clientes> Get(int id)
        {
            var cliente = ClientesServices.Get(id);

            if(cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public IActionResult Create(Clientes cliente)
        {
            ClientesServices.Add(cliente);

            return CreatedAtAction(nameof(Create), new {id = cliente.Id}, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Clientes cliente)
        {
            if(id != cliente.Id){
                return BadRequest();
            }

            ClientesServices.Update(cliente);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = ClientesServices.Get(id);

            if(cliente is null){
                return BadRequest();
            }

            ClientesServices.Delete(id);

            return NoContent();
        }
    }
}