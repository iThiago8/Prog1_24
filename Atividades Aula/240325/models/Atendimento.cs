using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240325.models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime DtAtendimento { get; set; }
        public Veterinario Veterinario { get; set; }
        public Animal Animal { get; set; }
        public string Observacao { get; set; }
        
    }
}