using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProvaBACK.Models
{
    public class Categoria
    {
        public Categoria() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }

        [JsonIgnore]
        public List<Cliente> Clientes { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}