using IdentityRoles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
 
namespace IdentityRoles.CustomTagHelpers
{
    [HtmlTargetElement("td", Attributes = "i-role")]
    public class RoleUsersTH : TagHelper
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;
 
        public RoleUsersTH(UserManager<ApplicationUser> usermgr, RoleManager<IdentityRole> rolemgr)
        {
            userManager = usermgr;
            roleManager = rolemgr;
        }
 
        [HtmlAttributeName("i-role")]
        public string Role { get; set; }
 
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> names = new List<string>();
            IdentityRole role = await roleManager.FindByIdAsync(Role);
            if (role != null)
            {
                IList<ApplicationUser> members = await userManager.GetUsersInRoleAsync(role.Name);
                if (members != null)
                {

                    foreach (ApplicationUser user in members)
                    {
                        // if (user != null && await userManager.IsInRoleAsync(user, role.Name))
                        //     names.Add(user.UserName);
                        names.Add(user.UserName);
                    }
                }
            }
            output.Content.SetContent(names.Count == 0 ? "No Users" : string.Join(", ", names));
        }
    }
} 