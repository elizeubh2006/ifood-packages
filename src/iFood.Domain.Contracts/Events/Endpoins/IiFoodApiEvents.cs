using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IiFoodApiEvents
namespace iFood.Domain.Contracts.Events.Endpoins
{

    public interface IEventsApi
    {
        // {{merchantApiHost}}/authentication/v1.0/oauth/userCode
        [Post("/authentication/v1.0/oauth/userCode")]
        Task<IUserCode> GetUserCodeAsync([Body(BodySerializationMethod.UrlEncoded)] IUserCodeRequest request);

        // {{merchantApiHost}}/authentication/v1.0/oauth/token
        [Post("/authentication/v1.0/oauth/token")]
        Task<ISession> GetTokenAsync([Body(BodySerializationMethod.UrlEncoded)] ITokenRequest request);

        // {{merchantApiHost}}/events/v1.0/events:polling
        [Get("/events/v1.0/events:polling")]
        Task<IEnumerable<IEventsPolling>> PollEventsAsync([Header("Authorization")] string bearerToken);

        // {{merchantApiHost}}/events/v1.0/events/acknowledgment
        [Post("/events/v1.0/events/acknowledgment")]
        Task AcknowledgeEventsAsync([Header("Authorization")] string bearerToken, [Body] IEnumerable<string> eventIds);
    }









}
