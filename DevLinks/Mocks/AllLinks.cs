using DevInBioLinks.Models;
using static System.Net.WebRequestMethods;

namespace DevInBioLinks.Mocks {
    public class AllLinks {

        public Dictionary<string, string> LinksDictionary { get; private set; }
        public AllLinks() {
            LinksDictionary = new Dictionary<string, string>();

            List<Link> links = new List<Link> {
                new("Telegram", "https://t.me/redoredoredo"),
                new("Github", "https://github.com/1ceblink"),
                new("Instagram", "https://www.instagram.com/iceblin.k/")
            };

            foreach (var link in links) {
                LinksDictionary.Add(link.HostName, link?.URL);
            }
        }
    }
}
