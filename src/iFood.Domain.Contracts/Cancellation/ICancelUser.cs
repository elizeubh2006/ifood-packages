using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Cancellation
{
    public interface ICancelUser
    {
        string Email { get; set; }
        Guid Id { get; set; }
        string Type { get; set; }
    }
}
