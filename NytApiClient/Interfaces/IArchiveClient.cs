using System;
using System.Linq;
using System.Threading.Tasks;
using RestEase;

namespace NytApiClient
{
    public interface IArchiveClient
    {
        [Query("api-key")]
        string ApiKey { get; set; }

        [Get("/svc/archive/v1/{year}/{month}.json")]
        Task<ArchiveResponse> GetArchiveArticles([Path] int year, [Path] int month);
    }
}
