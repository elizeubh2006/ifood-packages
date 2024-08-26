using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Cancellation
{
    public interface ICancellationReasons
    {
        string Code { get; set; }
        string Message { get; set; }
        string CancelCodeId { get; set; }
        string Description { get; set; }
    }
}
