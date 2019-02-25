using System.Collections.Generic;

namespace NytApiClient
{
    public class ArchiveArticle
    {	
        public string Id;
        public Byline byline; 	
        public string DocumentType;
        public Headline Headline;
        public IEnumerable<Keyword> Keywords; 	
        public IEnumerable<Multimedia> Multimedia; 	
        public string NewsDesk;
        public int PrintPage; 	
        public string PubDate;
        public int Score;
        public string Snippet;
        public string Source;
        public string TypeOfMaterial;
        public string Uri;
        public string WebUrl;
        public int WordCount;
    }
}