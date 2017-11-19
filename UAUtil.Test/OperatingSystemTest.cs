using Xunit;

namespace UAUtil.Tests
{
    /// <summary>
    /// Test main browsers compatibility 
    /// https://udger.com/resources/ua-list/os
    /// </summary>
    public class OperatingSystemTest
    {
        public IUserAgentUtility UserAgentUtility { get; set; }

        public OperatingSystemTest()
        {
            this.UserAgentUtility = new UserAgentUtility();
        }

        [Fact]
        public void Should_Return_Unknow_Operating_System_With_Null()
        {
            // arrange
            string userAgent = null;

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Unknow", details.OperatingSystem);
            Assert.Equal("Unknow", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Unknow_Operating_System_With_Wrong_Value()
        {
            // arrange
            var userAgent = "some value";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Unknow", details.OperatingSystem);
            Assert.Equal("Unknow", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Android_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Linux; Android 8.0.0; Pixel XL Build/OPP3.170518.006) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.125 Mobile Safari/537.36";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Android OS", details.OperatingSystem);
            Assert.Equal("8.0.0", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_iPad_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0(iPad; U; CPU iPhone OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B314 Safari/531.21.10";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("iPad OS", details.OperatingSystem);
            Assert.Equal("3.2", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_iPhone_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 10_0 like Mac OS X) AppleWebKit/602.1.38 (KHTML, like Gecko) Version/10.0 Mobile/14A5297c Safari/602.1";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("iPhone OS", details.OperatingSystem);
            Assert.Equal("10.0", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Black_Berry_Operating_System_Format1()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (BB10; Kbd) AppleWebKit/537.35+ (KHTML, like Gecko) Version/10.2.1.1925 Mobile Safari/537.35+";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Black Berry", details.OperatingSystem);
            Assert.Equal("10", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Black_Berry_Operating_System_Format2()
        {
            // arrange
            var userAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0) BlackBerry8703e/4.1.0 Profile/MIDP-2.0 Configuration/CLDC-1.1 VendorID/104";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Black Berry", details.OperatingSystem);
            Assert.Equal("8703", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Black_Berry_Operating_System_Format3()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (PlayBook; U; RIM Tablet OS 2.1.0; en-US) AppleWebKit/536.2+ (KHTML, like Gecko) Version/7.2.1.0 Safari/536.2+";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Black Berry", details.OperatingSystem);
            Assert.Equal("2.1.0", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Windows_Phone_Operating_System_Format3()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows Phone 8.1; ARM; Trident/7.0; Touch IEMobile/11.0; HTC; Windows Phone 8S by HTC) like Gecko";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Windows Phone", details.OperatingSystem);
            Assert.Equal("8.1", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Mac_OS_Operating_System_Format3()
        {
            // arrange
            var userAgent = "Eudora/5.2.1b6 (MacOS)";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Mac OS", details.OperatingSystem);
            Assert.Equal("", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Mac_OS_X_Operating_System_Format3()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13) AppleWebKit/603.1.13 (KHTML, like Gecko) Version/10.1 Safari/603.1.13";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Mac OS X", details.OperatingSystem);
            Assert.Equal("10.13", details.OperatingSystemVersion);
        }
        
        [Fact]
        public void Should_Return_Windows_XP_Operating_System_Format1()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.1.8) Gecko/20100202 Firefox/3.5.8";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Windows", details.OperatingSystem);
            Assert.Equal("XP", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Windows_XP_Operating_System_Format2()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.2; cs; rv:1.9.1.8) Gecko/20100202 Firefox/3.5.8";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Windows", details.OperatingSystem);
            Assert.Equal("XP", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Windows_Vista_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 1.1.4322; InfoPath.2; .NET CLR 3.5.21022; .NET CLR 3.5.30729; MS-RTC LM 8; OfficeLiveConnector.1.4; OfficeLivePatch.1.3; .NET CLR 3.0.30729)";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Windows", details.OperatingSystem);
            Assert.Equal("Vista", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Windows_7_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; sk; rv:1.9.1.7) Gecko/20091221 Firefox/3.5.7";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Windows", details.OperatingSystem);
            Assert.Equal("7", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Windows_8_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/536.5 (KHTML, like Gecko) YaBrowser/1.0.1084.5402 Chrome/19.0.1084.5402 Safari/536.5";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Windows", details.OperatingSystem);
            Assert.Equal("8", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Windows_8_1_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (IE 11.0; Windows NT 6.3; Trident/7.0; .NET4.0E; .NET4.0C; rv:11.0) like Gecko";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Windows", details.OperatingSystem);
            Assert.Equal("8.1", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Windows_10_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.10240";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Windows", details.OperatingSystem);
            Assert.Equal("10", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Linux_CentOS_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.8.0.12) Gecko/20080419 CentOS/1.5.0.12-0.15.el4.centos Firefox/1.5.0.12 pango-text";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Linux CentOS", details.OperatingSystem);
            Assert.Equal("1.5.0.12", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Linux_Red_Hat_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.18) Gecko/2010020406 Red Hat/3.0.18-1.el5_4 Firefox/3.18";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Linux Red Hat", details.OperatingSystem);
            Assert.Equal("3.0.18", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Linux_SUSE_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (X11; U; Linux x86_64; zh-cn) AppleWebKit/531.2+ (KHTML, like Gecko) Safari/531.2+ Epiphany/2.28.0 SUSE/2.28.0-2.4";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Linux SUSE", details.OperatingSystem);
            Assert.Equal("2.28.0", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Linux_Debian_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (X11; U; Linux i686; de; rv:1.9.1.5) Gecko/20091112 Iceweasel/3.5.5 (like Firefox/3.5.5; Debian-3.5.5-1)";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Linux Debian", details.OperatingSystem);
            Assert.Equal("3.5.5", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Arch_Linux_Operating_System()
        {
            // arrange
            var userAgent = "Midori/0.1.8 (X11; Arch Linux x86_64; U; en-us) WebKit/532+";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Arch Linux", details.OperatingSystem);
            Assert.Equal("", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Linux_Fedora_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.0.6) Gecko/20060905 Fedora/1.5.0.6-10 Firefox/1.5.0.6 pango-text";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Linux Fedora", details.OperatingSystem);
            Assert.Equal("1.5.0.6", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Linux_Ubuntu_Operating_System()
        {
            // arrange
            var userAgent = "Mozilla/5.0 (X11; U; Linux x86_64; en; rv:1.9.0.14) Gecko/20080528 Ubuntu/9.10 (karmic) Epiphany/2.22 Firefox/3.0";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Linux Ubuntu", details.OperatingSystem);
            Assert.Equal("9.10", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Linux_Others_Operating_System()
        {
            // arrange
            var userAgent = "ELinks/0.9.3 (textmode; Linux 2.6.9-kanotix-8 i686; 127x41)";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("Linux", details.OperatingSystem);
            Assert.Equal("2.6.9", details.OperatingSystemVersion);
        }

        [Fact]
        public void Should_Return_Curl_Operating_System()
        {
            // arrange
            var userAgent = "curl/7.51.0";

            // act
            var details = this.UserAgentUtility.GetUserAgentDetails(userAgent);

            // assert
            Assert.Equal("curl", details.OperatingSystem);
            Assert.Equal("7.51.0", details.OperatingSystemVersion);
        }
    }
}
