using AutoMapper;
using HXShopCoreApp.Application.ViewModels.Product;
using HXShopCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HXShopCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
