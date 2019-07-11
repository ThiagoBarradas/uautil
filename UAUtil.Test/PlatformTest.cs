using Xunit;

namespace UAUtil.Tests
{
    /// <summary>
    /// Test platforms - Mobile or Desktop
    /// </summary>
    public class PlatformTest
    {
        public IUserAgentUtility UserAgentUtility { get; set; } 

        public PlatformTest()
        {
            this.UserAgentUtility = new UserAgentUtility();
        }

        [Fact]
        public void Should_Return_Unknow_Platform_With_Null()
        {
            // arrange
            string userAgent = null;

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Unknow", details.Platform);
        }

        [Fact]
        public void Should_Return_Unknow_Platform_With_Wrong_Value()
        {
            // arrange
            var userAgent = "some value";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Unknow", details.Platform);
        }

        [Fact]
        public void Should_Return_Mobile_Platform()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Linux; Android 7.0; LG-H910 Build/NRD90C) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.90 Mobile Safari/537.36";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Mobile", details.Platform);
        }

        [Fact]
        public void Should_Return_Desktop_Platform()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (X11; U; Linux Gentoo i686; pl; rv:1.8.0.8) Gecko/20061219 Firefox/1.5.0.8";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Desktop", details.Platform);
        }
    }
}
