using System.Net.Security;

namespace Domain.Common
{
    public class RedisCacheSetting
    {
        public string EndPointHost { get; set; } = string.Empty;
        public int EndPointPort { get; set; } = 6379;
        public bool Ssl { get; set; }
        public string InstanceName { get; set; } = string.Empty;
        public int DefaultDatabase { get; set; } = 7;
        public int ConnectRetry { get; set; } = 5;        
    }
}
