using System.Collections.Generic;

namespace NytApiClient {
    public class ArticleResponse {
        public string Status;
        public string Copyright;
        public bool HasMore;
        public string NumResults;
        public IEnumerable<Article> Results;
    }
}