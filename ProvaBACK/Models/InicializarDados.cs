using System;
using System.Collections.Generic;

namespace ProvaBACK.Models
{
    public class InicializarDados
    {
        public InicializarDados() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
        public string CarrinhoId { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}