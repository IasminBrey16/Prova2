using System;

namespace ProvaBACK.Models
{
    public class Cliente
    {
        public Cliente() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}