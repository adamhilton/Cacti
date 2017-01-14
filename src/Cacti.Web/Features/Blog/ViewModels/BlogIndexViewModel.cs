using Cacti.Web.Features.Shared.ViewModels;
using Sakura.AspNetCore;

namespace Cacti.Web.Features.Blog.ViewModels
{
    public class BlogIndexViewModel
    {
        public IPagedList<BlogPostWithContentTagsViewModel> BlogPosts { get; set; }
    }
}