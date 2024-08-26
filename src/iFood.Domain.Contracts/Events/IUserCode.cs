using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Events
{
    public interface IUserCode
    {
        public string UserCode { get; set; }
        public string VerificationUrl { get; set; }
    }
}
