using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Cancellation
{
    public interface ICancellationRequest
    {
        string CancellationCode { get; }
        string Reason { get; }
    }
}
