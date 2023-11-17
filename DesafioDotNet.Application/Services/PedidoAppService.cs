using AutoMapper;
using DesafioDotNet.Application.Interfaces;
using DesafioDotNet.Domain.DTOs;
using DesafioDotNet.Domain.Entities;
using DesafioDotNet.Domain.Interfaces;

public class PedidoAppService : IPedidoAppService
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IMapper _mapper;

    public PedidoAppService(IPedidoRepository pedidoRepository, IMapper mapper)
    {
        _pedidoRepository = pedidoRepository;
        _mapper = mapper;
    }

    public async Task<List<PedidoDTO>> ObterPedidos()
    {
        throw new NotImplementedException();
        //var pedidos = await _pedidoRepository.();
        //var pedidosDto = _mapper.Map<List<PedidoDTO>>(pedidos);
        //return pedidosDto;
    }

    public async Task AdicionarPedido(PedidoDTO pedidoDto)
    {
        var pedido = _mapper.Map<Pedido>(pedidoDto);
        await _pedidoRepository.Add(pedido);
    }

    // Outros métodos relacionados a pedidos...
}
