using System;
using ServiceStack;
using SvelteSpaTemplate.ServiceModel;

namespace SvelteSpaTemplate.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
