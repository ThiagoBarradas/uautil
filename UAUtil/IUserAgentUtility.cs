using UAUtil.Models;

namespace UAUtil
{
    /// <summary>
    /// Interface for get User-Agent header details
    /// </summary>
    public interface IUserAgentUtility
    {
        /// <summary>
        /// Get details from User Agent like platform, browser and operating system
        /// </summary>
        /// <param name="userAgent">full user agent header</param>
        /// <returns></returns>
        UserAgentDetails GetUserAgentDetails(string userAgent);
    }
}