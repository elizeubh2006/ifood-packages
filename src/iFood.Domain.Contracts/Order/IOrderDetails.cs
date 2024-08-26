using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFood.Domain.Contracts.Merchant;

namespace iFood.Domain.Contracts.Order
{
    public interface IOrderDetails
    {
        Guid Id { get; set; }
        string DisplayId { get; set; }
        DateTime CreatedAt { get; set; }
        string Category { get; set; }
        string OrderTiming { get; set; }
        string OrderType { get; set; }
        IDelivery Delivery { get; set; }
        DateTime PreparationStartDateTime { get; set; }
        bool IsTest { get; set; }
        string SalesChannel { get; set; }
        IMerchant Merchant { get; set; }
        ICustomer Customer { get; set; }
        List<IItem> Items { get; set; }
        ITotal Total { get; set; }
        IPayments Payments { get; set; }
        List<IAdditionalFee> AdditionalFees { get; set; }
        IAdditionalInfo AdditionalInfo { get; set; }
    }

}
