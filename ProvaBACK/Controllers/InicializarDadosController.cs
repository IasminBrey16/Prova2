using Microsoft.AspNetCore.Mvc;
using ProvaBACK.Models;
using ProvaBACK.Data;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProvaBACK.Controllers
{
    [ApiController]
    [Route("api/inicializar-dados")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateAsync([FromBody] InicializarDados iniciar)
        {
            if (String.IsNullOrEmpty(iniciar.CarrinhoId))
            {
                iniciar.CarrinhoId = Guid.NewGuid().ToString();
            }
            iniciar.Produto = _context.Produtos.Find(iniciar.CarrinhoId);
            _context.InicializarDados.Add(iniciar);
            await _context.SaveChangesAsync();
            return Created("", iniciar);
        }

    }
}
