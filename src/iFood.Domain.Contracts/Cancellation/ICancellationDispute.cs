using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Cancellation
{
    public interface ICancellationDispute
    {
        bool AutomaticRefund { get; set; }
        string IsContestable { get; set; }
        string Reason { get; set; }
        List<string> Reasons { get; set; }
    }
}
