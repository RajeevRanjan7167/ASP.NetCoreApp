﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralApp.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUserRepository ApplicationUser { get; }
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        ICompanyRepository Company { get; }
        IProductRepository Product { get; }      
        ISP_Call SP_Call { get; }
        void Save();
    }

}
