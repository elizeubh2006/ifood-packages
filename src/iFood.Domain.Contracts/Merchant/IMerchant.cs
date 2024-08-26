using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Merchant
{
    public interface IMerchant
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string CorporateName { get; set; }
        string FinancialOccurrence { get; set; }
    }
}
