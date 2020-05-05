﻿using GeneralApp.Models;
using GeneralApp.Models.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralApp.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
