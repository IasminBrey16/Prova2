using System.Linq;
using ProvaBACK.Data;
using ProvaBACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProvaBACK.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;
        public ClienteController(DataContext context)
        {
            _context = context;
        }

[HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Cliente cliente)
        {
            Cliente clienteExistente = _context.Clientes.FirstOrDefault(u => u.Email == cliente.Email);
            if (clienteExistente != null)
            {
                return BadRequest(new { message = "Cliente já cadastrado" });
            }
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            cliente.Senha = "";
            return Created("", cliente);
        }
    }
}
