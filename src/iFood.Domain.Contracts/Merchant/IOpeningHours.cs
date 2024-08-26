using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Merchant
{
    public interface IOpeningHours
    {
        List<IShift> Shifts { get; set; }
    }
}
