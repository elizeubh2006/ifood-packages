using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Merchant
{
    public interface IDetails
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string CorporateName { get; set; }
        int AverageTicket { get; set; }
        bool Exclusive { get; set; }
        string Type { get; set; }
        string Status { get; set; }
        DateTime CreatedAt { get; set; }
        IAddress Address { get; set; }
        List<IOperation> Operations { get; set; }
        string Test { get; set; }
    }
}
