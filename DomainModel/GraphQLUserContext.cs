using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GraphQLAspNetCoreSample
{
    public class GraphQLUserContext
    {
        public GraphQLUserContext() { }
        public GraphQLUserContext(IServiceProvider services)
        {
            this.Services = services;
        }

        public IServiceProvider Services { get; private set; }
    }
}
