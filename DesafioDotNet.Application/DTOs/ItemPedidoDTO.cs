using DesafioDotNet.Domain.Base;
using DesafioDotNet.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNet.Application.DTOs;
public class ItemPedidoDTO
{
    public int Id { get; set; }
    public int IdPedido { get; private set; }
    public string NomeProduto { get; set; }
    public decimal ValorUnitario { get;set; }
    public int Quantidade { get; private set; }


    //public PedidoModel Pedido { get; set; } 

    // Construtor para criação de novo item de pedido

    public ItemPedidoDTO() { }

    public ItemPedidoDTO(ItemPedido ip) 
    {
        if (ip != null) 
        {
            Id = ip.Id;
            IdPedido = ip.PedidoId;
            NomeProduto = ip.Produto.NomeProduto;
            ValorUnitario = ip.Produto.Valor;
            Quantidade = ip.Quantidade;
        }
    }

    // Métodos específicos relacionados ao item de pedido, se necessário...
}

