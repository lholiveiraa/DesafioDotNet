using DesafioDotNet.Domain.Interfaces;
using DesafioDotNet.Domain.Model;
using DesafioDotNet.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DesafioDotNet.Infrastructure.Repositories
{
    public class PedidoRepository : Repository<Pedido>
    {
        public PedidoRepository(DesafioDotNetDbContext context) : base(context) { }

        public override Pedido GetById(int id)
        {
            //return _context.PedidoModels.FirstOrDefault(p => p.Id == id);
            var query = _context.Set<Pedido>().Include(x => x.ItensPedido).ThenInclude(x => x.Produto).FirstOrDefault(x => x.Id == id);

            return query != null ? query : new Pedido();

        }

        public override void Update(Pedido pedido)
        {
            //throw new NotImplementedException();
            //_dbContext.Pedidos.Update(pedido);
            //_dbContext.SaveChanges();

            if (pedido == null)
            {
                throw new ArgumentNullException(nameof(pedido));
            }

            // Atualiza o pedido no contexto
            _context.Pedido.Update(pedido);

            // Persiste as alterações no banco de dados
            _context.SaveChanges();
        }

        public override IEnumerable<Pedido> GetAll()
        {
            var query = _context.Set<Pedido>().Include(x => x.ItensPedido).ThenInclude(x => x.Produto);

            return query.Any() ? query.ToList() : new List<Pedido>();
        }

        public override void Save(Pedido entity)
        {
            //throw new NotImplementedException();
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            // Adiciona o pedido ao contexto
            _context.Pedido.Add(entity);

            // Persiste as alterações no banco de dados
            _context.SaveChanges();
        }

        public override async Task<bool> Delete(int id)
        {
            //throw new NotImplementedException();
            var pedido = _context.Pedido.FirstOrDefault(p => p.Id == id);

            if (pedido == null)
            {
                return false; // Pedido não encontrado
            }

            // Remove o pedido do contexto
            _context.Pedido.Remove(pedido);

            // Persiste as alterações no banco de dados
            await _context.SaveChangesAsync();

            return true;
        }
    }

}

