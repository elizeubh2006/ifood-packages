using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Merchant
{
    public interface IShift
    {
        Guid Id { get; set; }
        string DayOfWeek { get; set; }
        string Start { get; set; }
        int Duration { get; set; }
    }
}
