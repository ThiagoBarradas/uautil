using Xunit;

namespace UAUtil.Tests
{
    /// <summary>
    /// Test main browsers compatibility 
    /// https://udger.com/resources/ua-list
    /// </summary>
    public class BrowserTest
    {
        public IUserAgentUtility UserAgentUtility { get; set; }

        public BrowserTest()
        {
            this.UserAgentUtility = new UserAgentUtility();
        }

        [Fact]
        public void Should_Return_Unknow_Browser_With_Null()
        {
            // arrange
            string userAgent = null;

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Unknow", details.Browser);
            Assert.Equal("Unknow", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Unknow_Browser_With_Wrong_Value()
        {
            // arrange
            var userAgent = "some value";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Unknow", details.Browser);
            Assert.Equal("Unknow", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Edge_Browser()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.9600";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Edge", details.Browser);
            Assert.Equal("12.9600", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_SeaMonkey_Browser()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.5; en-US; rv:1.9.1b3pre) Gecko/20081202 SeaMonkey/2.0a2";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("SeaMonkey", details.Browser);
            Assert.Equal("2.0", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Firefox_Browser()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.5; en-US; rv:1.9.1b3) Gecko/20090305 Firefox/3.1b3 GTB5";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Firefox", details.Browser);
            Assert.Equal("3.1", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Chromium_Browser()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Ubuntu/10.10 Chromium/8.0.552.237 Chrome/8.0.552.237 Safari/534.10";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Chromium", details.Browser);
            Assert.Equal("8.0.552.237", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Chrome_Browser_Format1()
        {
            // arrange
            var userAgent = "Mozilla / 5.0(Linux; U; Android - 4.0.3; en - us; Galaxy Nexus Build / IML74K) AppleWebKit / 535.7(KHTML, like Gecko) CrMo / 16.0.912.75 Mobile Safari/ 535.7";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Chrome", details.Browser);
            Assert.Equal("16.0.912.75", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Chrome_Browser_Format2()
        {
            // arrange
            var userAgent = "Mozilla / 5.0(Windows; U; Windows NT 6.1; en - US) AppleWebKit / 534.10(KHTML, like Gecko) Chrome / 7.0.540.0 Safari / 534.10";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Chrome", details.Browser);
            Assert.Equal("7.0.540.0", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Opera_Browser_Format1()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.12 Safari/537.36 OPR/14.0.1116.4";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Opera", details.Browser);
            Assert.Equal("14.0.1116.4", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Opera_Browser_Format2()
        {
            // arrange
            var userAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1) Opera 7.10 [en]";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Opera", details.Browser);
            Assert.Equal("7.10", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_InternetExplorer_Browser_Format1()
        {
            // arrange
            var userAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; GTB6; Ant.com Toolbar 1.6; MSIECrawler)";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Internet Explorer", details.Browser);
            Assert.Equal("6.0", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_InternetExplorer_Browser_Format2()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (IE 11.0; Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Internet Explorer", details.Browser);
            Assert.Equal("11", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_InternetExplorer_Browser_Format3()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (IE 11.0; Windows NT 6.3; Trident/7.0; .NET4.0E; .NET4.0C; rv:11.0) like Gecko";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Internet Explorer", details.Browser);
            Assert.Equal("11", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Safari_Browser()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/528.16 (KHTML, like Gecko) Version/4.0 Safari/528.16";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Safari", details.Browser);
            Assert.Equal("528.16", details.BrowserVersion);
        }

        [Fact]
        public void Should_Return_Curl_Browser()
        {
            // arrange
            var userAgent = "curl/7.51.0";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("curl", details.Browser);
            Assert.Equal("7.51.0", details.BrowserVersion);
        }
    }
}
