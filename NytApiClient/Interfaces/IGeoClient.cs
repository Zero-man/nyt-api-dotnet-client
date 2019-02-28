using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NytApiClient
{
    public interface IGeoClient
    {
        [Query("api-key")]
        string ApiKey { get; set; }

        [Get("/svc/semantic/v2/geocodes/query.json")]
        Task<GeoQueryResponse> GetGeoEvents(
            string name, 
            string latitude, 
            string longitude, 
            int? elevation,
            string sw, 
            string query, 
            string filter, 
            string date_range, 
            int? facets, 
            string sort, 
            int? limit, 
            int? offset);
    }
}
