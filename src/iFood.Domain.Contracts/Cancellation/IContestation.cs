using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Cancellation
{
    public interface IContestation
    {
        bool AutomaticRefund { get; set; }
        bool Contestable { get; set; }
        List<string> Reasons { get; set; }
    }
}
