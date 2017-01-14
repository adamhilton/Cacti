using Cacti.Web.Core.Exceptions;
using Cacti.Web.Features.Blog.ViewModels;
using Cacti.Web.Features.Shared.ViewModels;
using Cacti.Web.Infrastructure.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Cacti.Web.Features.Blog
{
    public class BlogController : Controller
    {
        private readonly IMapper _mapper;
        private readonly BlogPostRepository _blogPostRepository;

        public BlogController(
            IMapper mapper,
            BlogPostRepository blogPostRepository)
        {
            _mapper = mapper;
            _blogPostRepository = blogPostRepository;
        }

        [HttpGet]
        public IActionResult Index(BlogPostsRequestViewModel request)
        {
            var blogPosts = _blogPostRepository.ToPagedListOfPublishedBlogPosts(request);

            var model = new BlogIndexViewModel()
            {
                BlogPosts = blogPosts
            };

            return View(model);
        }

        [HttpGet("/blog/{blogPostTitle}")]
        public IActionResult BlogPost(string blogPostTitle)
        {
            BlogPostContentViewModel model;
            try
            {
                var blogPost = _blogPostRepository.GetByTitle(blogPostTitle);

                if (!blogPost.IsPublished)
                {
                    return NotFound();
                }

                model = _mapper.Map<BlogPostContentViewModel>(blogPost);
                model.ContentTags = _blogPostRepository.GetContentTagsByBlogPostTitle(model.Title);
            }
            catch (BlogPostNotFoundException)
            {
                //TODO: Log error
                return NotFound();
            }

            return View(model);
        }
    }
}