using System;

namespace ProvaBACK.Models
{
    public class ItemVenda
    {
        public ItemVenda() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string CarrinhoId { get; set; }
        public string Metodo { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}