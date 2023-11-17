using DesafioDotNet.Application.DTOs;
using DesafioDotNet.Domain;
using DesafioDotNet.Domain.Interfaces;
using DesafioDotNet.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDotNet.API.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidoController : ControllerBase
    {
        private readonly IRepository<Pedido> _pedidoRepository;

        public PedidoController(
            IRepository<Pedido> pedidoRepository,
            IRepository<ItemPedido> itemPedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ObterPedidos()
        {
            List<PedidoDTO> listPedidos = new List<PedidoDTO>();
            var pedidos = _pedidoRepository.GetAll();
            foreach (var pedido in pedidos)
            {
                listPedidos.Add(new PedidoDTO(pedido));
            }
            return Ok(listPedidos);
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPedido([FromBody] PedidoDTO pedidoDto)
        {
 
            try
            {
                // Mapeie o PedidoDTO para PedidoModel (implemente a lógica de mapeamento)
                var novoPedido = new Pedido(pedidoDto.NomeCliente, pedidoDto.EmailCliente);

                // Chame o método Save do repositório para adicionar o pedido ao banco de dados
                _pedidoRepository.Save(novoPedido);

                // Retorne um status de sucesso com o novo pedido
                return Ok(novoPedido);
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorne um BadRequest com a mensagem de erro
                return BadRequest($"Erro ao adicionar pedido: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult ObterPedidoPorId(int id)
        {
            var pedidoModel = _pedidoRepository.GetById(id);

            if (pedidoModel == null)
            {
                return NotFound();
            }

            var pedido = new PedidoDTO(pedidoModel);

            return Ok(pedido);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarPedido(int id)
        {
            try
            {
                var pedidoExistente = _pedidoRepository.GetById(id);

                if (pedidoExistente == null)
                {
                    return NotFound();
                }

                // Chame o método Delete do repositório para excluir o pedido do banco de dados
                _pedidoRepository.Delete(id);

                // Retorne um status de sucesso
                return NoContent();
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorne um BadRequest com a mensagem de erro
                return BadRequest($"Erro ao deletar pedido: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarPedido(int id, [FromBody] PedidoDTO pedidoDto)
        {
            try
            {
                var pedidoExistente = _pedidoRepository.GetById(id);

                if (pedidoExistente == null)
                {
                    return NotFound();
                }

                // Atualize as propriedades do pedidoExistente com base no pedidoDto (implemente a lógica de mapeamento)
                pedidoExistente.NomeCliente = pedidoDto.NomeCliente;
                pedidoExistente.EmailCliente = pedidoDto.EmailCliente;

                // Chame o método Update do repositório para salvar as alterações no banco de dados
                _pedidoRepository.Update(pedidoExistente);

                // Retorne um status de sucesso com o pedido atualizado
                return Ok(pedidoExistente);
            }
            catch (Exception ex)
            {
      
                return BadRequest($"Erro ao atualizar pedido: {ex.Message}");
            }
        }


    }


}
