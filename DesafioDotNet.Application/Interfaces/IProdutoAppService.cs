using DesafioDotNet.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNet.Application.Interfaces
{
    public interface IProdutoAppService
    {
        Task<List<ProdutoDTO>> ObterProdutos();
        // Outros métodos relacionados a produtos...
    }
}
