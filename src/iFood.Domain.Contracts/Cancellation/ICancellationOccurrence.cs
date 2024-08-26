using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Cancellation
{
    public interface ICancellationOccurrence
    {
        IConsumer Consumer { get; set; }
        ILogistic Logistic { get; set; }
        IRestaurant Restaurant { get; set; }
    }
}
