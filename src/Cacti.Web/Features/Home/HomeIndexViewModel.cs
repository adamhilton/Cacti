using Cacti.Web.Features.Shared.ViewModels;
using Sakura.AspNetCore;

namespace Cacti.Web.Features.Home
{
    public class HomeIndexViewModel
    {
        public IPagedList<BlogPostWithContentTagsViewModel> BlogPosts { get; set; }
    }
}
