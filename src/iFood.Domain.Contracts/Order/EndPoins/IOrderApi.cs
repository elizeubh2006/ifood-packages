using iFood.Domain.Contracts.Cancellation;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order.EndPoins
{
    public interface IOrderApi
    {
        // Obter detalhes do pedido
        [Get("/order/v1.0/orders/{orderId}")]
        Task<IOrderDetails> GetOrderDetailsAsync([AliasAs("orderId")] string orderId, [Header("Authorization")] string bearerToken);

        // Confirmar pedido
        [Post("/order/v1.0/orders/{orderId}/confirm")]
        Task ConfirmOrderAsync([AliasAs("orderId")] string orderId, [Header("Authorization")] string bearerToken);

        // Iniciar preparação do pedido
        [Post("/order/v1.0/orders/{orderId}/startPreparation")]
        Task StartPreparationAsync([AliasAs("orderId")] string orderId, [Header("Authorization")] string bearerToken);

        // Pedido pronto para retirada
        [Post("/order/v1.0/orders/{orderId}/readyToPickup")]
        Task ReadyToPickupAsync([AliasAs("orderId")] string orderId, [Header("Authorization")] string bearerToken);

        // Despachar pedido
        [Post("/order/v1.0/orders/{orderId}/dispatch")]
        Task DispatchOrderAsync([AliasAs("orderId")] string orderId, [Header("Authorization")] string bearerToken);

        // Solicitar cancelamento do pedido
        [Post("/order/v1.0/orders/{orderId}/requestCancellation")]
        Task RequestCancellationAsync([AliasAs("orderId")] string orderId, [Header("Authorization")] string bearerToken, [Body] ICancellationRequest cancellationRequest);

        // Obter razões de cancelamento
        [Get("/order/v1.0/orders/{orderId}/cancellationReasons")]
        Task<IEnumerable<ICancellationReasons>> GetCancellationReasonsAsync([AliasAs("orderId")] string orderId, [Header("Authorization")] string bearerToken);

        // Obter rastreamento do pedido
        [Get("/order/v1.0/orders/{orderId}/tracking")]
        Task<IOrderTracking> GetOrderTrackingAsync([AliasAs("orderId")] string orderId, [Header("Authorization")] string bearerToken);
    }
}
