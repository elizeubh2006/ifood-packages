using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Merchant
{
    public interface IAddress
    {
        string Country { get; set; }
        string State { get; set; }
        string City { get; set; }
        string District { get; set; }
        string Street { get; set; }
        string Number { get; set; }
        string PostalCode { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}
