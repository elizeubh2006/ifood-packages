using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts
{
    public interface IValidation
    {
        string Id { get; set; }
        string Code { get; set; }
        string State { get; set; }
        IMessage Message { get; set; }
    }
}
