using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace iFood.Domain.Contracts.Order
{
    public interface IPaymentMethod
    {
        double Value { get; set; }
        string Currency { get; set; }
        string Method { get; set; }
        bool Prepaid { get; set; }
        string Type { get; set; }
        ICard Card { get; set; }
    }
}
