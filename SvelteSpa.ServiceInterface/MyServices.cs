using System;
using ServiceStack;
using SvelteSpa.ServiceModel;

namespace SvelteSpa.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
