using System;
using System.Collections.Generic;

namespace NerdStore.Core.DomainObjects.Dto
{
    public class ListaProdutosPedido
    {
        public Guid PedidoId { get; set; }
        public ICollection<Item> Itens { get; set; }
    }
}
