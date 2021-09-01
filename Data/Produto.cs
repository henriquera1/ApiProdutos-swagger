using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos.Data
{
    public class Produto
    {
        public int Id { get; set; }
        public string nomeFruta { get; set; }
        public string descricaoFruta { get; set; }
        public string fotoFruta { get; set; }
        public decimal valorFruta { get; set; }
        public int qtdFruta { get; set; }
    }
}
