﻿using NerdStore.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Messages.CommonMessages.IntegrationEvents
{
    public class PedidoProcessamentoCanceladoEvent : IntegrationEvent
    {
  

        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public ListaProdutoPedido ProdutosPedido { get; private set; }

        public PedidoProcessamentoCanceladoEvent(Guid pedidoId, Guid clienteId, ListaProdutoPedido produtosPedido)
        {
            AggregateId = pedidoId;
            PedidoId = pedidoId;
            ClienteId = clienteId;
            ProdutosPedido = produtosPedido;
        }


    }
}