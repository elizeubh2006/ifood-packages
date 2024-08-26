using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Events
{
    public interface ISession
    {
        string AccessToken { get; set; }
        string Type { get; set; }
        int ExpiresIn { get; set; }
    }
}
