﻿
using System;
using System.Collections.Generic;
using System.Linq;
using Cacti.Web.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Sakura.AspNetCore;

namespace Cacti.Web.Infrastructure.Data
{
    public class ContentTagRepository : CactiRepository<ContentTag>
    {
        public ContentTagRepository(CactiDbContext context)
            : base(context)
        {
        }

        public IPagedList<ContentTag> ToPagedList(int pageNumber, int pageSize)
        {
            return _dbSet.OrderByDescending(o => o.Name).ToPagedList(pageSize, pageNumber);
        }

        public List<BlogPost> GetBlogPostsByContentTagName(string name)
        {
            return _dbContext.BlogPostsContentTags.Include(i => i.BlogPost)
                .Where(w => string.Equals(w.ContentTag.Name, name, StringComparison.CurrentCultureIgnoreCase))
                .Select(s => s.BlogPost)
                .ToList();
        }

        public ContentTag GetByName(string tag)
        {
            return _dbSet.FirstOrDefault(w => string.Equals(w.Name, tag, StringComparison.CurrentCultureIgnoreCase));
        }

        internal bool ContentTagNameAlreadyExists(string name)
        {
            return _dbSet.Any(
                w => string.Equals(
                    w.Name,
                    name,
                    StringComparison.CurrentCultureIgnoreCase
                )
            );
        }
    }
}
