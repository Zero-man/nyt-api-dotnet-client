using System;
using System.Linq;
using System.Threading.Tasks;
using RestEase;

namespace NytApiClient
{
    public interface ISemanticClient
    {
        [Query("api-key")]
        string ApiKey { get; set; }

        [Get("/svc/semantic/v2/concept/name/{conceptType}/{specificConcept}.json")]
        Task<SearchByConceptResponse> SearchByConcept(
            [Path] string conceptType,
            [Path] string specificConcept,
            string fields,
            string query);

        [Get("/svc/semantic/v2/concept/search.json")]
        Task<SearchResponse> Search(
            string query,
            int offset,
            string fields);
    }
}
