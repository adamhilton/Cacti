using System;
using System.Linq;
using Cacti.Web.Core.Entities;
using Cacti.Web.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Cacti.Web.Core.Extensions
{
    public static class BlogPostsRepositoryExtensionMethods
    {
        public static IQueryable<BlogPost> FilterByTag(this IQueryable<BlogPost> blogposts, string name, CactiDbContext context)
        {
            return String.IsNullOrEmpty(name) ? blogposts :
            context.BlogPostsContentTags.Include(i => i.BlogPost)
                    .Where(w => string.Equals(w.ContentTag.Name, name, StringComparison.CurrentCultureIgnoreCase))
                    .Select(s => s.BlogPost);
        }
    }
}