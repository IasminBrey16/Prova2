using System;
using System.Collections.Generic;

namespace ProvaBACK.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public List<ItemVenda> Produtos { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}