using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFood.Domain.Contracts.Cancellation;

namespace iFood.Domain.Contracts
{
    public interface IMetadata
    {
        string Details { get; set; }
        string ReasonCode { get; set; }
        ICancellationDispute CancellationDispute { get; set; }
        ICancellationOccurrence CancellationOccurrence { get; set; }
        Guid CancellationRequestedEventId { get; set; }
        string CancellationRequestSource { get; set; }
        string CancelCode { get; set; }
        string CancelCodeDescription { get; set; }
        string CancelOrigin { get; set; }
        string CancelReason { get; set; }
        string CancelStage { get; set; }
        string CancelUser { get; set; }
        Guid PolicyId { get; set; }
        string CancellationPlatformVersion { get; set; }
        ICancellationPolicy CancellationPolicy { get; set; }
        Guid CancellationRequestEventId { get; set; }
        ICancellationRequestMetadata CancellationRequestMetadata { get; set; }
        bool IsTestOrder { get; set; }
        IRequester RequestedBy { get; set; }
    }
}
