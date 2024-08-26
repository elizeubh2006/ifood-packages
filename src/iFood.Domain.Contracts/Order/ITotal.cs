using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface ITotal
    {
        double AdditionalFees { get; set; }
        double SubTotal { get; set; }
        double DeliveryFee { get; set; }
        double Benefits { get; set; }
        double OrderAmount { get; set; }
    }
}
