using System.Collections.Generic;

namespace NytApiClient
{
    public class Byline
    {
        public string Organization;
        public string Original;
        public IEnumerable<Person> Person;
    }
}