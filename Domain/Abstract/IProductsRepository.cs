using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Abstract
{
    public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
