using DesafioDotNet.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNet.Application.Interfaces
{
    public interface IPedidoAppService
    {
        Task<List<PedidoDTO>> ObterPedidos();
        Task AdicionarPedido(PedidoDTO pedidoDto);

        // Outros métodos relacionados a pedidos...
    }
}
