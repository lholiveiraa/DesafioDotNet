using DesafioDotNet.Domain.Base;
using DesafioDotNet.Domain.Model;

namespace DesafioDotNet.Application.DTOs;
public class PedidoDTO
{
    public int Id {get; set;}
    public string? NomeCliente { get; set; }
    public string? EmailCliente { get; set; }
    public DateTime DataCriacao { get; set; }
    public bool Pago { get; set; }
    public List<ItemPedidoDTO> ItensPedido { get; set; }

    public decimal ValorTotal { get; set; }

    public PedidoDTO() { }

    public PedidoDTO(Pedido p) 
    {
        if (p != null) 
        {
            this.Id = p.Id;
            this.NomeCliente = p.NomeCliente;
            this.EmailCliente = p.EmailCliente;
            this.DataCriacao = p.DataCriacao;
            this.Pago = p.Pago;

            if (p.ItensPedido != null && p.ItensPedido.Any()) 
            {
                this.ItensPedido = new List<ItemPedidoDTO>();
                foreach (var item in p.ItensPedido) 
                {
                    this.ItensPedido.Add(new ItemPedidoDTO(item));
                }

                ValorTotal = this.ItensPedido.Sum(x => x.Quantidade * x.ValorUnitario);
            } 
        }
    }

}
