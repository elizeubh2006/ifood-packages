using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Events
{
    public interface IUserCodeRequest
    {
        public string ClientId { get; set; }
    }
}
