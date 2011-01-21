namespace ServiceStackAppHarbor
{
    using System;
    using Funq;
    using ServiceModel;
    using ServiceStack.CacheAccess;
    using ServiceStack.CacheAccess.Providers;
    using ServiceStack.Configuration;
    using ServiceStack.Logging;
    using ServiceStack.WebHost.Endpoints;

    public class AppHost : AppHostBase
    {
        private static ILog log;

        public AppHost() : base("ServiceStackAppHarbor AspNet", typeof(GetFactorialService).Assembly)
        {
            LogManager.LogFactory = new ServiceStack.Logging.Support.Logging.ConsoleLogFactory();
            log = LogManager.GetLogger(typeof (AppHost));
        }

        public override void Configure(Container container)
        {
            // Signal advanced web browsers what HTTP Methods you accept
            base.SetConfig(new EndpointHostConfig()
            {
                GlobalResponseHeaders = 
                {
                    { "Access-Control-Allow-Origin", "*" },
					{ "Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS" },
                }
            });

            container.Register<IResourceManager>(new ConfigurationResourceManager());

            container.Register(c => new ExampleConfig(c.Resolve<IResourceManager>()));
            var appConfig = container.Resolve<ExampleConfig>();

            container.Register<ICacheClient>(c => new MemoryCacheClient());

            log.InfoFormat("AppHost Configured: " + DateTime.Now);
        }
    }
}