using AutoMapper;
using DesafioDotNet.Application.Interfaces;
using DesafioDotNet.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNet.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoAppService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoAppService(IProdutoAppService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<List<ProdutoDTO>> ObterProdutos()
        {
            // Lógica para obter produtos do serviço de domínio
            var produtos = await _produtoService.ObterProdutos();
            return _mapper.Map<List<ProdutoDTO>>(produtos);
        }

        // Outros métodos relacionados a produtos...
    }
}
