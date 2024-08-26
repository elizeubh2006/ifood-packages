using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface IPayments
    {
        double Prepaid { get; set; }
        double Pending { get; set; }
        List<IPaymentMethod> Methods { get; set; }
    }
}
