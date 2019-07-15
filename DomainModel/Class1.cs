using DomainModel.Models;
using System;
using System.Collections.Generic;

namespace DomainModel
{
    public class TestRepository
    {


        public List<ProductCategory> GetProductCategory()
        {
            return
            new List<ProductCategory>()
                   {
                       new ProductCategory() { Id = 1 , Name = "product Category 1" },
                       new ProductCategory() { Id = 2 , Name = "product Category 2" },
                   };

        }


    }
}
