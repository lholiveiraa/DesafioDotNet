using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNet.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; private set; }
        public string NomeProduto { get; private set; }
        public decimal Valor { get; private set; }
    }
}
