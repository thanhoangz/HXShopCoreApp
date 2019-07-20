using HXShopCoreApp.Data.Entities;
using HXShopCoreApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace HXShopCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository: IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
