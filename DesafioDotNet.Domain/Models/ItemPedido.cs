using DesafioDotNet.Domain.Base;
using DesafioDotNet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNet.Domain.Model;
public class ItemPedido : BaseEntity
{
    public int PedidoId { get; private set; }
    public int ProdutoId { get; private set; }
    public int Quantidade { get; private set; }

    public Pedido Pedido { get; set; }
    public Produto Produto { get; set; }

    //public PedidoModel Pedido { get; set; } 

    // Construtor para criação de novo item de pedido

    public ItemPedido() { }
    public ItemPedido(int produtoId, int quantidade)
    {
        ProdutoId = produtoId;
        Quantidade = quantidade;
    }

    // Métodos específicos relacionados ao item de pedido, se necessário...
}

