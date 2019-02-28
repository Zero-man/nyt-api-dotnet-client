using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NytApiClient
{
    public interface IMovieReviews
    {
        [Query("api-key")]
        string ApiKey { get; set; }

        [Get("/svc/movies/v2/critics/{reviewer}.json")]
        Task<MovieCriticsResponse> GetMovieCritics([Path] string reviewer);

        [Get("/svc/movies/v2/reviews/{type}.json")]
        Task<MovieReviewsResponse> GetMovieReviewsByType(
            [Path] string type,
            int offset,
            string order);

        [Get("/svc/movies/v2/reviews/search.json")]
        Task<MovieReviewsResponse> SearchMovieReviews(
            string query, 
            string critics_pick, 
            string reviewer, 
            string publication_date, 
            string opening_date, 
            int? offset, 
            string order);
    }
}
