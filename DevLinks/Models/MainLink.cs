namespace DevInBioLinks.Models {
    public class Link {
        public string HostName { get; private set; }
        public string URL { get; private set; }

        public Link(string hostname, string url) {
            if (hostname is not null && url is not null) {
                (HostName, URL) = (hostname, url);
            }
        }
    }
}
