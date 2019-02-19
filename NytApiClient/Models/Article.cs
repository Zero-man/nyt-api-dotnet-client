using System.Collections.Generic;

namespace NytApiClient
{
    public class Article {
        public string Abstract;
        public string BlogName;
        public string ByLine;
        public string CreatedDate;
        public string[] DesFacet;
        public string[] GeoFacet;
        public string Headline;
        public string ItemType;
        public string Kicker;
        public string MaterialTypeFacet;
        public IEnumerable<Multimedia> Multimedia;
        public string OrgFacet;
        public string[] PerFacet;
        public string PublishedDated;
        public IEnumerable<RelatedUrl> RelatedUrls;
        public string Section;
        public string Source;
        public string Subsection;
        public string ThumbnailStandard;
        public string Title;
        public string UpdatedDate;
        public string Url;
    }
}
