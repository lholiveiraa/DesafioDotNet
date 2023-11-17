using DesafioDotNet.Domain.Base;


namespace DesafioDotNet.Domain.Model;
public class Pedido : BaseEntity
{
    public string? NomeCliente { get; set; }
    public string? EmailCliente { get; set; }
    public DateTime DataCriacao { get; set; }
    public bool Pago { get; set; }
    public IEnumerable<ItemPedido> ItensPedido { get; set; }

    public Pedido()
    {
        DataCriacao = DateTime.Now;
        Pago = false;
        ItensPedido = new List<ItemPedido>();
    }

    public Pedido(string nomeCliente, string emailCliente)
        : this()
    {
        NomeCliente = nomeCliente;
        EmailCliente = emailCliente;
    }



}
