using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Events
{
    public class ITokenRequest
    {
        public string GrantType { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string AuthorizationCode { get; set; }
        public string AuthorizationCodeVerifier { get; set; }
        public string RefreshToken { get; set; }
    }
}
