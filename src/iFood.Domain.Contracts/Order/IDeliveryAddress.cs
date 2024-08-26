using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface IDeliveryAddress
    {
        string StreetName { get; set; }
        string StreetNumber { get; set; }
        string FormattedAddress { get; set; }
        string Neighborhood { get; set; }
        string Complement { get; set; }
        string PostalCode { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }
        string Reference { get; set; }
        ICoordinates Coordinates { get; set; }
    }
}
