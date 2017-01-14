using System.Collections.Generic;
using Cacti.Web.Core.Entities;

namespace Cacti.Web.Features.Shared.ViewModels
{
    public class BlogPostWithContentTagsViewModel
    {
        public BlogPost BlogPost { get; set; }
        public ICollection<ContentTag> ContentTags { get; set; } = new List<ContentTag>();
    }
}
