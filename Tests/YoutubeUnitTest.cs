using System;
using Xunit;

namespace Tests
{
    public class YoutubeUnitTest
    {
        private readonly string _search;

        public YoutubeUnitTest()
        {
            _search = Faker.Name.FullName();
        }

        [Fact]
        public void Search()
        {
            
        }
    }
}
