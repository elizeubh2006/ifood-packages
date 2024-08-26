using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts
{
    public interface ISalesChannel
    {
        string Name { get; set; }
        bool Enabled { get; set; }
    }
}
