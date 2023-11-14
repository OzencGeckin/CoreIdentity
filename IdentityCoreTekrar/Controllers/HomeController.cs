using IdentityCoreTekrar.Models;
using IdentityCoreTekrar.Models.AppUsers.RequestModels;
using IdentityCoreTekrar.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdentityCoreTekrar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        readonly UserManager<AppUser> _userManager;
        readonly RoleManager<AppRole> _roleManager;
        readonly SignInManager<AppUser> _signInManager;
        public HomeController(ILogger<HomeController> logger,UserManager<AppUser> userManager ,RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequestModel model)
        {
           
          
                if (ModelState.IsValid)
                {
                    AppUser appUser = new()
                    {
                        UserName = model.UserName,
                        Email = model.Email



                    };

                    IdentityResult result = await _userManager.CreateAsync(appUser, model.Password);

                    if (result.Succeeded)
                    {
                         
                        AppRole appRole = await _roleManager.FindByNameAsync("Admin"); 
                        if (appRole == null) await _roleManager.CreateAsync(new() { Name = "Admin" }); 
                        await _userManager.AddToRoleAsync(appUser, "Admin");
                       

                        return RedirectToAction("Index");
                    }
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }
      
            return View(model);
        }
    }
}