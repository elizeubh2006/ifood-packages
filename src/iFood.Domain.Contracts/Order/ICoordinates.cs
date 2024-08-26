using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface ICoordinates
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}
