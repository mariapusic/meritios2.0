using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NiceLIA.Data;
using NiceLIA.Models.Domain;
using NiceLIA.Models.ViewModel;

namespace NiceLIA.Pages.Users
{
	public class AddUserModel : PageModel
	{
		private readonly UserDbContext dbContext;
		[BindProperty]
		public AddUserViewModel AddUserRequest { get; set; }
		public AddUserModel(UserDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public void OnGet()
		{
		}

		public void OnPost()
		{
			var userDomainModel = new User
			{
				Name = AddUserRequest.Name,
				Email = AddUserRequest.Email,
				School = AddUserRequest.Email,
				Education = AddUserRequest.Education,
				Location = AddUserRequest.Location,
				PhoneNr = AddUserRequest.PhoneNr
			};
			dbContext._Users.Add(userDomainModel);
			dbContext.SaveChanges();
		}
	}
}
