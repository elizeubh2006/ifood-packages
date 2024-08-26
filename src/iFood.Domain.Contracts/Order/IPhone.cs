using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface IPhone
    {
        string Number { get; set; }
        string Localizer { get; set; }
        DateTime LocalizerExpiration { get; set; }
    }
}
