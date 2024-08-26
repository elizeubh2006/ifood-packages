using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFood.Domain.Contracts.Merchant;

namespace iFood.Domain.Contracts.Cancellation
{
    public interface IOccurrence
    {
        IConsumer Consumer { get; set; }
        ILogistic Logistic { get; set; }
        IMerchant Merchant { get; set; }
    }
}
