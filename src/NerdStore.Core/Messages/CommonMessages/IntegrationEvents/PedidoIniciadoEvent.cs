using NerdStore.Core.DTO;
using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommonMessages.IntegrationEvents;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Messages.CommonMessages.IntegrationEvents
{
    public class PedidoIniciadoEvent : IntegrationEvent
    {

        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal Total { get; private set; }
        public ListaProdutoPedido ProdutosPedido { get; private set; }
        public string NomeCartao { get; private set; }
        public string NumeroCartao { get; private set; }
        public string ExpiracaoCartao { get; private set; }
        public string CvvCartao { get; private set; }

        public PedidoIniciadoEvent(Guid pedidoId, Guid clienteId, ListaProdutoPedido produtosPedido, decimal total,  string nomeCartao, string numeroCartao, string expiracaoCartao, string cvvCartao)
        {
            PedidoId = pedidoId;
            ClienteId = clienteId;
            Total = total;
            ProdutosPedido = produtosPedido;
            NomeCartao = nomeCartao;
            NumeroCartao = numeroCartao;
            ExpiracaoCartao = expiracaoCartao;
            CvvCartao = cvvCartao;
        }



    }
}
