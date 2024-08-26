using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Events
{
    public interface IEventsPolling
    {
        Guid Id { get; set; }
        string Code { get; set; }
        string FullCode { get; set; }
        Guid OrderId { get; set; }
        Guid MerchantId { get; set; }
        DateTime CreatedAt { get; set; }
        IMetadata Metadata { get; set; }
    }
}
