using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts
{
    public interface IReopenable
    {
        Guid? Identifier { get; set; }
        string Type { get; set; }
        bool Reopenable { get; set; }
    }
}
