using System;
using System.Linq;
using System.Threading.Tasks;
using RestEase;

namespace NytApiClient
{
    public interface ITopStoriesClient
    {
        [Query("api-key")]
        string ApiKey { get; set; }

        [Get("/svc/topstories/v2/{section}.json")]
        Task<ArticleResponse> GetTopStoriesBySection([Path] string section);
    }
}
