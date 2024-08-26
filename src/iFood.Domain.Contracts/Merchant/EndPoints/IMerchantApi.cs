using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Merchant.EndPoints
{
    public interface IMerchantApi
    {
        // {{merchantApiHost}}/merchant/v1.0/merchants
        [Get("/merchant/v1.0/merchants")]
        Task<IEnumerable<IMerchant>> GetMerchantsAsync();

        // {{merchantApiHost}}/merchant/v1.0/merchants/{{merchantId}}
        [Get("/merchant/v1.0/merchants/{merchantId}")]
        Task<IDetails> GetMerchantByIdAsync(string merchantId);

        // {{merchantApiHost}}/merchant/v1.0/merchants/{{merchantId}}/status
        [Get("/merchant/v1.0/merchants/{merchantId}/status")]
        Task<IStatus> GetMerchantStatusAsync(string merchantId);

        // {{merchantApiHost}}/merchant/v1.0/merchants/{{merchantId}}/status/delivery
        [Get("/merchant/v1.0/merchants/{merchantId}/status/delivery")]
        Task<IStatusByOperation> GetMerchantDeliveryStatusAsync(string merchantId);

        //TODO: Analyze Interruptions documentations

        // {{merchantApiHost}}/merchant/v1.0/merchants/{{merchantId}}/opening-hours
        [Get("/merchant/v1.0/merchants/{merchantId}/opening-hours")]
        Task<IEnumerable<IOpeningHours>> GetMerchantOpeningHoursAsync(string merchantId);

        // {{merchantApiHost}}/merchant/v1.0/merchants/{{merchantId}}/opening-hours
        [Put("/merchant/v1.0/merchants/{merchantId}/opening-hours")]
        Task UpdateMerchantOpeningHoursAsync(string merchantId, [Body] IEnumerable<IOpeningHours> openingHours);
    }

}
