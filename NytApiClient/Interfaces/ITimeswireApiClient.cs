using System;
using System.Linq;
using System.Threading.Tasks;
using RestEase;

namespace NytApiClient
{
    public interface ITimeswireApiClient
    {
        [Query("api-key")]
        string ApiKey { get; set; }

        [Get("/svc/news/v3/content.json")]
        Task<ArticleResponse> GetTimeswireArticlesByUrl(string url);

        [Get("/svc/news/v3/content/{source}/{section}.json")]
        Task<ArticleResponse> GetTimeswireArticlesBySource(
            [Path] string source, 
            [Path] string section,
            string limit,
            string offset);

        [Get("/svc/news/v3/content/{source}/{section}/{timePeriod}.json")]
        Task<ArticleResponse> GetTimeswireArticlesBySourceAndTimePeriod(
            [Path] string source, 
            [Path] string section,
            [Path] string timePeriod,
            string limit,
            string offset);
    }
}
