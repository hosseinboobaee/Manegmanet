using Application.Dtos;
using AutoMapper;
using Domain.entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utility.Resolver
{
    public class FileUrlResolver : IValueResolver<Product, ProductDto, string>
    {
        public string Resolve(Product source, ProductDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PicUrl))
            {
                return "localhost:5132/HtmlCourse/" + source.PicUrl;
            }
            return null;
        }

    }
}
