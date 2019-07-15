using DomainModel.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.GraphQLQueries
{
    public class ProductCategoryType : ObjectGraphType<ProductCategory>
    {
        public ProductCategoryType()
        {
            Name = "ProductCategory";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the ProductCategory.");
            Field(x => x.Name).Description("The name of the ProductCategory");
            // Field(x => x.Products, type: typeof(ListGraphType<ProductType>)).Description("ProductCategory's Products");
        }
    }
}
