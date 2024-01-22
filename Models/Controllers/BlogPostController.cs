// Controllers/BlogPostController.cs

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using AdvancedBlogApp.Data;
using AdvancedBlogApp.Models;

[Authorize]
public class BlogPostController : Controller
{
	private readonly UserManager<ApplicationUser> _userManager;
	private readonly AppDbContext _dbContext;

	public BlogPostController(UserManager<ApplicationUser> userManager, AppDbContext dbContext)
	{
		_userManager = userManager;
		_dbContext = dbContext;
	}

	public IActionResult Index()
	{
		var userId = _userManager.GetUserId(User);
		var blogPosts = _dbContext.BlogPosts.Where(b => b.UserId == userId).ToList();
		return View(blogPosts);
	}

}
