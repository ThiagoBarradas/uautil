namespace UAUtil.Models
{
    /// <summary>
    /// User Agent header details
    /// </summary>
    public class UserAgentDetails
    {
        /// <summary>
        /// Full user agent details
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Platform (Mobile, Desktop or Unknow)
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Browser (main browser names)
        /// </summary>
        public string Browser { get; set; }

        /// <summary>
        /// Browser version
        /// </summary>
        public string BrowserVersion { get; set; }

        /// <summary>
        /// Operating System (main OS names)
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Operating System version
        /// </summary>
        public string OperatingSystemVersion { get; set; }
    }
}
