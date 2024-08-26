using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFood.Domain.Contracts.Cancellation;

namespace iFood.Domain.Contracts
{
    public interface IRequester
    {
        ICancelUser CancelUser { get; set; }
        string Name { get; set; }
        string Platform { get; set; }
    }
}
