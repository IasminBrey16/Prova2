using System;

namespace ProvaBACK.Models
{
    public class FormasPagamento
    {
        public FormasPagamento() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public string Metodo { get; set; }
        public string Parcelado { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}