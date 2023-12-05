using Bugeto_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bugeto_Store.Application.Interfaces.Contexts;

namespace Bugeto_Store.Application.Services.Products.Queries.GetCategories
{
    public interface IGetCategoriesService
    {
        ResultDto<List<CategoriesDto>> Execute(long ? ParentId);
     
    }
}

   