using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface IDelivery
    {
        string Mode { get; set; }
        string DeliveredBy { get; set; }
        DateTime DeliveryDateTime { get; set; }
        IDeliveryAddress DeliveryAddress { get; set; }
        string PickupCode { get; set; }
    }
}
