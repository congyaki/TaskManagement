using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Entities;

namespace TaskManagement.Areas.Identity.Pages.Role
{
    [Authorize(Roles ="Admin")]
    public class UserModel : PageModel
    {
        private readonly RoleManager<TaskManagement.Entities.Role> _roleManager;
        private readonly UserManager<User> _userManager;

        public UserModel(RoleManager<TaskManagement.Entities.Role> roleManager,
                          UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        
        public List<UserInList> users { get; set; }
        public class UserInList : User
        {
            // Liệt kê các Role của User ví dụ: "Admin,Editor" ...
            public string listroles { set; get; }
        }

        [TempData] // Sử dụng Session
        public string StatusMessage { get; set; }


        public IActionResult OnPost() => NotFound("Cấm post");

        public async Task OnGet()
        {
            var lusers = (from u in _userManager.Users
                          orderby u.UserName
                          select new UserInList()
                          {
                              Id = u.Id,
                              UserName = u.UserName,
                              Code = u.Code,
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                          });
            users = await lusers.ToListAsync();
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.listroles = string.Join(",", roles.ToList());
            }

        }
    }
}
