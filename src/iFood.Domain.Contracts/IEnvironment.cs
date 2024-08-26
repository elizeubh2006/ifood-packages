using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts
{
    public interface iEnvironment
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string MerchantApiHost { get; set; }
        string AccessToken { get; set; }
        string ClientId { get; set; }
        string ClientSecret { get; set; }
        string GrantType { get; set; }
        string AuthorizationCode { get; set; }
        string AuthorizationCodeVerifier { get; set; }
        string RefreshToken { get; set; }
        string MerchantId { get; set; }
        string Operation { get; set; }
        string InterruptionId { get; set; }
        string OrderId { get; set; }
        string CancellationCode { get; set; }
        string CancellationReason { get; set; }
        string ChangePreparationTime { get; set; }
        string ChangePreparationReason { get; set; }
        string CatalogId { get; set; }
        string CategoryId { get; set; }
        string ProductId { get; set; }
        string PizzaId { get; set; }
        string OptionGroupId { get; set; }
        int ItemQuantity { get; set; }
        string ReplacedUniqueId { get; set; }
        string Ean { get; set; }
        string UniqueId { get; set; }
        string PostmanVariableScope { get; set; }
        DateTime PostmanExportedAt { get; set; }
        string PostmanExportedUsing { get; set; }
    }
}
