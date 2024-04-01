using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade240318.models
{
    public class Imovel
    {
        
        public Categoria Categoria { get; set; }
        public Localidade Localidade { get; set; }
        public TpNegocio TpNegocio { get; set; }
    }

    public enum Categoria
    {
        Apartamento,
        Casa,
        Sitio
    }
        public enum Localidade
    {
        Rural,
        Urbano
    }

    public enum TpNegocio
    {
        Locacacao,
        Venda
    }

}