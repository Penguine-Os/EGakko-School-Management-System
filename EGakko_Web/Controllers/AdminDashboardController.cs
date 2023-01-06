using EGakko_Models;
using EGakko_Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EGakko_Web.Controllers
{
    [Authorize]
    public class AdminDashboardController : Controller
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private AdminViewModel AdminViewModel { get; set; } = new AdminViewModel();

        public AdminDashboardController(UserManager<CustomUser> UserManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = UserManager;
            _roleManager = roleManager;
        }
     
        public async Task<IActionResult> Index()
        {
            AdminViewModel.Users = await _userManager.Users.ToListAsync();
            return View(AdminViewModel);
        }
        public async Task<IActionResult> UpdateUser(int id)
        {
            //if (id == 0)
            //    return View();


            //var donut = _unitOfWork.DonutRepo.GetById(id);
            //if (donut is null)
            //    return RedirectToAction("donuts");



            //return View(donut);
            AdminViewModel.Users = await _userManager.Users.ToListAsync();
            return View(AdminViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(CustomUser user)
        {

            //if (!ModelState.IsValid)
            //    return View();

            //_unitOfWork.DonutRepo.UpdateObj(donut);
            //_unitOfWork.Save();

            //return RedirectToAction("Donuts");

            AdminViewModel.Users = await _userManager.Users.ToListAsync();
            return View(AdminViewModel);
        }
        public async Task<IActionResult> DeleteUser(int id)
        {
            AdminViewModel.Users = await _userManager.Users.ToListAsync();

            return View(AdminViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(CustomUser user)
        {
            AdminViewModel.Users = await _userManager.Users.ToListAsync();

            return View(AdminViewModel);
        }

        public IActionResult ManageAccounts()
        { 
            var users =  _userManager.Users.ToList();
            List<CustomUser> defaultUsers = new List<CustomUser>();
            foreach (var user in users)
            {
                if (_userManager.IsInRoleAsync(user, "default").Result)
                {
                    defaultUsers.Add(user);
                }

            }

            AdminViewModel.Users = defaultUsers;

            return View(AdminViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ManageAccounts(CustomUser user)
        {
            AdminViewModel.Users = await _userManager.Users.ToListAsync();

            return View(AdminViewModel);
        }
    
       
   
    }
}
