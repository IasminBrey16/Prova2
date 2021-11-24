using ProvaBACK.Data;
using ProvaBACK.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ProvaBACK.Controllers
{
    [ApiController]
    [Route("api/formas-pagamento")]
    public class FormasPagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public FormasPagamentoController(DataContext context)
        {
            _context = context;
        }

[HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateAsync([FromBody] FormasPagamento formasPagamento)
        {
            _context.FormasPagamentos.Add(formasPagamento);
            await _context.SaveChangesAsync();
            return Created("", formasPagamento);
        }
    }
}
