using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface ILiability
    {
        string Name { get; set; }
        double Percentage { get; set; }
    }
}
