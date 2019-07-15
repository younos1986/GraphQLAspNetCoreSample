using System;
using System.Collections.Generic;

namespace DomainModel.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public int? ProductCategoryId { get; set; }
        public string ProductName { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}