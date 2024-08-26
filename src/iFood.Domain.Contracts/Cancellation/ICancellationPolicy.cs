using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Cancellation
{
    public interface ICancellationPolicy
    {
        int CancelCode { get; set; }
        string CancelCodeDescription { get; set; }
        string CancelStage { get; set; }
        string CancellationRequesterOrigin { get; set; }
        string Channel { get; set; }
        IContestation Contestation { get; set; }
        IOccurrence Occurrence { get; set; }
        string Origin { get; set; }
        bool PartialCancellation { get; set; }
        Guid PolicyId { get; set; }
        string Reason { get; set; }
    }
}
