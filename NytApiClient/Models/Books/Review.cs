using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class Review
    {
        [JsonProperty("book_review_link")]
        public string BookReviewLink { get; set; }

        [JsonProperty("first_chapter_link")]
        public string FirstChapterLink { get; set; }

        [JsonProperty("sunday_review_link")]
        public string SundayReviewLink { get; set; }

        [JsonProperty("article_chapter_link")]
        public string ArticleChapterLink { get; set; }
    }
}
