using CoreBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents
{
	public class CommentList: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					Username = "Taha"
				},
				new UserComment {
					ID = 2,
					Username = "Merve"
				}
			};
			return View(commentValues);
		}
	}
}
