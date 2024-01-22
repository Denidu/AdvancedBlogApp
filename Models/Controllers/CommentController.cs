// Controllers/CommentController.cs

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using AdvancedBlogApp.Data;
using AdvancedBlogApp.Models;

[Authorize]
public class CommentController : Controller
{
	private readonly UserManager<ApplicationUser> _userManager;
	private readonly AppDbContext _dbContext;

	public CommentController(UserManager<ApplicationUser> userManager, AppDbContext dbContext)
	{
		_userManager = userManager;
		_dbContext = dbContext;
	}

	// Add actions for creating, editing, and deleting comments
}
