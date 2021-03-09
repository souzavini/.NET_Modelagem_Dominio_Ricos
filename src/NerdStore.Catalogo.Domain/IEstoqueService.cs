﻿using NerdStore.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public interface IEstoqueService : IDisposable
    {
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);
        Task<bool> DebitarListaProdutosPedido(ListaProdutoPedido lista);
        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
        Task<bool> ReporListaProdutosPedido(ListaProdutoPedido lista);
    }
}
