using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade240318.Models
{
    public class Imovel
    {
        public int ImovelId { get; set; }
        public Categoria Categoria { get; set; }
        public Localidade Localidade { get; set; }
        public TipoNegocio TipoNegocio { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int NumeroComodos { get; set; }

    }
}