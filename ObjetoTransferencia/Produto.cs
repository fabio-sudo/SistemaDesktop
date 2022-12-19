using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
    public class Produto
    {

        public int codigoProduto { get; set; }
        public string descricaoProduto { get; set; }
        public string referenciaProduto { get; set; }
        public string sexoProduto { get; set; }
        public Genero Genero { get; set; }
        public Grade Grade { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int quantidadeProduto { get; set; }
        public double precoCustoProduto { get; set; }
        public double precoVendaProduto { get; set; }
        public DateTime dataProduto { get; set; }

    }
    public class ProdutoLista : List<Produto> { }

    public class ImagemProdutoLista : List<string> { }
}
