namespace ServiceStackAppHarbor.ServiceModel
{
    using ServiceStack.Configuration;

    public class ExampleConfig
    {
        public const string DefaultNamespace = "http://schemas.servicestack.net/types";

        public ExampleConfig() { }

        public ExampleConfig(IResourceManager appConfig)
        {
            DefaultFibonacciLimit = appConfig.Get("DefaultFibonacciLimit", 10);
        }

        public string ConnectionString { get; set; }
        public int DefaultFibonacciLimit { get; set; }

    }
}