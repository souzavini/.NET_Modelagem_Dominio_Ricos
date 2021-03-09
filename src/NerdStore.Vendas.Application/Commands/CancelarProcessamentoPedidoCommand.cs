using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Vendas.Application.Commands
{
    public class CancelarProcessamentoPedidoCommand : Command
    {

        public Guid PedidoId { get; private set; }
        public Guid ClientId { get; private set; }

        public CancelarProcessamentoPedidoCommand(Guid pedidoId, Guid clientId)
        {
            AggregateId = pedidoId;
            PedidoId = pedidoId;
            ClientId = clientId;
        }

    }
}
