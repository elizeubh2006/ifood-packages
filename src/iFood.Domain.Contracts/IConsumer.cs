using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts
{
    public interface IConsumer
    {
        string FinancialOccurrence { get; set; }
        string PaymentType { get; set; }
    }
}
