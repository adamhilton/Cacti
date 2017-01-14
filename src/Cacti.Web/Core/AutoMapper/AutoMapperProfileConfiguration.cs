using Cacti.Web.Core.Entities;
using Cacti.Web.Features.Admin.Admin.ViewModels;
using Cacti.Web.Features.Blog.ViewModels;
using AutoMapper;

namespace Cacti.Web.Core.AutoMapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            CreateMap<BlogPost, BlogPostPreviewViewModel>();
            CreateMap<BlogPost, BlogPostContentViewModel>();
            CreateMap<CreateBlogPostViewModel, BlogPost>();
            CreateMap<EditBlogPostViewModel, BlogPost>();
            CreateMap<BlogPost, EditBlogPostViewModel>();
            
            CreateMap<CreateContentTagViewModel, ContentTag>();
            CreateMap<ContentTag, EditContentTagViewModel>();
            CreateMap<EditContentTagViewModel, ContentTag>();
        }
    }
}
