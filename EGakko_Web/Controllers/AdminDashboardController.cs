using EGakko_Models;
using EGakko_Web.Migrations;
using EGakko_Web.Models;
using EGakko_Web.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace EGakko_Web.Controllers
{
    [Authorize]
    public class AdminDashboardController : Controller
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;

        private AdminViewModel AdminViewModel { get; set; } = new AdminViewModel();

        public AdminDashboardController(UserManager<CustomUser> UserManager,
            RoleManager<IdentityRole> roleManager, IUnitOfWork unitOfWork)
        {
            _userManager = UserManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;

            var users = _userManager.Users.ToList();

            foreach (var user in users)
            {
                if (_userManager.IsInRoleAsync(user, "teacher").Result || _userManager.IsInRoleAsync(user, "student").Result)
                {
                    AdminViewModel.StudentsAndTeacher.Add(user);
                }
                else
                {
                    AdminViewModel.UsersWithoutRoles.Add(user);
                }

            }

        }

        public async Task<IActionResult> Index()
        {

            return View(AdminViewModel);
        }
        public async Task<IActionResult> UpdateUser(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return RedirectToAction("index");

            
  
            return View(MapToViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateUserViewModel UpdateUserVm)
        {

            if (!ModelState.IsValid)
                return View(UpdateUserVm);
            CustomUser customUser = _userManager.Users.Where(w => w.Id == UpdateUserVm.CustomUserId).FirstOrDefault();
            MapCustomUser(UpdateUserVm, customUser);


            if (UpdateUserVm.Role == "teacher")
            {
                var teacher = _unitOfWork.TeacherRepo.GetSingleByFilter(x => x.CustomUserIdTeacher == UpdateUserVm.CustomUserId).Result;

                teacher.Salary = UpdateUserVm.TeacherSalery;
                teacher.DiplomaTitle = UpdateUserVm.TeacherDiploma;


                _unitOfWork.TeacherRepo.Update(teacher);


            }
            else if (UpdateUserVm.Role == "student")
            {
                var student = _unitOfWork.StudentRepo.GetSingleByFilter(x => x.CustomUserIdStudent == UpdateUserVm.CustomUserId).Result;
                student.FieldId = UpdateUserVm.StudentFieldId;
                student.ClassId = UpdateUserVm.StudentClassId;
                student.FeesArePayed = UpdateUserVm.StudentFeesArePayed;

                _unitOfWork.StudentRepo.Update(student);
            }
            await _userManager.UpdateAsync(customUser);
            return RedirectToAction("index");
        }

        private static void MapCustomUser(UpdateUserViewModel UpdateUserVm, CustomUser cUser)
        {
            cUser.FName = UpdateUserVm.CustomUserFirstName;
            cUser.LName = UpdateUserVm.CustomUserLastName;
            cUser.Email = UpdateUserVm.CustomUserEmail;
            cUser.HouseNumber = UpdateUserVm.CustomUserHouseNumber;
            cUser.ZipCode = UpdateUserVm.CustomUserZipCode;
            cUser.City = UpdateUserVm.CustomUserCity;
            cUser.BirthDate = UpdateUserVm.CustomUserBirthDate;
            cUser.Street = UpdateUserVm.CustomUserStreet;
        }

        public IActionResult ManageAccounts()
        {
            return View(AdminViewModel);
        }


        public IActionResult DeleteUser(string id)
        {
            
            CustomUser newCustomUser = MapUser(id);
            return View(newCustomUser);
        }

        private CustomUser MapUser(string id)
        {
            var user = _userManager.Users.Where(u => u.Id == id).FirstOrDefault();
            var newCustomUser = new CustomUser();
            newCustomUser.Id = user.Id;
            newCustomUser.FName = user.FName;
            newCustomUser.LName = user.LName;
            newCustomUser.Street = user.Street;
            newCustomUser.HouseNumber = user.HouseNumber;
            newCustomUser.ZipCode = user.ZipCode;
            newCustomUser.BirthDate = user.BirthDate;
            newCustomUser.Email = user.Email;
            newCustomUser.Gender = user.Gender;
            newCustomUser.SecurityStamp = "-";
            newCustomUser.ConcurrencyStamp = "-";
            return newCustomUser;
        }
        private UpdateUserViewModel MapToViewModel(string id)
        {
            UpdateUserViewModel vm = new UpdateUserViewModel();
            var user = _userManager.Users.Where(u => u.Id == id).FirstOrDefault();
            var role = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

            if (role == "teacher")
            {
                var teacher = _unitOfWork.TeacherRepo
                    .GetSingleByFilter(x => x.CustomUserIdTeacher == user.Id).Result;
                vm.TeacherId = teacher.Id;
                vm.TeacherSalery = teacher.Salary;
                vm.TeacherDiploma = teacher.DiplomaTitle;
            }
            else if (role == "student")
            {

                var student = _unitOfWork.StudentRepo
                    .GetSingleByFilter(x => x.CustomUserIdStudent == user.Id).Result;
                vm.Classes = _unitOfWork.ClassRepo.GetAll()
                    .Result.Select(s => new SelectListItem { Text= s.ClassName, Value = s.Id.ToString() }).ToList();
                vm.Fields = _unitOfWork.StudyFieldRepo.GetAll()
                     .Result.Select(f => new SelectListItem { Text = f.Name, Value = f.Id.ToString()}).ToList();
                vm.StudentId = student.Id;
                vm.StudentFeesArePayed = student.FeesArePayed;
                vm.StudentClassId = student.ClassId;
                vm.StudentFieldId = student.FieldId;
            }
           
            
            vm.CustomUserId = user.Id;
            vm.Role = role;
            vm.CustomUserFirstName = user.FName;
            vm.CustomUserLastName = user.LName;
            vm.CustomUserEmail = user.Email;
            vm.CustomUserStreet = user.Street;
            vm.CustomUserHouseNumber = user.HouseNumber;
            vm.CustomUserZipCode = user.ZipCode;
            vm.CustomUserCity = user.City;
            vm.CustomUserBirthDate = (DateTime)user.BirthDate;


            return vm;

        }

        [HttpPost]
        public IActionResult DeleteUser(CustomUser customUser)
        {
            var user = _userManager.Users.Where(x => x.Id == customUser.Id).FirstOrDefault();
            if (user == null)
                return View();

            _userManager.DeleteAsync(user);
            var role = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

            if (role == "teacher")
            {
                var teacher = _unitOfWork.TeacherRepo
                    .GetAllJoined(t => t.CustomUserTeacher).Result
                    .Where(cu => cu.CustomUserIdTeacher == user.Id).FirstOrDefault();

                _unitOfWork.TeacherRepo.Delete(teacher);
            }
            else if (role == "student")
            {

                var teacher = _unitOfWork.TeacherRepo
                    .GetAllJoined(t => t.CustomUserTeacher).Result
                    .Where(cu => cu.CustomUserIdTeacher == user.Id).FirstOrDefault();

                _unitOfWork.TeacherRepo.Delete(teacher);
            }
            // return RedirectToAction("Donuts");

            return View(AdminViewModel);
        }


    }
}
