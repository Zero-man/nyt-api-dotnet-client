using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NytApiClient
{
    public interface ITagsClient
    {
        [Query("api-key")]
        string ApiKey { get; set; }

        [Get("/svc/suggest/v1/timestags")]
        Task GetTags(string query, string filter, int max);
    }
}
