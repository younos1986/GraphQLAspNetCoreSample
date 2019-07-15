using DomainModel.Models;
using GraphQL;
using GraphQL.Types;
using GraphQLAspNetCoreSample;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.GraphQLQueries
{
    public class ProductSchema : GraphQL.Types.Schema
    {
        public ProductSchema(IDependencyResolver resolver)
        //public ProductSchema(GraphQLUserContext graphQLUserContext)
        {

            // Query = graphQLUserContext.Services.GetRequiredService<ProductQuery>();

             Query = resolver.Resolve<ProductQuery>();

            // Mutation = resolver.Resolve<StarWarsMutation>();
        }
    }

}
