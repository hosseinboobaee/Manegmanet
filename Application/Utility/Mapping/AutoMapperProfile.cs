using AutoMapper;

namespace Application.Utility.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<Product, ProductDto>();
            //CreateMap<ProductDto, Product>();
            //CreateMap<Videos, VideoDto>().ForMember(x => x.Title , c => c.MapFrom<VideoUrlResolver>());
        }
    }
}
