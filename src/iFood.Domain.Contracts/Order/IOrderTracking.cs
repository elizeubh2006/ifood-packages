using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface IOrderTracking
    {
        //TODO: Consultar documentação

        string Status { get; }
        DateTime UpdatedAt { get; }
    }
}
