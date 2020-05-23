using System;
using System.Text;

namespace AspNetCoreDependencyInjection.Helpers
{
    public class GuidProvider
    {
        private readonly Guid _serviceGuid;

        public GuidProvider()
        {
            _serviceGuid = Guid.NewGuid();
        }

        public Guid GetNewGuid() => Guid.NewGuid();

        public Guid GetGuid() => _serviceGuid;

        public string GetGuidAsString() => _serviceGuid.ToString();

        public string GetGuidAsFormatedString(string prefix = "") => getFormatedGuid(_serviceGuid, prefix);

        public string GetNewGuidAsString() => GetNewGuid().ToString();

        public string GetNewUniqeId(string prefix = "") => getFormatedGuid(GetNewGuid(), prefix);

        private string getFormatedGuid(Guid guid, string prefix = "")
        {
            var guidString = guid.GetHashCode().ToString("x");

            if (string.IsNullOrEmpty(prefix) == false)
                guidString = new StringBuilder($"{prefix}-").Append(guidString).ToString();

            return guidString;
        }
    }
}