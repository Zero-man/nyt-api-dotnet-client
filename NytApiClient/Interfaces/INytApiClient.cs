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
    IBooksClient,
    ISemanticClient,
    IMovieReviews
    {
        [Query("api-key")]
        new string ApiKey { get; set; }
    }
}
