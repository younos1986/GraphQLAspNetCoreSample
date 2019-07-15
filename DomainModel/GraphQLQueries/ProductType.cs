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
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Name = "Product";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Product.");
            Field(x => x.ProductName).Description("The name of the Product");

            Field<ListGraphType<ProductCategoryType>>("productCategory", resolve: context =>
            {
                var db = ((GraphQLAspNetCoreSample.GraphQLUserContext)context.UserContext).Services.GetRequiredService<TestContext>();

                var productCategoryId = context.Source.ProductCategoryId;

                var query = from pc in db.ProductCategories
                            where pc.Id == productCategoryId
                            select pc;

                return query.ToList();

            });
        }
    }

}