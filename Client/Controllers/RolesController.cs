using Entities;
using Microsoft.AspNetCore.Identity;


namespace Client.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;

        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleDTO model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Roles");
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return RedirectToAction("NotFound", "Shared");
            }

            var model = new RoleDTO
            {
                Id = role.Id,
                RoleName = role.Name
            };

            //foreach (var user in userManager.Users)
            //{
            //    if (await userManager.IsInRoleAsync(user, role.Name))
            //    {
            //        model.Users.Add(user);
            //    }
            //}

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(RoleDTO model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                return RedirectToAction("NotFound", "Shared");
            }
            else
            {
                role.Name = model.RoleName;
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View(model);

        }
    }
}
