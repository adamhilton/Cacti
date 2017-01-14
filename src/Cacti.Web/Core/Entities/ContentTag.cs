﻿
using System.Collections.Generic;

namespace Cacti.Web.Core.Entities
{
    public class ContentTag : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<BlogPostContentTag> BlogPostsContentTags { get; set; } = new List<BlogPostContentTag>();

    }
}
