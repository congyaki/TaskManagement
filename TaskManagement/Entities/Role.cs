using Microsoft.AspNetCore.Identity;

namespace TaskManagement.Entities
{
    public class Role : IdentityRole<int>
    {
        public Role() { }
        public Role(string roleName)
        {
            Name = roleName;
        }


    }
}
