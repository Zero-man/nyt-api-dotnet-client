using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NytApiClient
{
    public interface IBooksClient
    {
        [Query("api-key")]
        string ApiKey { get; set; }

        [Get("svc/books/v3/lists.json")]
        Task<BestSellersResponse> GetBestSellers(string list, [Query("bestsellers-date")] string bestSellersDate, [Query("publised-date")] string publishedDate, int offset);

        [Get("svc/books/v3/lists/{date}/{list}.json")]
        Task<BestSellersByDateResponse> GetBestSellersByDate([Path] string date, [Path] string list, int offset);

        [Get("svc/books/v3/lists/best-sellers/history.json")]
        Task<BestSellersHistoryResponse> GetBestSellersHistory([Query("age-group")] string ageGroup, string author, string contributor, string isbn, string price, string publisher, string title);

        [Get("svc/books/v3/lists/overview.json")]
        Task<BestSellersOverviewResponse> GetBestSellersOverview([Query("publised_date")] string publishedDate);

        [Get("svc/books/v3/lists/names.json")]
        Task<BestSellersListNamesResponse> GetListNames();

        [Get("svc/books/v3/reviews.json")]
        Task<ReviewsResponse> GetBookReviews(string isbn, string title, string author);
    }
}
