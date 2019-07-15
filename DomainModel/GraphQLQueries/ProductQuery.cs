using DomainModel.Models;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.GraphQLQueries
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery()
        {
            Field<ProductType>(
              "product",
              arguments: new QueryArguments(
              new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the Product." }),
              resolve: context =>
              {
                  var ss = context.UserContext;
                  var db = ((GraphQLAspNetCoreSample.GraphQLUserContext)context.UserContext).Services.GetRequiredService<TestContext>();

                  var id = context.GetArgument<int>("id");
                  var product = db
                  .Products
                  .FirstOrDefault(i => i.Id == id);
                  return product;


              });

        }
    }
}
