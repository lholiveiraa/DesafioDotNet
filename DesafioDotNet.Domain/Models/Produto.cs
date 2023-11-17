using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNet.Domain.Models
{
    public class Produto
    {
        public int Id { get; private set; }
        public string NomeProduto { get; private set; }
        public decimal Valor { get; private set; }

        // Construtor para criação de novo produto
        public Produto(string nomeProduto, decimal valor)
        {
            NomeProduto = nomeProduto;
            Valor = valor;
        }

        // Métodos específicos relacionados ao produto, se necessário...
    }
}
