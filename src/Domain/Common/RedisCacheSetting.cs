namespace Domain.Common
{
    public class RedisCacheSetting
    {
        public string InstanceName { get; set; } = string.Empty;
        public int DefaultDatabase { get; set; } = 7;
        public int ConnectRetry { get; set; } = 5;        
    }
}
