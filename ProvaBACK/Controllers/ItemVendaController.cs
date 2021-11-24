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
    [Route("api/item")]
    public class ItemVendaController : ControllerBase
    {
        private readonly DataContext _context;
        public ItemVendaController(DataContext context)
        {
            _context = context;
        }

        // POST: api/item/create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateAsync([FromBody] ItemVenda item)
        {
            if (String.IsNullOrEmpty(item.CarrinhoId))
            {
                item.CarrinhoId = Guid.NewGuid().ToString();
            }
            item.Produto = _context.Produtos.Find(item.ProdutoId);
            _context.ItensVenda.Add(item);
            await _context.SaveChangesAsync();
            return Created("", item);
        }

        // GET: api/item/getbycartid/XXXXX-XXXX-XXXXXXXXXXX
        [HttpGet]
        [Route("getbycartid/{cartid}")]
        public async Task<IActionResult> GetByCartIdAsync([FromRoute] string cartId)
        {
            return Ok(await _context.ItensVenda
                .Include(item => item.Produto.Categoria)
                .Where(item => item.CarrinhoId == cartId).ToListAsync());
        }
    }
}