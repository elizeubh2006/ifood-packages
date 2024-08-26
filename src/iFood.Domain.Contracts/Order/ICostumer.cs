using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface ICustomer
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string DocumentNumber { get; set; }
        IPhone Phone { get; set; }
        int OrdersCountOnMerchant { get; set; }
        string Segmentation { get; set; }
    }
}
