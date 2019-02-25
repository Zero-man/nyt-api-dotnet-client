using System;
using System.Linq;
using System.Threading.Tasks;
using RestEase;

namespace NytApiClient
{
    public interface INytApiClient :
    ITimeswireClient,
    ITopStoriesClient,
    ITagsClient,
    IArchiveClient,
    IBooksClient
    {
        [Query("api-key")]
        new string ApiKey { get; set; }
    }
}
