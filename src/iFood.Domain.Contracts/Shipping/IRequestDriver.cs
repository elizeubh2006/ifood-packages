using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Shipping
{
    public interface IRequestDriver
    {
        string Code { get; set; }
        string Message { get; set; }
        List<string> Details { get; set; }
    }
}
