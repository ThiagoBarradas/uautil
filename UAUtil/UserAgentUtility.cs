using UAUtil.Models;

namespace UAUtil
{
    /// <summary>
    /// Utility for get User-Agent header details
    /// </summary>
    public class UserAgentUtility : IUserAgentUtility
    {
        /// <summary>
        /// Get details from User Agent like platform, browser and operating system
        /// </summary>
        /// <param name="userAgent">full user agent header</param>
        /// <returns></returns>
        public UserAgentDetails GetUserAgentDetails(string userAgent)
        {
            UserAgentDetails userAgentDetails = new UserAgentDetails()
            {
                UserAgent = userAgent
            };

            var osDetails = this.GetOperatingSystem(userAgent);
            userAgentDetails.OperatingSystem = osDetails[0];
            userAgentDetails.OperatingSystemVersion = osDetails[1];

            var browserDetails = this.GetBrowser(userAgent);
            userAgentDetails.Browser = browserDetails[0];
            userAgentDetails.BrowserVersion = browserDetails[1];

            userAgentDetails.Platform = this.GetPlatform(userAgentDetails.OperatingSystem);

            return userAgentDetails;
        }

        /// <summary>
        /// Extract browser from user agent
        /// </summary>
        /// <param name="userAgent">full user agent header</param>
        /// <returns>array with position 0 (name) and position 1 (version)</returns>
        private string[] GetBrowser(string userAgent)
        {
            if (string.IsNullOrWhiteSpace(userAgent) == true)
                return new string[] { "Unknow", "Unknow" };

            if (userAgent.Contains("Edge"))
                return new string[] { "Edge", GetVersion(userAgent, "Edge") };

            if (userAgent.Contains("SeaMonkey"))
                return new string[] { "SeaMonkey", GetVersion(userAgent, "SeaMonkey") };

            if (userAgent.Contains("Firefox"))
                return new string[] { "Firefox", GetVersion(userAgent, "Firefox") };

            if (userAgent.Contains("OPR"))
                return new string[] { "Opera", GetVersion(userAgent, "OPR") };

            if (userAgent.Contains("Opera"))
                return new string[] { "Opera", GetVersion(userAgent, "Opera") };

            if (userAgent.Contains("Chromium"))
                return new string[] { "Chromium", GetVersion(userAgent, "Chromium") };

            if (userAgent.Contains("Chrome") )
                return new string[] { "Chrome", GetVersion(userAgent, "Chrome") };

            if (userAgent.Contains("CrMo"))
                return new string[] { "Chrome", GetVersion(userAgent, "CrMo") };

            if (userAgent.Contains("Safari"))
                return new string[] { "Safari", GetVersion(userAgent, "Safari") };

            if (userAgent.Contains("MSIE"))
                return new string[] { "Internet Explorer", GetVersion(userAgent, "MSIE") };

            if (userAgent.Contains("WOW64") || userAgent.Contains("Trident"))
                return new string[] { "Internet Explorer", "11" };

            if (userAgent.Contains("curl"))
                return new string[] { "curl", GetVersion(userAgent, "curl") };

            return new string[] { "Unknow", "Unknow" };
        }

        /// <summary>
        /// Extract operating system from user agent
        /// </summary>
        /// <param name="userAgent">full user agent header</param>
        /// <returns>array with position 0 (name) and position 1 (version)</returns>
        private string[] GetOperatingSystem(string userAgent)
        {
            if (string.IsNullOrWhiteSpace(userAgent) == true)
                return new string[] { "Unknow", "Unknow" };

            if (userAgent.Contains("Android"))
                return new string[] { "Android OS", GetVersion(userAgent, "Android") };

            if (userAgent.Contains("iPad"))
                return new string[] { "iPad OS", GetVersion(userAgent, "OS") };

            if (userAgent.Contains("iPhone"))
                return new string[] { "iPhone OS", GetVersion(userAgent, "OS") };

            if ((userAgent.Contains("BB") && userAgent.Contains("Mobile")))
                return new string[] { "Black Berry", GetVersion(userAgent, "BB") };

            if (userAgent.Contains("RIM Tablet"))
                return new string[] { "Black Berry", GetVersion(userAgent, "OS") };

            if (userAgent.Contains("BlackBerry"))
                return new string[] { "Black Berry", GetVersion(userAgent, "BlackBerry") };

            if (userAgent.Contains("Windows Phone"))
                return new string[] { "Windows Phone", GetVersion(userAgent, "Windows Phone") };

            if (userAgent.Contains("Mac OS X"))
                return new string[] { "Mac OS X", GetVersion(userAgent, "Mac OS X") };

            if (userAgent.Contains("MacOS"))
                return new string[] { "Mac OS", "" };

            if (userAgent.Contains("Windows NT 5.1") || userAgent.Contains("Windows NT 5.2"))
                return new string[] { "Windows", "XP" };

            if (userAgent.Contains("Windows NT 6.0"))
                return new string[] { "Windows", "Vista" };

            if (userAgent.Contains("Windows NT 6.1"))
                return new string[] { "Windows", "7" };

            if (userAgent.Contains("Windows NT 6.2"))
                return new string[] { "Windows", "8" };

            if (userAgent.Contains("Windows NT 6.3"))
                return new string[] { "Windows", "8.1" };

            if (userAgent.Contains("Windows NT 10"))
                return new string[] { "Windows", "10" };

            if (userAgent.Contains("CentOS"))
                return new string[] { "Linux CentOS", GetVersion(userAgent, "CentOS") };

            if (userAgent.Contains("Red Hat"))
                return new string[] { "Linux Red Hat", GetVersion(userAgent, "Red Hat") };

            if (userAgent.Contains("SUSE"))
                return new string[] { "Linux SUSE", GetVersion(userAgent, "SUSE") };

            if (userAgent.Contains("Debian"))
                return new string[] { "Linux Debian", GetVersion(userAgent, "Debian") };

            if (userAgent.Contains("Arch Linux"))
                return new string[] { "Arch Linux", GetVersion(userAgent, "Arch Linux") };

            if (userAgent.Contains("Fedora"))
                return new string[] { "Linux Fedora", GetVersion(userAgent, "Fedora") };

            if (userAgent.Contains("Ubuntu"))
                return new string[] { "Linux Ubuntu", GetVersion(userAgent, "Ubuntu") };

            if (userAgent.Contains("Linux"))
                return new string[] { "Linux", GetVersion(userAgent, "Linux") };

            if (userAgent.Contains("curl"))
                return new string[] { "curl", GetVersion(userAgent, "curl") };

            return new string[] { "Unknow", "Unknow" };
        }

        /// <summary>
        /// Extract version from user agent 
        /// </summary>
        /// <param name="userAgent">full user agent header</param>
        /// <param name="value">text to split</param>
        /// <returns></returns>
        private string GetVersion(string userAgent, string value)
        {
            var temp = userAgent.Substring(userAgent.IndexOf(value) + value.Length)
                .TrimStart('-')
                .TrimStart()
                .TrimStart('/')
                .TrimStart();

            var version = string.Empty;

            foreach (var character in temp)
            {
                var validCharacter = false;
                int test = 0;

                if (int.TryParse(character.ToString(), out test))
                {
                    version += character;
                    validCharacter = true;
                }

                if (character == '.' || character == '_')
                {
                    version += '.';
                    validCharacter = true;
                }

                if (validCharacter == false)
                    break;
            }

            return version;
        }

        /// <summary>
        /// Extract platform type from operating system
        /// </summary>
        /// <param name="operatingSystem">OS name</param>
        /// <returns></returns>
        private string GetPlatform(string operatingSystem)
        {
            if (string.IsNullOrWhiteSpace(operatingSystem) == true || operatingSystem == "Unknow")
                return "Unknow";

            if (operatingSystem.Contains("Android") ||
                operatingSystem.Contains("iPad") ||
                operatingSystem.Contains("iPhone") ||
                operatingSystem.Contains("Kindle Fire") ||
                operatingSystem.Contains("Black Berry") ||
                operatingSystem.Contains("Windows Phone") ||
                operatingSystem.Contains("Android"))
            {
                return "Mobile";
            }

            if (operatingSystem.Contains("Mac") ||
                operatingSystem.Contains("Windows") ||
                operatingSystem.Contains("Linux"))
            {
                return "Desktop";
            }

            return "Unknow";
        }
    }
}