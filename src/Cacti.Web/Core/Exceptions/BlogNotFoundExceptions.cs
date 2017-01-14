using System;

namespace Cacti.Web.Core.Exceptions
{
    public class BlogPostNotFoundException : Exception
    {
        public override string Message { get; } = "Blog post was not found";
    }
}
